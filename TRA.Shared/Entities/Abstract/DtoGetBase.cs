using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Shared.Utilities.Results.ComplexTypes;

namespace TRA.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
    }
}
