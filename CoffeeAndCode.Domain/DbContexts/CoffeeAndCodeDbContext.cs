using CoffeeAndCode.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeAndCode.Domain.DbContexts
{
    public class CoffeeAndCodeDbContext : DbContext
    {
        public CoffeeAndCodeDbContext(DbContextOptions<CoffeeAndCodeDbContext> options) : base(options)
            {
        }

        public DbSet<User> Users { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            //modelBuilder.Entity<Student>().ToTable("Student");
        }
    }

}
