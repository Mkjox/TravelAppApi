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
            var _categoryAddDto = Mapper.Map<CategoryAddDto>(categoryAddDto);
            var result = await _categoryService.AddAsync(_categoryAddDto, LoggedInUser.UserName);

            return result.ResultStatus == ResultStatus.Success ? Json(result) : Json(null);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var _categoryUpdateDto = Mapper.Map<CategoryUpdateDto>(categoryUpdateDto);
            var result = await _categoryService.UpdateAsync(_categoryUpdateDto, LoggedInUser.UserName);

            return result.ResultStatus == ResultStatus.Success ? Json(result) : Json(null);
        }

        [HttpDelete("DeleteCategory/{categoryId}")]
        public async Task<JsonResult> DeleteAsync(int categoryId)
        {
            var result = await _categoryService.DeleteAsync(categoryId, LoggedInUser.UserName);
            var categoryResult = JsonSerializer.Serialize(result.Data);
            return Json(categoryResult);
        }

        [HttpDelete("HardDeleteCategory/{categoryId}")]
        public async Task<IActionResult> HardDeleteAsync(int categoryId)
        {
            var result = await _categoryService.HardDeleteAsync(categoryId);
            var categoryResult = JsonSerializer.Serialize(result);
            return Json(categoryResult);
        }

        [HttpPost("UndoDelete/{categoryId}")]
        public async Task<IActionResult> UndoDeleteAsync(int categoryId, string modifiedByName)
        {
            var result = await _categoryService.UndoDeleteAsync(categoryId, modifiedByName);
            return result.ResultStatus == ResultStatus.Success ? Json(result) : Json(null);
        }

        [HttpGet("GetCategoryById/{categoryId}")]
        public async Task<IActionResult> GetAsync(int categoryId)
        {
            var result = await _categoryService.GetAsync(categoryId);

            return result != null ? Ok(result) : NoContent();
        }

        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _categoryService.GetAllAsync();

            return result != null ? Ok(result.Data) : NoContent();
        }

        [HttpGet("GetAllByDeleted")]
        public async Task<IActionResult> GetAllByDeletedAsync()
        {
            var result = await _categoryService.GetAllByDeletedAsync();

            return result != null ? Ok(result.Data) : NoContent();
        }

        [HttpGet("GetAllByNonDeleted")]
        public async Task<IActionResult> GetAllByNonDeletedAsync()
        {
            var result = await _categoryService.GetAllByNonDeletedAsync();

            return result != null ? Ok(result.Data) : NoContent();
        }

        [HttpGet("GetAllByNonDeletedAndActive")]
        public async Task<IActionResult> GetAllByNonDeletedAndActiveAsync()
        {
            await Task.Delay(5000);

            var result = await _categoryService.GetAllByNonDeletedAndActiveAsync();

            return result != null ? Ok(result.Data) : NoContent();
        }

        [HttpPost("CountCategories")]
        public async Task<IActionResult> CountAsync()
        {
            var categories = await _categoryService.CountAsync();
            var categoryResult = JsonSerializer.Serialize(categories.Data);
            return Json(categoryResult);
        }

        [HttpPost("CountByNonDeletedCategories")]
        public async Task<IActionResult> CountByNonDeletedAsync()
        {
            var categories = await _categoryService.CountByNonDeletedAsync();
            var categoryResult = JsonSerializer.Serialize(categories.Data);
            return Json(categoryResult);
        }
    }
}
