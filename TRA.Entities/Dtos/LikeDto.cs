using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Dtos
{
    public class LikeDto
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int CommentId { get; set; }
    }
}
