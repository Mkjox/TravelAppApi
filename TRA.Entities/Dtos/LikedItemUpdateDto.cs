using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Dtos
{
    public class LikedItemUpdateDto : DtoGetBase
    {
        public bool IsLiked { get; set; } = false;
        public int LikedCount { get; set; } = 0;
    }
}
