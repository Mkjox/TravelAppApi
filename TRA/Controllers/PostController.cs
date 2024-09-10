using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
using TRA.Shared.Utilities.Results.Abstract;
using TRA.Shared.Utilities.Results.ComplexTypes;

namespace TRA.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : BaseController
    {
        private readonly IPostService _postService;

        public PostController(UserManager<User> userManager, IMapper mapper, IPostService postService) : base(userManager, mapper)
        {
            _postService = postService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(PostAddDto postAddDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors.Select(x => x.ErrorMessage));
                return BadRequest(new { Result = false, Message = "Please fill all the required fields.", Errors = errors });
            }

            var _postAddDto = Mapper.Map<PostAddDto>(postAddDto);
            var result = await _postService.AddAsync(_postAddDto, LoggedInUser.UserName, LoggedInUser.Id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result);
            }

            else
                return NoContent();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(PostUpdateDto postUpdateDto)
        {
            var _postUpdateDto = Mapper.Map<PostUpdateDto>(postUpdateDto);
            var result = await _postService.UpdateAsync(_postUpdateDto, LoggedInUser.UserName);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result);
            }

            else
                return NoContent();
        }

        [HttpDelete("Delete/{postId}")]
        public async Task<IActionResult> Delete(int postId)
        {
            var result = await _postService.DeleteAsync(postId, LoggedInUser.UserName);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result);
            }

            else
                return NoContent();
        }

        [HttpDelete("HardDelete/{postId}")]
        public async Task<IActionResult> HardDelete(int postId)
        {
            var result = await _postService.HardDeleteAsync(postId);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result);
            }

            else
                return NoContent();
        }

        [HttpPost("UndoDelete/{postId}")]
        public async Task<IActionResult> UndoDelete(int postId)
        {
            var result = await _postService.UndoDeleteAsync(postId, LoggedInUser.UserName);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result);
            }

            else
                return NoContent();
        }

        //Get Post by Id
        [HttpGet("GetPost/{postId}")]
        public async Task<IActionResult> GetPostById(int postId)
        {
            var post = await _postService.GetAsync(postId);

            if (post != null)
            {
                return Ok(post.Data);
            }

            else
                return NoContent();
        }

        [HttpGet("GetAllPosts")]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _postService.GetAllAsync();

            if (posts != null)
            {
                return Ok(posts.Data);
            }

            else
                return NoContent();
        }

        [HttpGet("GetAllByNonDeleted")]
        public async Task<IActionResult> GetAllByNonDeletedAsync()
        {
            var posts = await _postService.GetAllByNonDeletedAsync();

            if (posts != null)
            {
                return Ok(posts.Data);
            }

            else
                return NoContent();
        }

        [HttpGet("GetAllByNonDeletedAndActive")]
        public async Task<IActionResult> GetAllByNonDeletedAndActiveAsync()
        {
            var posts = await _postService.GetAllByNonDeletedAndActiveAsync();

            if (posts != null)
            {
                return Ok(posts.Data);
            }

            else
                return NoContent();
        }

        [HttpGet("GetAllDeleted")]
        public async Task<IActionResult> GetAllDeletedPosts()
        {
            var posts = await _postService.GetAllByDeletedAsync();

            if (posts != null)
            {
                return Ok(posts.Data);
            }

            else
                return NoContent();
        }

    }
}
