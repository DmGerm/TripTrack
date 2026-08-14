using Microsoft.EntityFrameworkCore;
using TripTrack.Models;

namespace TripTrack.Data
{
    public class UserContext(DbContextOptions<UserContext> options) : DbContext(options)
    {
        public DbSet<UserModel> Users { get; set; } = null!;
        public DbSet<RoleModel> Roles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Users");

                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.Role).IsRequired();

                entity.HasOne(e => e.Role).WithMany(e => e.Users).HasForeignKey(e => e.RoleID);
            });

            modelBuilder.Entity<RoleModel>(entity =>
            {
                entity.HasKey(e => e.RoleID).HasName("PK_Roles");

                entity.Property(e => e.RoleID).ValueGeneratedNever();

                entity.HasData(
                    new RoleModel { RoleID = RolesEn.Root },
                    new RoleModel { RoleID = RolesEn.Admin },
                    new RoleModel { RoleID = RolesEn.User });
            });

        }
    }
}
