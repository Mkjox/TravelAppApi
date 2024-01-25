using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Concrete;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : BaseController
    {
        private readonly IList<Comment> _comments = new List<Comment>();
        private readonly IMapper _mapper;

        public CommentController(UserManager<User> userManager, IMapper mapper) : base(userManager, mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetComments()
        {
            return Ok(_comments);
        }
    }
}
