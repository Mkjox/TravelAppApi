using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
using TRA.Shared.Utilities.Results.ComplexTypes;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : BaseController
    {
        private readonly IList<Comment> _comments = new List<Comment>();
        private readonly IMapper _mapper;
        private readonly ICommentService _commentService;

        public CommentController(UserManager<User> userManager, IMapper mapper, ICommentService commentService) : base(userManager, mapper)
        {
            _mapper = mapper;
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetComments()
        {
            return Ok(_comments);
        }

        [HttpPost]
        public async Task<IActionResult> AddComments([FromBody] Comment comment)
        {
            if (ModelState.IsValid)
            {
                var commentAddDto = _mapper.Map<CommentAddDto>(comment);

                var result = await _commentService.AddAsync(commentAddDto);

                if (result.ResultStatus == ResultStatus.Success)
                {
                    return Ok(new { Message = result.Message, Comment = comment });
                }
                else
                {
                    return BadRequest(new { ErrorMessage = result.Message });
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
    }
}
