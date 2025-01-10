using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public class PostManager : ManagerBase, IPostService
    {
        private readonly UserManager<User> _userManager;

        public PostManager(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager) : base(unitOfWork, mapper)
        {
            _userManager = userManager;
        }

        public async Task<IResult> AddAsync(PostAddDto postAddDto, string createdByName, int userId)
        {
            var post = Mapper.Map<Post>(postAddDto);
            post.CreatedByName = createdByName;
            post.ModifiedByName = createdByName;
            post.UserId = userId;
            await UnitOfWork.Posts.AddAsync(post);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Post.Add(post.Title));
        }

        public async Task<IResult> UpdateAsync(PostUpdateDto postUpdateDto, string modifiedByName)
        {
            var oldPost = await UnitOfWork.Posts.GetAsync(p => p.Id == postUpdateDto.Id);
            var post = Mapper.Map<PostUpdateDto, Post>(postUpdateDto, oldPost);
            post.ModifiedByName = modifiedByName;
            await UnitOfWork.Posts.UpdateAsync(post);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Post.Update(post.Title));
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var postsCount = await UnitOfWork.Posts.CountAsync();
            if (postsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, postsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Encountered an unexpected error.", -1);
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var postsCount = await UnitOfWork.Posts.CountAsync(p => !p.IsDeleted);
            if (postsCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, postsCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Encountered an unexpected error.", -1);
            }
        }

        public async Task<IDataResult<PostDto>> GetAsync(int postId)
        {
            var post = await UnitOfWork.Posts.GetAsync(p => p.Id == postId, p => p.User, p => p.Category, p => p.Comments);
            if (post != null)
            {
                return new DataResult<PostDto>(ResultStatus.Success, new PostDto
                {
                    Post = post,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PostDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: false), null);
        }

        public async Task<IDataResult<PostUpdateDto>> GetPostUpdateDtoAsync(int postId)
        {
            var result = await UnitOfWork.Posts.AnyAsync(p => p.Id == postId);

            if (result)
            {
                var post = await UnitOfWork.Posts.GetAsync(p => p.Id == postId);
                var postUpdateDto = Mapper.Map<PostUpdateDto>(post);
                return new DataResult<PostUpdateDto>(ResultStatus.Success, postUpdateDto);
            }
            else
            {
                return new DataResult<PostUpdateDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: false), null);
            }
        }

        public async Task<IDataResult<PostListDto>> GetAllAsync()
        {
            var posts = await UnitOfWork.Posts.GetAllAsync(null, p => p.User, p => p.Category);
            if (posts.Count > -1)
            {
                return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
                {
                    Posts = posts,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PostListDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<PostListDto>> GetAllByCategoryAsync(int categoryId)
        {
            var result = await UnitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var posts = await UnitOfWork.Posts.GetAllAsync(p => p.CategoryId == categoryId && !p.IsDeleted && p.IsActive, p => p.User, p => p.Category);
                if (posts.Count > -1)
                {
                    return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
                    {
                        Posts = posts,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<PostListDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: true), null);
            }
            return new DataResult<PostListDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: false), null);
        }

        public async Task<IDataResult<PostListDto>> GetAllByDeletedAsync()
        {
            var posts = await UnitOfWork.Posts.GetAllAsync(p => p.IsDeleted && !p.IsActive, p => p.User, p => p.Category);
            if (posts.Count > -1)
            {
                return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
                {
                    Posts = posts,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PostListDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<PostListDto>> GetAllByNonDeletedAsync()
        {
            var posts = await UnitOfWork.Posts.GetAllAsync(p => !p.IsDeleted, p => p.User, p => p.Category);
            if (posts.Count > -1)
            {
                return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
                {
                    Posts = posts,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PostListDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: true), null);
        }

        public async Task<IDataResult<PostListDto>> GetAllByViewCountAsync(bool isAscending, int? takeSize)
        {
            var posts = await UnitOfWork.Posts.GetAllAsync(p => p.IsActive && !p.IsDeleted, p => p.User, p => p.Category);
            var sortedPosts = isAscending ? posts.OrderBy(p => p.ViewCount) : posts.OrderByDescending(p => p.ViewCount);
            return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
            {
                Posts = takeSize == null ? sortedPosts.ToList() : sortedPosts.Take(takeSize.Value).ToList()
            });
        }

        public async Task<IDataResult<PostListDto>> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var posts = categoryId == null ? await UnitOfWork.Posts.GetAllAsync(p => p.IsActive && !p.IsDeleted, p => p.Category, p => p.User) : await UnitOfWork.Posts.GetAllAsync(p => p.CategoryId == categoryId && p.IsActive && !p.IsDeleted, p => p.Category, p => p.User);
            var sortedPosts = isAscending ? posts.OrderBy(p => p.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList() : posts.OrderByDescending(p => p.Date).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
            {
                Posts = sortedPosts,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = posts.Count,
                IsAscending = isAscending

            });
        }

        public async Task<IDataResult<PostListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var posts = await UnitOfWork.Posts.GetAllAsync(p => !p.IsDeleted && p.IsActive, p => p.User, p => p.Category);
            if (posts.Count > -1)
            {
                return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
                {
                    Posts = posts,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PostListDto>(ResultStatus.Error, Messages.Post.NotFound(isPlural: true), null);
        }

        public async Task<IResult> DeleteAsync(int postId, string modifiedByName)
        {
            var result = await UnitOfWork.Posts.AnyAsync(p => p.Id == postId);
            if (result)
            {
                var post = await UnitOfWork.Posts.GetAsync(p => p.Id == postId);
                post.IsDeleted = true;
                post.IsActive = false;
                post.ModifiedByName = modifiedByName;
                post.ModifiedDate = DateTime.UtcNow;
                await UnitOfWork.Posts.UpdateAsync(post);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Post.Delete(post.Title));
            }
            return new Result(ResultStatus.Error, Messages.Post.NotFound(isPlural: false));
        }

        public async Task<IResult> HardDeleteAsync(int postId)
        {
            var result = await UnitOfWork.Posts.AnyAsync(p => p.Id == postId);
            if (result)
            {
                var post = await UnitOfWork.Posts.GetAsync(p => p.Id == postId);
                await UnitOfWork.Posts.DeleteAsync(post);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Post.HardDelete(post.Title));
            }
            return new Result(ResultStatus.Error, Messages.Post.NotFound(isPlural: false));
        }

        public async Task<IResult> UndoDeleteAsync(int postId, string modifiedByName)
        {
            var result = await UnitOfWork.Posts.AnyAsync(p => p.Id == postId);
            if (result)
            {
                var post = await UnitOfWork.Posts.GetAsync(p => p.Id == postId);
                post.IsDeleted = false;
                post.IsActive = true;
                post.ModifiedByName = modifiedByName;
                post.ModifiedDate = DateTime.UtcNow;
                await UnitOfWork.Posts.UpdateAsync(post);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Post.UndoDelete(post.Title));
            }
            return new Result(ResultStatus.Error, Messages.Post.NotFound(isPlural: false));
        }

        public Task<IDataResult<PostListDto>> GetAllByLikedAsync(int postId, int userId, DateTime likedDate, string createdByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<PostListDto>> SearchAsync(string keyword, bool isAscending = false)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                var posts = await UnitOfWork.Posts.GetAllAsync(p => p.IsActive && !p.IsDeleted, p => p.Category, p => p.User);
                var sortedPosts = isAscending ? posts.OrderBy(p => p.CreatedDate).ToList() : posts.OrderByDescending(p => p.CreatedDate).ToList();
                return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
                {
                    Posts = sortedPosts,
                    IsAscending = isAscending
                });
            }

            var searchedPosts = await UnitOfWork.Posts.SearchAsync(new List<Expression<Func<Post, bool>>>
            {
                (p) => p.Title.Contains(keyword),
                (p) => p.Category.Name.Contains(keyword),
                (p) => p.Content.Contains(keyword)
            }, p => p.Category, p => p.User);

            var searchedAndSortedPosts = isAscending ? searchedPosts.OrderBy(p => p.CreatedDate).ToList() : searchedPosts.OrderByDescending(p => p.CreatedDate).ToList();

            return new DataResult<PostListDto>(ResultStatus.Success, new PostListDto
            {
                Posts = searchedAndSortedPosts,
                TotalCount = searchedPosts.Count,
                IsAscending = isAscending
            });
        }

        public async Task<IResult> IncreaseViewCountAsync(int postId)
        {
            var post = await UnitOfWork.Posts.GetAsync(p => p.Id == postId);
            if (post != null)
            {
                post.ViewCount += 1;
                await UnitOfWork.Posts.UpdateAsync(post);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Post.IncreaseViewCount(post.Title));
            }
            return new Result(ResultStatus.Error, Messages.Post.NotFound(isPlural: false));
        }
    }
}
