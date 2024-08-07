﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
using TRA.Shared.Utilities.Results.ComplexTypes;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : BaseController
    {
        private readonly IPostService _postService;
        private readonly ICategoryService _categoryService;

        public PostController(UserManager<User> userManager, IMapper mapper, IPostService postService, ICategoryService categoryService) : base(userManager, mapper)
        {
            _postService = postService;
            _categoryService = categoryService;
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
                return StatusCode(500, new { Result = false, Message = "An error occured while adding the post.", Details = result.Message });
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
                return StatusCode(500, new { Result = false, Message = "An error occured while updating the post.", Details = result.Message });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int postId)
        {
            var result = await _postService.DeleteAsync(postId, LoggedInUser.UserName);
            var postResult = JsonSerializer.Serialize(result);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(postResult);
            }
            else
                return StatusCode(500, new { Result = false, Message = "An error occured while deleting the post.", Details = result.Message });
        }

        [HttpDelete("HardDelete")]
        public async Task<IActionResult> HardDelete(int postId)
        {
            var result = await _postService.HardDeleteAsync(postId);
            var hardDeletePostResult = JsonSerializer.Serialize(result);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(hardDeletePostResult);
            }
            else
                return StatusCode(500, new { Result = false, Message = "An error occured while permamently deleting the post.", Details = result.Message });
        }

        [HttpPost("UndoDelete")]
        public async Task<JsonResult> UndoDelete(int postId)
        {
            var result = await _postService.UndoDeleteAsync(postId, LoggedInUser.UserName);
            var undoDeletePostResult = JsonSerializer.Serialize(result);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(undoDeletePostResult);
            }
            else
                return Json(null);
        }

        //Get Post by Id
        [HttpGet("GetPost")]
        public async Task<JsonResult> GetPostById(int postId)
        {
            var post = await _postService.GetAsync(postId);
            var postResult = JsonSerializer.Serialize(post, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return Json(postResult);
        }

        [HttpGet("GetAllPosts")]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _postService.GetAllAsync();
            if (posts.ResultStatus == ResultStatus.Success)
            {
                return Json(posts);
            }

            else
                return Json(null);
        }

        [HttpGet("GetAllByNonDeleted")]
        public async Task<JsonResult> GetAllByNonDeletedAsync()
        {
            var posts = await _postService.GetAllByNonDeletedAsync();
            if (posts.ResultStatus == ResultStatus.Success)
            {
                return Json(posts);
            }
            else
                return Json(null);
        }

        [HttpGet("GetAllByNonDeletedAndActive")]
        public async Task<JsonResult> GetAllByNonDeletedAndActiveAsync()
        {
            var posts = await _postService.GetAllByNonDeletedAndActiveAsync();
            if (posts.ResultStatus == ResultStatus.Success)
            {
                return Json(posts);
            }
            else return Json(null);
        }

        [HttpGet("GetAllDeleted")]
        public async Task<JsonResult> GetAllDeletedPosts()
        {
            var posts = await _postService.GetAllByDeletedAsync();
            if (posts.ResultStatus == ResultStatus.Success)
            {
                return Json(posts);
            }
            else
                return Json(null);
        }

    }
}
