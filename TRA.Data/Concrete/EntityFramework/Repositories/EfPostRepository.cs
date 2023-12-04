using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Abstract;
using TRA.Entities.Concrete;
using TRA.Shared.Data.Concrete.EntityFramework;

namespace TRA.Data.Concrete.EntityFramework.Repositories
{
    public class EfPostRepository : EfEntityRepositoryBase<Post>, IPostRepository
    {
        public EfPostRepository(DbContext context) : base(context)
        {
        }
    }
}
