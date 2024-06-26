﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Abstract;
using TRA.Entities.Concrete;
using TRA.Entities.Dtos;
using TRA.Services.Abstract;
using TRA.Services.Utilities;
using TRA.Shared.Utilities.Results.Abstract;
using TRA.Shared.Utilities.Results.ComplexTypes;
using TRA.Shared.Utilities.Results.Concrete;

namespace TRA.Services.Concrete
{
    public class CommentManager : ManagerBase, ICommentService
    {
        public CommentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<CommentDto>> AddAsync(CommentAddDto commentAddDto)
        {
            var comment = Mapper.Map<Comment>(commentAddDto);
            var addedComment = await UnitOfWork.Comments.AddAsync(comment);
            await UnitOfWork.SaveAsync();
            return new DataResult<CommentDto>(ResultStatus.Success, Messages.Comment.Add(commentAddDto.CreatedByName), new CommentDto
            {
                Comment = addedComment
            });
        }

        public async Task<IDataResult<CommentDto>> ApproveAsync(int commentId, string modifiedByName)
        {
            var comment = await UnitOfWork.Comments.GetAsync(c => c.Id == commentId, c => c.Post);
            if (comment != null)
            {
                comment.IsActive = true;
                comment.ModifiedByName = modifiedByName;
                comment.ModifiedDate = DateTime.UtcNow;
                var updatedComment = await UnitOfWork.Comments.UpdateAsync(comment);
                await UnitOfWork.SaveAsync();
                return new DataResult<CommentDto>(ResultStatus.Success, Messages.Comment.Approve(commentId), new CommentDto
                {
                    Comment = updatedComment
                });
            }
            return new DataResult<CommentDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false), null);
        }

        public async Task<IDataResult<CommentDto>> UpdateAsync(CommentUpdateDto commentUpdateDto, string modifiedByName)
        {
            var oldComment = await UnitOfWork.Comments.GetAsync(c => c.Id == commentUpdateDto.Id);
            var comment = Mapper.Map<CommentUpdateDto, Comment>(commentUpdateDto, oldComment);
            comment.ModifiedByName = modifiedByName;
            var updatedComment = await UnitOfWork.Comments.UpdateAsync(comment);
            updatedComment.Post = await UnitOfWork.Posts.GetAsync(p => p.Id == updatedComment.PostId);
            await UnitOfWork.SaveAsync();
            return new DataResult<CommentDto>(ResultStatus.Success, Messages.Comment.Update(comment.CreatedByName), new CommentDto
            {
                Comment = updatedComment
            });
        }

        public async Task<IDataResult<CommentDto>> DeleteAsync(int commentId, string modifiedByName)
        {
            var comment = await UnitOfWork.Comments.GetAsync(c => c.Id == commentId);
            if (comment != null)
            {
                comment.IsDeleted = true;
                comment.IsActive = false;
                comment.ModifiedByName = modifiedByName;
                comment.ModifiedDate = DateTime.UtcNow;
                var deletedComment = await UnitOfWork.Comments.UpdateAsync(comment);
                return new DataResult<CommentDto>(ResultStatus.Success, Messages.Comment.Delete(deletedComment.CreatedByName), new CommentDto
                {
                    Comment = deletedComment
                });
            }
            return new DataResult<CommentDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false), new CommentDto
            {
                Comment = null
            });
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var commentsCount = await UnitOfWork.Comments.CountAsync();
            if (commentsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, commentsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Encountered an unexpected error.", -1);
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var commentsCount = await UnitOfWork.Comments.CountAsync(c => !c.IsDeleted);
            if (commentsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, commentsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Encountered an unexpected error.", -1);
            }
        }

        public async Task<IDataResult<CommentDto>> GetAsync(int commentId)
        {
            var comment = await UnitOfWork.Comments.GetAsync(c => c.Id == commentId);
            if (comment != null)
            {
                return new DataResult<CommentDto>(ResultStatus.Success, new CommentDto
                {
                    Comment = comment
                });
            }
            return new DataResult<CommentDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false), new CommentDto
            {
                Comment = null
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAllAsync()
        {
            var comments = await UnitOfWork.Comments.GetAllAsync(null, c => c.Post);
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: true), new CommentListDto
            {
                Comments = null
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAllByDeletedAsync()
        {
            var comments = await UnitOfWork.Comments.GetAllAsync(c => c.IsDeleted, c => c.Post);
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: true), new CommentListDto
            {
                Comments = null
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAllByNonDeletedAsync()
        {
            var comments = await UnitOfWork.Comments.GetAllAsync(c => !c.IsDeleted, c => c.Post);
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: true), new CommentListDto
            {
                Comments = null
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var comments = await UnitOfWork.Comments.GetAllAsync(c => !c.IsDeleted && c.IsActive, c => c.Post);
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: true), new CommentListDto
            {
                Comments = null
            });
        }

        public async Task<IDataResult<CommentUpdateDto>> GetCommentUpdateDtoAsync(int commentId)
        {
            var result = await UnitOfWork.Comments.AnyAsync(c => c.Id == commentId);
            if (result)
            {
                var comment = await UnitOfWork.Comments.GetAsync(c => c.Id == commentId);
                var commentUpdateDto = Mapper.Map<CommentUpdateDto>(comment);
                return new DataResult<CommentUpdateDto>(ResultStatus.Success, commentUpdateDto);
            }
            else
            {
                return new DataResult<CommentUpdateDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false), null);
            }
        }

        public async Task<IResult> HardDeleteAsync(int commentId)
        {
            var comment = await UnitOfWork.Comments.GetAsync(c => c.Id == commentId);
            if (comment != null)
            {
                await UnitOfWork.Comments.DeleteAsync(comment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Comment.HardDelete(comment.CreatedByName));
            }
            return new Result(ResultStatus.Error, Messages.Comment.HardDelete(comment.CreatedByName));
        }

        public async Task<IDataResult<CommentDto>> UndoDeleteAsync(int commentId, string modifiedByName)
        {
            var comment = await UnitOfWork.Comments.GetAsync(c => c.Id == commentId);
            if (comment != null)
            {
                comment.IsDeleted = false;
                comment.IsActive = true;
                comment.ModifiedByName = modifiedByName;
                comment.ModifiedDate = DateTime.UtcNow;
                var deletedComment = await UnitOfWork.Comments.UpdateAsync(comment);
                await UnitOfWork.SaveAsync();
                return new DataResult<CommentDto>(ResultStatus.Success, Messages.Comment.UndoDelete(deletedComment.CreatedByName), new CommentDto
                {
                    Comment = deletedComment
                });
            }
            return new DataResult<CommentDto>(ResultStatus.Error, Messages.Comment.NotFound(isPlural: false), new CommentDto
            {
                Comment = null
            });
        }

    }
}
