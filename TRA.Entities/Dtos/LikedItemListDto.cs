using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Dtos
{
    public class LikedItemListDto : DtoGetBase
    {
        public IList<LikedItem> LikedItems { get; set; }
        public IList<Post> Posts { get; set; }
        public int? postId { get; set; }
    }
}
