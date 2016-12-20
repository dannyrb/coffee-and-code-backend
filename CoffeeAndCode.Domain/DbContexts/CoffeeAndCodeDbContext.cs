using Microsoft.EntityFrameworkCore;

namespace CoffeeAndCode.Domain.DbContexts
{
    public class CoffeeAndCodeDbContext : DbContext
    {
        public CoffeeAndCodeDbContext(DbContextOptions<CoffeeAndCodeDbContext> options) : base(options)
            {
        }

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Course>().ToTable("Course");
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            //modelBuilder.Entity<Student>().ToTable("Student");
        }
    }

}
