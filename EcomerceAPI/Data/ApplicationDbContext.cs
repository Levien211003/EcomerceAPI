using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EcommerceAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(u => u.UserID); // Đảm bảo rằng khóa chính được xác định
        }


    }
}