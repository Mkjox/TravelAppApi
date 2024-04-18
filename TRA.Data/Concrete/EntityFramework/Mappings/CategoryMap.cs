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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(70);

            builder.Property(c => c.Description).HasMaxLength(500);

            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);

            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);

            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();

            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();

            builder.ToTable("Categories");

            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Hiking",
                    Description = "Hiking routes and experiences",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.UtcNow,
                },
                new Category
                {
                    Id = 2,
                    Name = "Bicycle",
                    Description = "Cycling routes and experiences",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.UtcNow,
                },
                new Category
                {
                    Id = 3,
                    Name = "Drive",
                    Description = "Driving routes and experiences",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.UtcNow,
                },
                new Category
                {
                    Id = 4,
                    Name = "Kayak",
                    Description = "Kayaking routes and experiences",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.UtcNow,
                },
                new Category
                {
                    Id = 5,
                    Name = "Ski",
                    Description = "Skiing routes and experiences",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.UtcNow,
                },
                new Category
                {
                    Id = 6,
                    Name = "Water Ski",
                    Description = "Water Skiing routes and experiences",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.UtcNow,
                },
                new Category
                {
                    Id = 7,
                    Name = "Swim",
                    Description = "Swimming routes and experiences",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.UtcNow,
                }
                );
        }
    }
}
