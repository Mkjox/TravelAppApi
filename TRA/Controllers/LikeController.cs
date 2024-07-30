using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpPost("likePost")]
        public async Task<IActionResult> LikePost([FromBody] LikeDto likeDto)
        {
            await _likeService.LikePostAsync(likeDto.UserId, likeDto.PostId);
            return Ok();
        }

        [HttpPost("unlikePost")]
        public async Task<IActionResult> UnlikePost([FromBody] LikeDto likeDto)
        {
            await _likeService.UnlikePostAsync(likeDto.UserId, likeDto.PostId);
            return Ok();
        }

        [HttpPost("likeComment")]
        public async Task<IActionResult> LikeComment([FromBody] LikeDto likeDto)
        {
            await _likeService.LikeCommentAsync(likeDto.UserId, likeDto.CommentId);
            return Ok();
        }

        [HttpPost("unlikeComment")]
        public async Task<IActionResult> UnlikeComment([FromBody] LikeDto likeDto)
        {
            await _likeService.UnlikeCommentAsync(likeDto.UserId, likeDto.CommentId);
            return Ok();
        }
    }
}
