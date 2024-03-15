using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Abstract;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
using TRA.Shared.Utilities.Results.Abstract;
using TRA.Shared.Utilities.Results.ComplexTypes;
using TRA.Shared.Utilities.Results.Concrete;

namespace TRA.Services.Concrete
{
    public class LikedItemManager : ManagerBase, ILikedItemService
    {
        public LikedItemManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> AddLikedItemAsync(LikedItemUpdateDto likedItemUpdateDto)
        {
            var likedItem = Mapper.Map<LikedItem>(likedItemUpdateDto);
            await UnitOfWork.LikedItems.UpdateAsync(likedItem);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success);
        }

        public async Task<IResult> DeleteLikedItemAsync(int postId, int commentId)
        {
            var result = await UnitOfWork.LikedItems.AnyAsync(p => p.Id == postId);
            if (result)
            {
                var likedItem = await UnitOfWork.LikedItems.GetAsync(p => p.Id == postId);
                likedItem.IsDeleted = true;
                likedItem.IsActive = false;
                await UnitOfWork.LikedItems.UpdateAsync(likedItem);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error);
        }

        public Task<IEnumerable<LikedItemListDto>> GetAllLikedItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<LikedItemListDto>> GetLikedItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
