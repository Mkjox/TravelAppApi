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

        public async Task<IResult> DeleteLikedPostItemAsync(int postId)
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

        public async Task<IResult> DeleteLikedCommentItemAsync(int commentId)
        {
            var result = await UnitOfWork.LikedItems.AnyAsync(c => c.Id == commentId);
            if (result)
            {
                var likedItem = await UnitOfWork.LikedItems.GetAsync(c => c.Id == commentId);
                likedItem.IsDeleted = true;
                likedItem.IsActive = false;
                await UnitOfWork.LikedItems.UpdateAsync(likedItem);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error);
        }

        public async Task<IDataResult<LikedItemListDto>> GetAllLikedItemsAsync()
        {
            var likedItems = await UnitOfWork.LikedItems.GetAllAsync(l => l.IsActive && !l.IsDeleted, l => l.User, l => l.Category);
            return new DataResult<LikedItemListDto>(ResultStatus.Success, new LikedItemListDto
            {
                LikedItems = likedItems.ToList()
            });
        }

        public async Task<IDataResult<LikedItemDto>> GetLikedItemByPostIdAsync(int postId)
        {
            var likedItem = await UnitOfWork.LikedItems.GetAsync(l => l.Id == postId);
            if (likedItem != null)
            {
                return new DataResult<LikedItemDto>(ResultStatus.Success, new LikedItemDto
                {
                    LikedItem = likedItem
                });
            }
            return new DataResult<LikedItemDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<LikedItemDto>> GetLikedItemByCommentIdAsync(int commentId)
        {
            var likedItem = await UnitOfWork.LikedItems.GetAsync(l => l.Id == commentId);
            if (likedItem != null)
            {
                return new DataResult<LikedItemDto>(ResultStatus.Success, new LikedItemDto
                {
                    LikedItem = likedItem
                });
            }
            return new DataResult<LikedItemDto>(ResultStatus.Error, null);
        }
    }
}
