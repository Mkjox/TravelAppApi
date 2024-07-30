using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Services.Abstract
{
    public interface IFollowService
    {
        Task FollowUserAsync(int followerId, int followeeId);
        Task UnfollowAsync(int followerId, int followeeId);
    }
}
