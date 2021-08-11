using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudyHelper.Models;

namespace StudyHelper.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }

        public DbSet<CorrectAnswer> CorrectAnswers { get; set; }

        public DbSet<UserAnswer> UserAnswers { get ;set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Question>(entity => {
                entity.HasKey(q => q.Id);
                entity.Property(q => q.Id);
                entity.Property(q => q.Text);
                entity.Property(q => q.Category).HasConversion<string>();
                entity.HasOne(q => q.CorrectAnswer);
                entity.HasMany(q => q.UserAnswers);
                entity.ToTable("Question");

            });

            builder.Entity<CorrectAnswer>(entity => {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id);
                entity.Property(c => c.QuestionId);
                entity.Property(c => c.AnswerOption).HasConversion<string>();
                entity.ToTable("CorrectAnswer");

            });

            builder.Entity<UserAnswer>(entity => {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id);
                entity.Property(c => c.QuestionId);
                entity.Property(c => c.UserId);
                entity.Property(c => c.AnswerOption).HasConversion<string>();
                entity.ToTable("UserAnswer");

            });
        }
    }
}
