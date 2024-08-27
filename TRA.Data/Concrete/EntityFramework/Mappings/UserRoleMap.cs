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
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });
            builder.ToTable("UserRoles");

            builder.HasData(

                // Admin User
                new UserRole
                {
                    UserId = 1,
                    RoleId = 1,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 2,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 3
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 4,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 5,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 6,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 7,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 8,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 9,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 10,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 11,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 12,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 13,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 14,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 15,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 16,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 17,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 18,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 19,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 20,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 21,
                },

                new UserRole
                {
                    UserId = 1,
                    RoleId = 22,
                },

                // Editor User
                new UserRole
                {
                    UserId = 2,
                    RoleId = 1
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 2,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 3,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 4,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 5,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 6,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 7,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 8,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 17
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 18,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 19
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 20,
                },

                new UserRole
                {
                    UserId = 2,
                    RoleId = 21,
                },

                // Test User

                new UserRole
                {
                    UserId = 3,
                    RoleId = 2
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 5,
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 6,
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 7
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 8
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 17
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 18
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 19
                },

                new UserRole
                {
                    UserId = 3,
                    RoleId = 20
                });
        }
    }
}
