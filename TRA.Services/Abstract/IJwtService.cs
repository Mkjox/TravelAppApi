using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;

namespace TRA.Services.Abstract
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
