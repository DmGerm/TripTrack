using Microsoft.EntityFrameworkCore;
using TripTrack.Models;

namespace TripTrack.Data
{
    public class UserContext(DbContextOptions<UserContext> options) : DbContext(options)
    {
        public DbSet<UserModel> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Users");
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasIndex(e => e.Email).IsUnique().HasDatabaseName("IX_Users_Email");

                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.RoleID).IsRequired();
            });

        }
    }
}
