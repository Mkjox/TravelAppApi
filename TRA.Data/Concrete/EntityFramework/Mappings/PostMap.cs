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

            builder.Property(p => p.Place).IsRequired();
            builder.Property(p => p.Place).HasMaxLength(100);

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
                    Place = "Spain",
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
                    Place = "Belgium",
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
                    Place = "Austria",
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
                    Id = 4,
                    CategoryId = 4,
                    Title = "Kayaking spot in Canada",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas porttitor iaculis nisl a ultrices. Vivamus non aliquet ante, sit amet malesuada risus. Nunc sollicitudin sed ante vel bibendum. Etiam vehicula faucibus lacus, efficitur porta dui auctor vitae. Proin auctor dapibus ligula. Quisque dignissim tincidunt lectus tempus auctor. Morbi suscipit facilisis lorem, ac lacinia quam venenatis quis. Curabitur accumsan dui nec dui.",
                    Place = "Canada",
                    Date = DateTime.Now,
                    ViewCount = 1,
                    CommentCount = 1,
                    Thumbnail = "~postImages/defaultThumbnail.jpg",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    UserId = 1
                },
                new Post
                {
                    Id = 5,
                    CategoryId = 5,
                    Title = "Skiing place in France",
                    Content = "In volutpat luctus finibus. Cras pulvinar, mi in elementum congue, quam quam ultrices enim, id dictum nunc nisl a ex. Proin convallis suscipit venenatis. Duis mattis eu lacus eget interdum. Etiam tincidunt, justo convallis pretium posuere, nibh orci tincidunt ligula, non pulvinar elit diam vel nibh. Fusce vel maximus mi.",
                    Place = "France",
                    Date = DateTime.Now,
                    ViewCount = 2,
                    CommentCount = 2,
                    Thumbnail = "~postImages/defaultThumbnail.jpg",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    UserId = 1
                },
                new Post
                {
                    Id = 6,
                    CategoryId = 6,
                    Title = "Water Skii in Turkey",
                    Content = "Suspendisse dolor odio, dapibus eget risus ut, interdum porttitor felis. In nulla magna, commodo ac faucibus eget, pretium sit amet arcu. Integer odio ante, dapibus aliquam congue at, viverra at lectus. Pellentesque sit amet elementum mi. Phasellus purus urna, aliquam id metus et, sagittis faucibus nisi.",
                    Place = "Turkey",
                    Date = DateTime.Now,
                    ViewCount = 2,
                    CommentCount = 1,
                    Thumbnail = "~postImages/defaultThumbnail.jpg",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    UserId = 1
                },
                new Post
                {
                    Id = 7,
                    CategoryId = 7,
                    Title = "Swimming areas in Greece",
                    Content = "Aliquam erat volutpat. Etiam vitae auctor tellus, vel cursus mi. Integer ex eros, bibendum ac luctus ut, condimentum eu nibh. Etiam nibh neque, consectetur sed augue eu, lacinia lobortis ante. Integer ut molestie nunc.",
                    Place = "Greece",
                    Date = DateTime.Now,
                    ViewCount = 2,
                    CommentCount = 2,
                    Thumbnail = "~postImages/defaultThumbnail.jpg",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    UserId = 1
                }
                );
        }
    }
}
