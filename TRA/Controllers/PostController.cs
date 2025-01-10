using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
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

            var result = await _postService.AddAsync(Mapper.Map<PostAddDto>(postAddDto), LoggedInUser.UserName, LoggedInUser.Id);

            return result.ResultStatus == ResultStatus.Success
                ? Ok(result)
                : NoContent();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(PostUpdateDto postUpdateDto)
        {
            var result = await _postService.UpdateAsync(Mapper.Map<PostUpdateDto>(postUpdateDto), LoggedInUser.UserName);

            return result.ResultStatus == ResultStatus.Success
                ? Ok(result)
                : NoContent();
        }

        [HttpDelete("Delete/{postId}")]
        public async Task<IActionResult> Delete(int postId)
        {
            var result = await _postService.DeleteAsync(postId, LoggedInUser.UserName);

            return result.ResultStatus == ResultStatus.Success
                ? Ok(result)
                : NoContent();
        }

        [HttpDelete("HardDelete/{postId}")]
        public async Task<IActionResult> HardDelete(int postId)
        {
            var result = await _postService.HardDeleteAsync(postId);

            return result.ResultStatus == ResultStatus.Success
                ? Ok(result)
                : NoContent();
        }

        [HttpPost("UndoDelete/{postId}")]
        public async Task<IActionResult> UndoDelete(int postId)
        {
            var result = await _postService.UndoDeleteAsync(postId, LoggedInUser.UserName);

            return result.ResultStatus == ResultStatus.Success
                ? Ok(result)
                : NoContent();
        }

        //Get Post by Id
        [HttpGet("GetPost/{postId}")]
        public async Task<IActionResult> GetPostById(int postId)
        {
            var result = await _postService.GetAsync(postId);

            return result != null
                ? Ok(result.Data)
                : NoContent();
        }

        [HttpGet("GetAllPosts")]
        public async Task<IActionResult> GetAllPosts()
        {
            var result = await _postService.GetAllAsync();

            return result != null
                ? Ok(result.Data)
                : NoContent();
        }

        [HttpGet("GetAllByCategory/{categoryId}")]
        public async Task<IActionResult> GetAllByCategory(int categoryId)
        {
            var result = await _postService.GetAllByCategoryAsync(categoryId);

            return result != null
                ? Ok(result.Data)
                : NoContent();
        }

        [HttpGet("GetAllByNonDeleted")]
        public async Task<IActionResult> GetAllByNonDeletedAsync()
        {
            var result = await _postService.GetAllByNonDeletedAsync();

            return result != null
                ? Ok(result.Data)
                : NoContent();
        }

        [HttpGet("GetAllByNonDeletedAndActive")]
        public async Task<IActionResult> GetAllByNonDeletedAndActiveAsync()
        {
            var result = await _postService.GetAllByNonDeletedAndActiveAsync();

            return result != null
                ? Ok(result.Data)
                : NoContent();
        }

        [HttpGet("GetAllDeleted")]
        public async Task<IActionResult> GetAllDeletedPosts()
        {
            var result = await _postService.GetAllByDeletedAsync();

            return result != null
                ? Ok(result.Data)
                : NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string keyword, bool isAscending)
        {
            var searchResult = await _postService.SearchAsync(keyword, isAscending);
            if(searchResult.ResultStatus == ResultStatus.Success)
            {
                return Ok(searchResult.Data);
            }
            return NoContent();
        }
    }
}
