using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    [Route("api/category")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(UserManager<User> userManager, IMapper mapper, ICategoryService categoryService) : base(userManager, mapper)
        {
            _categoryService = categoryService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(CategoryAddDto categoryAddDto)
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

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
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

        [HttpDelete("DeleteCategory")]
        public async Task<JsonResult> DeleteAsync(int categoryId)
        {
            var result = await _categoryService.DeleteAsync(categoryId, LoggedInUser.UserName);
            var categoryResult = JsonSerializer.Serialize(result.Data);
            return Json(categoryResult);
        }

        [HttpDelete("HardDeleteCategory")]
        public async Task<IActionResult> HardDeleteAsync(int categoryId)
        {
            var result = await _categoryService.HardDeleteAsync(categoryId);
            var categoryResult = JsonSerializer.Serialize(result);
            return Json(categoryResult);
        }

        [HttpPost("UndoDelete")]
        public async Task<IActionResult> UndoDeleteAsync(int categoryId, string modifiedByName)
        {
            var result = await _categoryService.UndoDeleteAsync(categoryId, modifiedByName);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(result);
            else return Json(null);

        }

        [HttpGet("GetCategoryById/{categoryId}")]
        public async Task<IActionResult> GetAsync(int categoryId)
        {
            var result = await _categoryService.GetAsync(categoryId);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(result);
            else
                return Json(null);
        }

        [HttpGet("GetAllCategories")]
        public async Task<JsonResult> GetAllAsync()
        {
            var result = await _categoryService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(result);
            }
            else
                return Json(null);
        }

        [HttpGet("GetAllByDeleted")]
        public async Task<JsonResult> GetAllByDeletedAsync()
        {
            var result = await _categoryService.GetAllByDeletedAsync();
            var categoryResult = JsonSerializer.Serialize(result.Data);
            return Json(categoryResult);
        }

        [HttpGet("GetAllByNonDeleted")]
        public async Task<IActionResult> GetAllByNonDeletedAsync()
        {
            var result = await _categoryService.GetAllByNonDeletedAsync();
            var categoryResult = JsonSerializer.Serialize(result.Data);
            return Json(categoryResult);
        }

        [HttpGet("GetAllByNonDeletedAndActive")]
        public async Task<IActionResult> GetAllByNonDeletedAndActiveAsync()
        {
            var result = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            var categoryResult = JsonSerializer.Serialize(result.Data);
            return Json(categoryResult);
        }

        [HttpPost("CountCategories")]
        public async Task<IActionResult> CountAsync()
        {
            var categories = await _categoryService.CountAsync();
            var categoryResult = JsonSerializer.Serialize(categories.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(categoryResult);
        }

        [HttpPost("CountByNonDeletedCategories")]
        public async Task<IActionResult> CountByNonDeletedAsync()
        {
            var categories = await _categoryService.CountByNonDeletedAsync();
            var categoryResult = JsonSerializer.Serialize(categories.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(categoryResult);
        }
    }
}
