using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRA.Entities.Concrete;

namespace TRA.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(UserManager<User> userManager, IMapper mapper)
        {
            UserManager = userManager;
            Mapper = mapper;
        }

        protected UserManager<User> UserManager { get; }
        protected IMapper Mapper { get; }
        protected User LoggedInUser => UserManager.GetUserAsync(User).Result;
    }
}
