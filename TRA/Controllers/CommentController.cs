using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    [Route("api/comment")]
    [ApiController]
    public class CommentController : BaseController
    {
        private readonly IList<Comment> _comments = new List<Comment>();
        private readonly ICommentService _commentService;

        public CommentController(UserManager<User> userManager, IMapper mapper, ICommentService commentService) : base(userManager, mapper)
        {
            _commentService = commentService;
        }

        [HttpPost("AddComment")]
        public async Task<IActionResult> AddComment(CommentAddDto commentAddDto)
        {
            if (ModelState.IsValid)
            {
                var _commentAddDto = Mapper.Map<CommentAddDto>(commentAddDto);

                var result = await _commentService.AddAsync(_commentAddDto);

                if (result.ResultStatus == ResultStatus.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            var comments = await _commentService.GetAllByNonDeletedAndActiveAsync();

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(c => c.Errors.Select(x => x.ErrorMessage)).ToList();
                return Json(new { Result = false, Message = "Please fill all the required spaces.", Errors = errors });
            }
            return Json(new { Result = false, Message = "There has been an error adding the comment." });
        }

        [HttpPut("UpdateComment")]
        public async Task<IActionResult> UpdateComment(CommentUpdateDto commentUpdateDto)
        {
            var _commentUpdateDto = Mapper.Map<CommentUpdateDto>(commentUpdateDto);
            var result = await _commentService.UpdateAsync(_commentUpdateDto, LoggedInUser.UserName);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(result);
            }

            else
                return Json(null);
        }

        [HttpDelete("DeleteComment/{commentId}")]
        public async Task<IActionResult> DeleteComment(int commentId)
        {
            var result = await _commentService.DeleteAsync(commentId, LoggedInUser.UserName);
            var commentResult = JsonSerializer.Serialize(result);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(commentResult);
            }
            else
                return Json(null);
        }

        [HttpDelete("HardDeleteComment/{commentId}")]
        public async Task<IActionResult> HardDeleteComment(int commentId)
        {
            var result = await _commentService.HardDeleteAsync(commentId);
            var hardDeleteCommentResult = JsonSerializer.Serialize(result);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(hardDeleteCommentResult);
            }
            else
                return Json(null);
        }

        [HttpGet("GetCommentById/{commentId}")]
        public async Task<IActionResult> GetCommentById(int commentId)
        {
            var comment = await _commentService.GetAsync(commentId);
            return Json(comment);
        }

        [HttpGet("GetAllComments")]
        public async Task<IActionResult> GetAllComments()
        {
            var comments = await _commentService.GetAllAsync();
            if (comments != null)
            {
                return Ok(comments.Data);
            }

            else
                return NoContent();
        }

        [HttpGet("GetDeletedComments")]
        public async Task<IActionResult> GetDeletedComments()
        {
            var comments = await _commentService.GetAllByDeletedAsync();
            if (comments != null)
                return Ok(comments.Data);

            else
                return NoContent();
        }

        [HttpGet("GetAllByNonDeleted")]
        public async Task<IActionResult> GetAllByNonDeletedComments()
        {
            var comments = await _commentService.GetAllByNonDeletedAsync();
            if (comments != null)
                return Ok(comments.Data);

            else
                return NoContent();
        }

        [HttpGet("GetAllByNonDeletedAndActive")]
        public async Task<IActionResult> GetAllByNonDeletedAndActiveComments()
        {
            var comments = await _commentService.GetAllByNonDeletedAndActiveAsync();
            if (comments != null)
                return Ok(comments.Data);
            else
                return NoContent();
        }

        [HttpGet("CountComments")]
        public async Task<IActionResult> CountComments()
        {
            var comments = await _commentService.CountAsync();
            var commentResult = JsonSerializer.Serialize(comments.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(commentResult);
        }

        [HttpGet("CountNonDeletedComments")]
        public async Task<IActionResult> CountNonDeletedComments()
        {
            var comments = await _commentService.CountByNonDeletedAsync();
            var commentResult = JsonSerializer.Serialize(comments.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(commentResult);
        }
    }
}
