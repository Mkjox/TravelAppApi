﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Dtos
{
    public class PostListDto : DtoGetBase
    {
        public IList<Post> Posts { get; set; }
        public int? CategoryId { get; set; }
    }
}
