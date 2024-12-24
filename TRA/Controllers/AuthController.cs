using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TRA.Data.Concrete.EntityFramework.Contexts;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
using TRA.Services.Concrete;

namespace TRA.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IJwtService _jwtService;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IJwtService jwtService, IMapper mapper) : base(userManager, mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserAddDto userAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = Mapper.Map<User>(userAddDto);
            var result = await _userManager.CreateAsync(user, userAddDto.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok(new { Token = _jwtService.GenerateToken(user) });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(userLoginDto.Email, userLoginDto.Password, false, false);

            if (!result.Succeeded)
            {
                Console.WriteLine(result.ToString());
                return Unauthorized("Login failed. Please check your credentials.");
            }

            var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
            if (user == null)
            {
                return Unauthorized("User not found.");
            }

            return Ok(new { Token = _jwtService.GenerateToken(user) });
        }

        [HttpGet("current-user")]
        public IActionResult GetCurrentUser()
        {
            return GetLoggedInUserInfo();
        }
    }
}