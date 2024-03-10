using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Dtos;

namespace TRA.Services.Abstract
{
    public interface ILikedItemService
    {
        Task<LikedItemDto> AddLikedItemAsync(LikedItemDto likedItemDto);
        Task DeleteLikedItemAsync(int id);
        Task<IEnumerable<LikedItemDto>> GetAllLikedItemsAsync();
        Task<LikedItemDto> GetLikedItemByIdAsync(int id);
    }
}
