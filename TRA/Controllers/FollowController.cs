using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;

namespace TRA.Controllers
{
    [Route("api/follow")]
    [ApiController]
    public class FollowController : ControllerBase
    {
        private readonly IFollowService _followService;

        public FollowController(IFollowService followService)
        {
            _followService = followService;
        }

        [HttpPost("followUser")]
        public async Task<IActionResult> FollowUser([FromBody] FollowDto followDto)
        {
            await _followService.FollowUserAsync(followDto.FollowerId, followDto.FolloweeId);
            return Ok();
        }

        [HttpPost("unfollowUser")]
        public async Task<IActionResult> UnfollowUser([FromBody] FollowDto followDto)
        {
            await _followService.UnfollowAsync(followDto.FollowerId, followDto.FolloweeId);
            return Ok();
        }

        [HttpGet("listFollowingUsers")]
        public async Task<IActionResult> ListFollowingUsers([FromBody] FollowDto followDto)
        {
            await _followService.
        }

    }
}
