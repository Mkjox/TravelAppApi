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
    public class LikeMap : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l=> l.Id).ValueGeneratedOnAdd();

            builder.HasOne(l => l.User)
                .WithMany(u=>u.Likes)
                .HasForeignKey(l=>l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l=>l.Post)
                .WithMany(p=>p.Likes)
                .HasForeignKey(l=>l.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Comment)
                .WithMany(c => c.Likes)
                .HasForeignKey(l => l.CommentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
