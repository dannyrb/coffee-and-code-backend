using CoffeeAndCode.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoffeeAndCode.Domain.DbContexts
{
    public class CoffeeAndCodeDbContext : DbContext
    {
        public CoffeeAndCodeDbContext(DbContextOptions<CoffeeAndCodeDbContext> options) : base(options)
            {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOption> Options { get; set; }
        public DbSet<OptionValueType> ValueTypes { get; set; }
        public DbSet<UserResponseToQuestion> UserResponsesToQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Question>().ToTable("Questions");
            modelBuilder.Entity<QuestionOption>().ToTable("Options");
            modelBuilder.Entity<OptionValueType>().ToTable("ValueTypes");
            modelBuilder.Entity<UserResponseToQuestion>()
                .ToTable("UserResponsesToQuestions")
                .HasOne(i => i.Question)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

        }
    }

}
