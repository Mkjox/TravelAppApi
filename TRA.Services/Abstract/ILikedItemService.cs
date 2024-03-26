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
        Task<IResult> AddLikedItemAsync(LikedItem likedItem);
        Task<IResult> DeleteLikedPostItemAsync(int postId);
        Task<IResult> DeleteLikedCommentItemAsync(int commentId);
        Task<IDataResult<LikedItemListDto>> GetAllLikedItemsAsync();
        Task<IDataResult<LikedItemDto>> GetLikedItemByPostIdAsync(int postId);
        Task<IDataResult<LikedItemDto>> GetLikedItemByCommentIdAsync(int commentId);
    }
}
