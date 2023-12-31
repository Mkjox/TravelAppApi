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
    public class LikedMap : IEntityTypeConfiguration<Liked>
    {
        public void Configure(EntityTypeBuilder<Liked> builder)
        {
            builder.HasOne<Post>(c => c.Post).WithMany(p => p.Likeds).HasForeignKey(c => c.PostId);

            builder.ToTable("Liked");
        }
    }
}
