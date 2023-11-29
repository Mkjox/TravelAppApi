using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class Comment
    {
        public string Text { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
