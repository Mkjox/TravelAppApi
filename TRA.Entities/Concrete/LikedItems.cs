using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Concrete
{
    public class LikedItems : IEntity
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public Comment Comment { get; set; }
        public bool IsLiked { get; set; } = false;
    }
}
