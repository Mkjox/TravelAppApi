using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class Explore
    {
        public virtual int Id { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
