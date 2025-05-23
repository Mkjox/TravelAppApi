using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }

        public int PostId { get; set; }
        [JsonIgnore]
        public virtual Post Post { get; set; }

        public virtual ICollection<Like> Likes { get; set; } = new List<Like>();
    }
}
