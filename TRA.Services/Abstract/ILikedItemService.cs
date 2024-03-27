using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Shared.Utilities.Results.Abstract;

namespace TRA.Services.Abstract
{
    public interface ILikedItemService
    {
        Task<IResult> AddAsync(LikedItem likedItem);
        Task<IResult> DeleteLikedPostItemAsync(int postId);
        Task<IResult> DeleteLikedCommentItemAsync(int commentId);
        Task<IDataResult<LikedItemListDto>> GetAllAsync();
        Task<IDataResult<LikedItemDto>> GetByPostIdAsync(int postId);
        Task<IDataResult<LikedItemDto>> GetByCommentIdAsync(int commentId);
    }
}
