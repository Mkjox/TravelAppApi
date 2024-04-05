using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Concrete
{
    public class LikedItem : EntityBase, IEntity
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public bool IsLiked { get; set; } = false;
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
