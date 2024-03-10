using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IPostRepository Posts { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        ILikedItemRepository LikedItems { get; }
        Task<int> SaveAsync();
    }
}
