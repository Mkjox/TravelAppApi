using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Concrete
{
    public class User : IdentityUser<int>
    {
        public string Picture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        public string About { get; set; }
        public string WebsiteLink { get; set; }

        public virtual ICollection<Like> Likes { get; set; } = new List<Like>();
        public virtual ICollection<Follow> Followers { get; set; } = new List<Follow>();
        public virtual ICollection<Follow> Followees { get; set; } = new List<Follow>();
    }
}
