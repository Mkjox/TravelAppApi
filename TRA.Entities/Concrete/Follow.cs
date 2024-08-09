using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class Follow
    {
        public int Id { get; set; }

        [ForeignKey("Follower")]
        public int FollowerId { get; set; }

        [ForeignKey("Followee")]
        public int FolloweeId { get; set; }

        public DateTime CreatedAt { get; set; }


        public User Follower { get; set; }
        public User Followee { get; set; }
    }
}
