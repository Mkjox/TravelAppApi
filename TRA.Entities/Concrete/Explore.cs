using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class Explore
    {
        public int Id { get; set; }

        [JsonIgnore]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
