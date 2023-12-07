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
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Title).HasMaxLength(100);
            builder.Property(p => p.Title).IsRequired();

            builder.Property(p => p.Content).IsRequired();
            builder.Property(p => p.Content).HasColumnType("varchar(65535)");

            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.ViewCount).IsRequired();
            builder.Property(p => p.CommentCount).IsRequired();

            builder.Property(p => p.Thumbnail).IsRequired();
            builder.Property(p => p.Thumbnail).HasMaxLength(250);

            builder.Property(p => p.CreatedByName).IsRequired();
            builder.Property(p => p.CreatedByName).HasMaxLength(50);
            builder.Property(p => p.ModifiedByName).IsRequired();
            builder.Property(p => p.ModifiedByName).HasMaxLength(50);

            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.ModifiedDate).IsRequired();

            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired();

            builder.HasOne<Category>(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);
            builder.HasOne<User>(p => p.User).WithMany(u => u.Posts).HasForeignKey(p => p.UserId);

            builder.ToTable("Posts");
        }
    }
}
