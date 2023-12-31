using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRA.Services.Abstract;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
    }
}
