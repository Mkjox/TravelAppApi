using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
using TRA.Shared.Utilities.Results.ComplexTypes;

namespace TRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(UserManager<User> userManager, IMapper mapper, ICategoryService categoryService) : base(userManager, mapper)
        {
            _categoryService = categoryService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var _categoryAddDto = Mapper.Map<CategoryAddDto>(categoryAddDto);
                var result = await _categoryService.AddAsync(_categoryAddDto, LoggedInUser.UserName);

                if (result.ResultStatus == ResultStatus.Success)
                {
                    return Json(result);
                }

                else
                    return Json(null);
            }

            else
                return Json(null);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var _categoryUpdateDto = Mapper.Map<CategoryUpdateDto>(categoryUpdateDto);
            var result = await _categoryService.UpdateAsync(_categoryUpdateDto, LoggedInUser.UserName);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(result);
            }
            else
                return Json(null);
        }

        [HttpPost("Delete")]
        public async Task<JsonResult> Delete(int categoryId)
        {
            var result = await _categoryService.DeleteAsync(categoryId, LoggedInUser.UserName);
            var categoryResult = JsonSerializer.Serialize(result.Data);
            return Json(categoryResult);
        }

        [HttpPost("HardDelete")]
        public async Task<JsonResult> HardDelete(int categoryId)
        {
            var result = await _categoryService.HardDeleteAsync(categoryId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(result);
            }
            else
                return Json(null);
        }

        [HttpPost]
        public async Task<JsonResult> GetCategories()
        {
            var result = await _categoryService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(result);
            }
            else
                return Json(null);
        }

        [HttpPost]
        public async Task<JsonResult> GetDeletedCategories()
        {
            var result = await _categoryService.GetAllByDeletedAsync();
            var categoryResult = JsonSerializer.Serialize(result.Data);
            return Json(categoryResult);
        }
    }
}
