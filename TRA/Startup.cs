using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TRA.AutoMapper.Profiles;
using TRA.Data.Concrete.EntityFramework.Contexts;
using TRA.Entities.Concrete;
using TRA.Services.AutoMapper.Profiles;

namespace TRA
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TRADbContext>();
            services.AddScoped<UserManager<User>>();
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
                cfg.AddProfile(new PostProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new CommentProfile());
            }).CreateMapper());

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<TRADbContext>()
                .AddDefaultTokenProviders();

            services.AddAutoMapper(typeof(CategoryProfile), typeof(PostProfile), typeof(UserProfile), typeof(CommentProfile));
        }
    }
}
