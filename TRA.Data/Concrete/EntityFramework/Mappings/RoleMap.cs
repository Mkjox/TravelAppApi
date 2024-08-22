using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;

namespace TRA.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasIndex(r => r.NormalizedName).HasDatabaseName("RoleNameIndex").IsUnique();

            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();
            builder.Property(u => u.Name).HasMaxLength(100);
            builder.Property(u => u.NormalizedName).HasMaxLength(100);

            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
            builder.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.ToTable("Roles");

            builder.HasData(
                 new Role
                {
                    Id = 1,
                    Name = "Category.Create",
                    NormalizedName = "CATEGORY.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 2,
                    Name = "Category.Read",
                    NormalizedName = "CATEGORY.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 3,
                    Name = "Category.Update",
                    NormalizedName = "CATEGORY.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 4,
                    Name = "Category.Delete",
                    NormalizedName = "CATEGORY.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 5,
                    Name = "Post.Create",
                    NormalizedName = "POST.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 6,
                    Name = "Post.Read",
                    NormalizedName = "POST.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 7,
                    Name = "Post.Update",
                    NormalizedName = "POST.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 8,
                    Name = "Post.Delete",
                    NormalizedName = "POST.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 9,
                    Name = "User.Create",
                    NormalizedName = "USER.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 10,
                    Name = "User.Read",
                    NormalizedName = "USER.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 11,
                    Name = "User.Update",
                    NormalizedName = "USER.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 12,
                    Name = "User.Delete",
                    NormalizedName = "USER.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 13,
                    Name = "Role.Create",
                    NormalizedName = "ROLE.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 14,
                    Name = "Role.Read",
                    NormalizedName = "ROLE.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 15,
                    Name = "Role.Update",
                    NormalizedName = "ROLE.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 16,
                    Name = "Role.Delete",
                    NormalizedName = "ROLE.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 17,
                    Name = "Comment.Create",
                    NormalizedName = "COMMENT.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 18,
                    Name = "Comment.Read",
                    NormalizedName = "COMMENT.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 19,
                    Name = "Comment.Update",
                    NormalizedName = "COMMENT.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 20,
                    Name = "Comment.Delete",
                    NormalizedName = "COMMENT.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 21,
                    Name = "AdminArea.Home.Read",
                    NormalizedName = "ADMINAREA.HOME.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new Role
                {
                    Id = 22,
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                });
        }
    }
}