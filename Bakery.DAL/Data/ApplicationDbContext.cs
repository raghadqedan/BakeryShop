using Bakery.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Payment> Paymet { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seeding data 

            var superAdminRoleId = Guid.NewGuid().ToString();
            var AdminRoleId = Guid.NewGuid().ToString();
            var userRoleId = Guid.NewGuid().ToString();

            //Roles => SuberAdmin, Admin or User
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = superAdminRoleId,Name="SuperAdmin",NormalizedName="SUPERADMIN" },
                new IdentityRole { Id = AdminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" }
                );
            var superAdminId = Guid.NewGuid().ToString();
            var superAdmin = new ApplicationUser
            {
                Id = superAdminId,
                UserName = "superAdmin@comp.com",
                NormalizedUserName = "SUPERADMIN@COMP.COM",
                Email = "superAdmin@comp.com",
                NormalizedEmail = "SUPERADMIN@COMP.COM",
                FirstName="superAdmin",
                LastName="superAdmin"
            };
            var hasher = new PasswordHasher<ApplicationUser>();
            superAdmin.PasswordHash = hasher.HashPassword(superAdmin, "SuperAdmin@1212");
                builder.Entity<ApplicationUser>().HasData(superAdmin);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = superAdminRoleId, UserId=superAdminId }
                );
        }
       


    }
}