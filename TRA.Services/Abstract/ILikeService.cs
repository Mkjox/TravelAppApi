using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Services.Abstract
{
    public interface ILikeService
    {
        Task LikePostAsync(int userId, int postId);
        Task UnlikePostAsync(int userId, int postId);

        Task LikeCommentAsync(int userId, int commentId);
        Task UnlikeCommentAsync(int userId, int commentId);
    }
}
