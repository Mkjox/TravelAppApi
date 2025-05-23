using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Concrete
{
    public class Like : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? PostId { get; set; }
        public int? CommentId { get; set; }
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public User User { get; set; }
        [JsonIgnore]
        public Post Post { get; set; }
        [JsonIgnore]
        public Comment Comment { get; set; }
    }
}
