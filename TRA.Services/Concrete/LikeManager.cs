using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Concrete.EntityFramework.Contexts;
using TRA.Entities.Concrete;
using TRA.Services.Abstract;
using TRA.Shared.Utilities.Results.Abstract;

namespace TRA.Services.Concrete
{
    public class LikeManager : ILikeService
    {
        private readonly TRADbContext _context;

        public LikeManager(TRADbContext context)
        {
            _context = context;
        }

        public async Task LikePostAsync(int userId, int postId)
        {
            var like = new Like { UserId = userId, PostId = postId, CreatedAt = DateTime.UtcNow };
            _context.Likes.Add(like);
            await _context.SaveChangesAsync();
        }

        public async Task LikeCommentAsync(int userId, int commentId)
        {
            var like = new Like { UserId = userId, CommentId = commentId, CreatedAt = DateTime.UtcNow };
            _context.Likes.Add(like);
            await _context.SaveChangesAsync();
        }

        public async Task UnlikePostAsync(int userId, int postId)
        {
            var like = await _context.Likes.FirstOrDefaultAsync(l => l.UserId == userId && l.PostId == postId);
            if (like != null)
            {
                _context.Likes.Remove(like);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UnlikeCommentAsync(int userId, int commentId)
        {
            var like = await _context.Likes.FirstOrDefaultAsync(l => l.UserId == userId && l.CommentId == commentId);
            if (like != null)
            {
                _context.Likes.Remove(like);
                await _context.SaveChangesAsync();
            }
        }
    }
}
