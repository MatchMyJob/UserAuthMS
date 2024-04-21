using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "2048b194-4cda-4320-8b72-c169b4788fe9", Name = "admin", NormalizedName = "ADMIN" },
               new IdentityRole { Id = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", Name = "jobuser", NormalizedName = "JOBUSER" },
               new IdentityRole { Id = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", Name = "company", NormalizedName = "COMPANY" }
            );

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "75fae092-a64f-4025-9b82-4bdc1d68950a",
                    UserName = "ivy97",
                    NormalizedUserName = "IVY97",
                    Email = "ivanbrestt@gmail.com",
                    NormalizedEmail = "IVANBRESTT@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { UserId = "75fae092-a64f-4025-9b82-4bdc1d68950a", RoleId = "2048b194-4cda-4320-8b72-c169b4788fe9" }
            );
        }
    }
}
