using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
