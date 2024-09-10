using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                var errors = ModelState.Values.SelectMany(v => v.Errors.Select(x => x.ErrorMessage)).ToList();
                return BadRequest(new { Result = false, Message = "Please fill all the required fields.", Errors = errors });
            }

            var user = new User { UserName = userAddDto.UserName, Email = userAddDto.Email };
            var result = await _userManager.CreateAsync(user, userAddDto.Password);

            if (result.Succeeded)
            {
                var token = _jwtService.GenerateToken(user);

                return Ok(new { token, user });
            }
            return BadRequest(new { Result = false, Message = "User Registration failed.", Errors = result.Errors });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDto.Email);

            if (user == null)
            {
                return Unauthorized(new { Message = "Invalid email or password." });
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, userLoginDto.Password, false, false);

            if (!result.Succeeded)
                return Unauthorized(new { Message = "Invalid email or password." });

            var token = _jwtService.GenerateToken(user);

            return Ok(new { token, user });


            //var result = await _signInManager.PasswordSignInAsync(userLoginDto.Email, userLoginDto.Password, false, false);

            //if (!result.Succeeded)
            //    return Unauthorized();

            //return Ok();
        }

        [HttpGet("current-user")]
        public IActionResult GetCurrentUser()
        {
            return GetLoggedInUserInfo();
        }

    }
}