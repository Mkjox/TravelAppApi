using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class Follow
    {
        public int Id { get; set; }

        public int FollowerId { get; set; }
        public int FolloweeId { get; set; }
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public virtual User Follower { get; set; }
        [JsonIgnore]
        public virtual User Followee { get; set; }
    }
}
