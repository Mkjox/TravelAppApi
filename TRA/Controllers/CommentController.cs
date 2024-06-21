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
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : BaseController
    {
        private readonly IList<Comment> _comments = new List<Comment>();
        private readonly ICommentService _commentService;

        public CommentController(UserManager<User> userManager, IMapper mapper, ICommentService commentService) : base(userManager, mapper)
        {
            _commentService = commentService;
        }

        [HttpGet("GetComments")]
        public async Task<IActionResult> GetComments()
        {
            return Ok(_comments);
        }

        [HttpPost("AddComments")]
        public async Task<IActionResult> AddComments([FromBody] Comment comment)
        {
            if (ModelState.IsValid)
            {
                var commentAddDto = Mapper.Map<CommentAddDto>(comment);

                var result = await _commentService.AddAsync(commentAddDto);

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

        [HttpPost("GetComment")]
        public async Task<IActionResult> GetCommentById(int commentId)
        {
            var comment = await _commentService.GetAsync(commentId);
            return Json(comment);
        }

        [HttpPost("GetAllComments")]
        public async Task<IActionResult> GetAllComments()
        {
            var comments = await _commentService.GetAllAsync();
            if (comments != null)
            {
                return Json(comments);
            }

            else
                return Json(null);
        }

        [HttpPost("GetDeletedComments")]
        public async Task<IActionResult> GetDeletedComments()
        {
            var comments = await _commentService.GetAllByDeletedAsync();
            if (comments != null)
                return Json(comments);

            else
                return Json(null);
        }

        [HttpPost]
        public async Task<IActionResult> GetAllByNonDeletedComments()
        {
            var comments = await _commentService.GetAllByNonDeletedAsync();
            if (comments != null)
                return Json(comments);

            else
                return Json(null);
        }

        [HttpPost]
        public async Task<IActionResult> GetAllByNonDeletedAndActiveComments()
        {
            var comments = await _commentService.GetAllByNonDeletedAndActiveAsync();
            if (comments != null)
                return Json(comments);
            else
                return Json(null);
        }

        [HttpPost]
        public async Task<IActionResult> CountComments()
        {
            var comments = await _commentService.CountAsync();
            var commentResult = JsonSerializer.Serialize(comments.Data,new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(commentResult);
        }
    }
}
