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

        [HttpPost("Add")]
        public async Task<IActionResult> Add(LikedItemAddDto likedItemAddDto)
        {
            var _likedItemAddDto = _mapper.Map<LikedItemAddDto>(likedItemAddDto);

            var result = await _likedItemService.AddAsync(_likedItemAddDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(new
                {
                    result.Message,
                    Title = "Liked Successfully!"
                });
            }
            else
            {
                return Json(new
                {
                    Result = false,
                    Message = "There has been an error while liking the content."
                });
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(LikedItemUpdateDto likedItemUpdateDto)
        {
            var _likedItemUpdateDto = _mapper.Map<LikedItemUpdateDto>(likedItemUpdateDto);
            var result = await _likedItemService.UpdateAsync(_likedItemUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(new
                {
                    result.Message,
                    Title = "Unliked Successfully!"
                });
            }
            else
            {
                return Json(new
                {
                    Result = false,
                    Message = "There has been an error while unliking the content."
                });
            }
        }

        [HttpGet("GetAll")]
        public async Task<JsonResult> GetAll()
        {
            var result = await _likedItemService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(result);
            }

            else
                return Json(null);
        }
    }
}
