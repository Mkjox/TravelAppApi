using AutoMapper;
using TRA.AutoMapper.Profiles;
using TRA.Data.Concrete.EntityFramework.Contexts;
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
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PostProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new CommentProfile());
            }).CreateMapper());

            services.AddAutoMapper(typeof(CategoryProfile), typeof(PostProfile), typeof(UserProfile), typeof(CommentProfile));
        }
    }
}
