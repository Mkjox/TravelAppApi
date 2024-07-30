using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Services.Abstract
{
    public interface ILikeService
    {
        Task LikePostAsync(int userId, int postId, int commentId);
        Task UnlikePostAsync(int userId, int postId, int commentId);
    }
}
