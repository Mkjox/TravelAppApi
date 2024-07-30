using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Concrete.EntityFramework.Contexts;
using TRA.Entities.Concrete;
using TRA.Services.Abstract;

namespace TRA.Services.Concrete
{
    public class FollowManager : IFollowService
    {
        private readonly TRADbContext _context;

        public FollowManager(TRADbContext context)
        {
            _context = context;
        }

        public async Task FollowUserAsync(int followerId, int followeeId)
        {
            var follow = new Follow { FollowerId = followerId, FolloweeId = followeeId, CreatedAt = DateTime.UtcNow };
            _context.Follows.Add(follow);
            await _context.SaveChangesAsync();
        }

        public async Task UnfollowAsync(int followerId, int followeeId)
        {
            var follow = await _context.Follows.FirstOrDefaultAsync(f => f.FollowerId == followerId && f.FolloweeId == followeeId);
            if (follow != null)
            {
                _context.Follows.Remove(follow);
                await _context.SaveChangesAsync();
            }
        }
    }
}
