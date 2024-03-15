using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Dtos;
using TRA.Shared.Utilities.Results.Abstract;

namespace TRA.Services.Abstract
{
    public interface ILikedItemService
    {
        Task<IResult> AddLikedItemAsync(LikedItemUpdateDto likedItemUpdateDto);
        Task<IResult> DeleteLikedItemAsync(int postId, int commentId);
        Task<IEnumerable<LikedItemListDto>> GetAllLikedItemsAsync();
        Task<IDataResult<LikedItemListDto>> GetLikedItemByIdAsync(int id);
    }
}
