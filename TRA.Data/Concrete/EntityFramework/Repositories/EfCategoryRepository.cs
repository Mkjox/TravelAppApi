using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Data.Abstract;
using TRA.Data.Concrete.EntityFramework.Contexts;
using TRA.Entities.Concrete;
using TRA.Shared.Data.Concrete.EntityFramework;

namespace TRA.Data.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await TRADbContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }

        private TRADbContext TRADbContext
        {
            get
            {
                return _context as TRADbContext;
            }
        }
    }
}
