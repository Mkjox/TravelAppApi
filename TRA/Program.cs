using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TRA.AutoMapper.Profiles;
using TRA.Data.Concrete.EntityFramework.Contexts;
using TRA.Entities.Concrete;
using TRA.Services.Abstract;
using TRA.Services.AutoMapper.Profiles;
using TRA.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TRADbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));

//builder.Services.AddScoped<UserManager<User>>();
//builder.Services.AddScoped<IPostService, PostManager>();
//builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new UserProfile());
    cfg.AddProfile(new PostProfile());
    cfg.AddProfile(new CategoryProfile());
    cfg.AddProfile(new CommentProfile());
}).CreateMapper());

builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<TRADbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAutoMapper(typeof(CategoryProfile), typeof(PostProfile), typeof(UserProfile), typeof(CommentProfile));
builder.Services.AddAuthorization();

//builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "TRA API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Bu satýrý ekleyin
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.Run();