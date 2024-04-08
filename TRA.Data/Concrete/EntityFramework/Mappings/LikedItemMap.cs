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
    public class LikedItemMap : IEntityTypeConfiguration<LikedItem>
    {
        public void Configure(EntityTypeBuilder<LikedItem> builder)
        {
            builder.HasOne<Post>(l => l.Post).WithMany(p => p.LikedItems).HasForeignKey(l => l.PostId);
            builder.HasOne<Category>(l => l.Category).WithMany(c => c.LikedItems).HasForeignKey(l => l.CategoryId);

            builder.ToTable("LikedItems");
        }
    }
}
