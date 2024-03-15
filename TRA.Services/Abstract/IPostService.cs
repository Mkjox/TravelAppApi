using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Dtos;
using TRA.Shared.Utilities.Results.Abstract;

namespace TRA.Services.Abstract
{
    public interface IPostService
    {
        Task<IResult> AddAsync(PostAddDto postAddDto, string createdByName, int userId);
        Task<IResult> UpdateAsync(PostUpdateDto postUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int postId, string modifiedByName);
        Task<IResult> UndoDeleteAsync(int postId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int postId);
        Task<IDataResult<PostDto>> GetAsync(int postId);
        Task<IDataResult<PostListDto>> GetAllAsync();
        Task<IDataResult<PostListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<PostListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<PostListDto>> GetAllByCategoryAsync(int categoryId);
        Task<IDataResult<PostListDto>> GetAllByDeletedAsync();
        Task<IDataResult<PostListDto>> GetAllByViewCountAsync(bool isAscending, int? takeSize);
        Task<IDataResult<PostListDto>> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 5, bool isAscending = false);
        Task<IDataResult<PostListDto>> GetAllByLikedAsync(int postId, int userId, DateTime likedDate, string createdByName);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
