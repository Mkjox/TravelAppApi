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
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public PostController(UserManager<User> userManager, IMapper mapper, IPostService postService, ICategoryService categoryService) : base(userManager, mapper)
        {
            _postService = postService;
            _categoryService = categoryService;
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet("GetAdd")]
        public async Task<IActionResult> Add()
        {
            var result = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data.Categories);
            }
            else return Json(null);
        }

        [HttpPost("PostAdd")]
        public async Task<IActionResult> Add([FromBody] PostAddDto postAddDto)
        {
            if (ModelState.IsValid)
            {
                var _postAddDto = _mapper.Map<PostAddDto>(postAddDto);

                var result = await _postService.AddAsync(_postAddDto, LoggedInUser.UserName, LoggedInUser.Id);

                if (result.ResultStatus == ResultStatus.Success)
                {
                    return Json(new
                    {
                        result.Message,
                        Title = "Post Added Successfully!"
                    });
                }
                else
                    return Json(null);
            }
            var categories = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            postAddDto.Category = (Category)categories.Data.Categories;

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors.Select(x => x.ErrorMessage));
                return Json(new { Result = false, Message = "Please fill all the required spaces.", Errors = errors });

                //return BadRequest(new { ErrorMessage = "ModelState is not valid", ModelStateErrors = ModelState.Values.SelectMany(v => v.Errors) });
            }
            return Json(new { Result = false, Message = "There has been an error adding the post." });


            // _posts.Add(post);
            //return CreatedAtAction(nameof(GetPosts), new { id = post.Id }, post);
        }

        [HttpGet("GetUpdate")]
        public async Task<IActionResult> Update(int postId)
        {
            var postResult = await _postService.GetPostUpdateDtoAsync(postId);
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            if (postResult.ResultStatus == ResultStatus.Success && categoriesResult.ResultStatus == ResultStatus.Success)
            {
                var postUpdateDto = Mapper.Map<PostUpdateDto>(postResult.Data);
                return Json(postUpdateDto);
            }
            else
                return Json(null);
        }

        [HttpPost("PostUpdate")]
        public async Task<IActionResult> Update([FromBody] PostUpdateDto postUpdateDto)
        {
            var _postUpdateDto = _mapper.Map<PostUpdateDto>(postUpdateDto);
            var result = _postService.UpdateAsync(_postUpdateDto, LoggedInUser.UserName);

            if (result.IsCompletedSuccessfully)
            {
                return Ok(result);
            }
            else
                return Json(null);
        }

        [HttpPost("PostDelete")]
        public async Task<JsonResult> Delete(int postId)
        {
            var result = await _postService.DeleteAsync(postId, LoggedInUser.UserName);
            var postResult = JsonSerializer.Serialize(result);
            return Json(postResult);
        }

        [HttpPost("PostHardDelete")]
        public async Task<JsonResult> HardDelete(int postId)
        {
            var result = await _postService.HardDeleteAsync(postId);
            var hardDeletePostResult = JsonSerializer.Serialize(result);
            return Json(hardDeletePostResult);
        }

        [HttpPost("PostUndoDelete")]
        public async Task<JsonResult> UndoDelete(int postId)
        {
            var result = await _postService.UndoDeleteAsync(postId, LoggedInUser.UserName);
            var undoDeletePostResult = JsonSerializer.Serialize(result);
            return Json(undoDeletePostResult);
        }

        [HttpGet]
        public async Task<JsonResult> GetPosts()
        {
            var posts = await _postService.GetAllByNonDeletedAndActiveAsync();
            if (posts != null)
            {
                var postResult = JsonSerializer.Serialize(posts, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(postResult);
            }
            else return Json(null);
        }

        [HttpGet("GetAllPosts")]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _postService.GetAllAsync();
            if (posts != null)
            {
                var postResult = JsonSerializer.Serialize(posts, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Ok(postResult);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("GetAllByNonDeleted")]
        public async Task<JsonResult> GetAllByNonDeletedAsync()
        {
            var posts = await _postService.GetAllByNonDeletedAsync();
            if (posts != null)
            {
                var postResult = JsonSerializer.Serialize(posts, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(postResult);
            }
            else return Json(null);
        }

        [HttpGet("GetAllByNonDeletedAndActive")]
        public async Task<JsonResult> GetAllByNonDeletedAndActiveAsync()
        {
            var posts = await _postService.GetAllByNonDeletedAndActiveAsync();
            if (posts != null)
            {
                var postResult = JsonSerializer.Serialize(posts, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(postResult);
            }
            else return Json(null);
        }

        [HttpGet("GetAllDeleted")]
        public async Task<JsonResult> GetAllDeletedPosts()
        {
            var result = await _postService.GetAllByDeletedAsync();
            if (result != null)
            {
                var posts = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(posts);
            }
            else return Json(null);
        }

    }
}
