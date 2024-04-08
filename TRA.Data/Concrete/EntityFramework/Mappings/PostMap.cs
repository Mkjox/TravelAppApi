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
            builder.Property(p => p.Content).HasMaxLength(600);

            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.ViewCount).IsRequired();
            builder.Property(p => p.CommentCount).IsRequired();

            builder.Property(p => p.Thumbnail).IsRequired();
            builder.Property(p => p.Thumbnail).HasMaxLength(250);

            builder.Property(p => p.CreatedByName).IsRequired();
            builder.Property(p => p.CreatedByName).HasMaxLength(50);
            builder.Property(p => p.CreatedDate).IsRequired();

            builder.Property(p => p.ModifiedByName).IsRequired();
            builder.Property(p => p.ModifiedByName).HasMaxLength(50);
            builder.Property(p => p.ModifiedDate).IsRequired();

            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired();

            builder.HasOne<Category>(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);
            builder.HasOne<User>(p => p.User).WithMany(u => u.Posts).HasForeignKey(p => p.UserId);

            builder.ToTable("Posts");

            builder.HasData(
                new Post
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Hiking trail in Spain",
                    Content = "Camino de Santiago is a collection of ancient pilgrimage routes that converge at the Santiago de Compostela Cathedral in northwest Spain, the burial site of St. James. Some pilgrims carry a scallop shell during the journey, as its lines symbolize their own trek, and those of other pilgrims around the world. This is another long-distance adventure — to do the approximately 500-mile route in full may take 30 days or more.",
                    Date = DateTime.Now,
                    ViewCount = 0,
                    CommentCount = 0,
                    Thumbnail = "~postImages/defaultThumbnail.jpg",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    UserId = 1,
                },
                new Post
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Bicycle route in Belgium",
                    Content = "This cycling tour takes you along the Ourthe River from its mouth into the Meuse in Liège to Vieuxville and back. Highlights include cycling paths along the river bank, quiet climbs with views across the Condroz and Ardennes, the view at Roche au Faucons (last few meters access on foot only), and the rock faces at the river near Sy. The route uses RAVeL cycling paths along the river banks, but also includes climbs on both sides of the valley with great views.",
                    Date = DateTime.Now,
                    ViewCount = 0,
                    CommentCount = 0,
                    Thumbnail = "~postImages/defaultThumbnail.jpg",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    UserId = 1,
                },
                new Post
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Driving route in Austria",
                    Content = "In terms of a best directon of travel, the Grossglockner pass is so good, it really doesnt matter which way you drive it.  We tend to prefer an approach from the south, as the rise up to the summit is longer and more sweeping, so that bit more fun to drive.  Having said that, it tends to be more popular going the other way, as people make their way south from Germany, through Austria and into the Dolomites, just south of the pass.",
                    Date = DateTime.Now,
                    ViewCount = 0,
                    CommentCount = 0,
                    Thumbnail = "~postImages/defaultThumbnail.jpg",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    UserId = 1,
                }
                );
        }
    }
}
