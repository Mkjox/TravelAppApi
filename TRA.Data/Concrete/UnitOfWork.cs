using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Abstract;
using TRA.Data.Concrete.EntityFramework.Contexts;
using TRA.Data.Concrete.EntityFramework.Repositories;

namespace TRA.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TRADbContext _context;
        public EfPostRepository _postRepository;
        public EfCategoryRepository _categoryRepository;
        public EfCommentRepository _commentRepository;
        public EfLikedItemRepository _likedItemRepository;

        public UnitOfWork(TRADbContext context)
        {
            _context = context;
        }

        public IPostRepository Posts => _postRepository ??= new EfPostRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ??= new EfCategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ??= new EfCommentRepository(_context);

        public ILikedItemRepository LikedItems => _likedItemRepository ??= new EfLikedItemRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
