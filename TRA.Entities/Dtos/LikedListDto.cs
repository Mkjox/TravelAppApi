using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;

namespace TRA.Entities.Dtos
{
    public class LikedListDto
    {
        // Maybe Favorites instead of Likeds?
        public IList<Liked> Likeds { get; set; }
    }
}
