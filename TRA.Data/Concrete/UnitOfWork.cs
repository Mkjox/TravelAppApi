using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Abstract;

namespace TRA.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly TRADbContext _context;
        

        public IPostRepository Posts { get; }

        public ICategoryRepository Categories => throw new NotImplementedException();

        public ICommentRepository Comments => throw new NotImplementedException();

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
