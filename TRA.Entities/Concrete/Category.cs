using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
