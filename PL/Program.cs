using BL.Profiles;
using BL.Services.Abstractions;
using BL.Services.Implementations;
using DATA.Contexts;
using DATA.Repositories.Abstractions;
using DATA.Repositories.Concretes;
using Microsoft.EntityFrameworkCore;

namespace PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));
            builder.Services.AddScoped<IMemberService,MemberService>();
            builder.Services.AddScoped<IOurSeviceService,OurServiceService>();
            builder.Services.AddScoped<IMemberRepository, MemberRepository>();
            builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
            builder.Services.AddAutoMapper(typeof(MemberProfiles));
            builder.Services.AddAutoMapper(typeof(ServiceProfiles));
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
name: "areas",
pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

            app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
