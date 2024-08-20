using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Concrete;
using TRA.Shared.Utilities.Results.Concrete;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController
    {
        private readonly JwtService _jwtService;

        public AccountController(UserManager<User> userManager, IMapper mapper, JwtService jwtService) : base(userManager, mapper)
        {
            _jwtService = jwtService;
        }

        [HttpGet("current-user")]
        public IActionResult GetCurrentUser()
        {
            return GetLoggedInUserInfo();
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
            var result = await UserManager.CreateAsync(user, userAddDto.Password);

            if (result.Succeeded)
            {
                var token = _jwtService.GenerateToken(user);

                return Ok(new { token, user });
            }
            return BadRequest(new { Result = false, Message = "User Registration failed.", Errors = result.Errors });
        }
    }
}