using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikedController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ILikedItemService _likedItemService;
        private readonly List<LikedItem> _likedItem = new List<LikedItem>();

        public LikedController(UserManager<User> userManager, IMapper mapper, ILikedItemService likedItemService) : base(userManager, mapper)
        {
            _mapper = mapper;
            _userManager = userManager;
            _likedItemService = likedItemService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = _likedItemService.GetAllLikedItemsAsync();
            if (result.IsCompletedSuccessfully)
                return Ok(result);
            else 
                return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddLikes(LikedItem likedItem)
        {
            var result = _likedItemService.AddLikedItemAsync(likedItem);
            if (result.IsCompletedSuccessfully)
                return Ok(result);
            else 
                return BadRequest(result);
        }
    }
}
