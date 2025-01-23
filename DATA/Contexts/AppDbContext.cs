using CORE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DATA.Contexts
{
    public  class AppDbContext:IdentityDbContext<IdentityUser,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt) { }

        public DbSet<Member> Members { get; set; }  

        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityRole>().HasData(


                new IdentityRole { Id = "25c814b1-16ef-46a6-8dc0-74325130da69", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "cec042c2-0f73-401c-9900-869116cc939c", Name = "User", NormalizedName = "USER" }
                );


            IdentityUser admin = new()
            {
                Id = "1558f1c0-5418-49ab-9158-ea7135ffa5cc",
                UserName = "fizaret",
                NormalizedUserName = "FIZARET"
            };

            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = hasher.HashPassword(admin, "fizaret123");
            builder.Entity<IdentityUser>().HasData(admin);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = admin.Id, RoleId = "25c814b1-16ef-46a6-8dc0-74325130da69" });


            base.OnModelCreating(builder);
        }

    }
}
