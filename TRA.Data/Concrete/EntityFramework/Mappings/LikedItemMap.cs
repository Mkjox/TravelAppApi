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
    public class LikedItemMap : IEntityTypeConfiguration<LikedItems>
    {
        public void Configure(EntityTypeBuilder<LikedItems> builder)
        {
            builder.HasOne<Post>(c => c.Post).WithMany(p => p.LikedItems).HasForeignKey(c => c.PostId);

            builder.ToTable("Liked");
        }
    }
}
