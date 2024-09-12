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
                    Description = "Hiking is a journey through nature's most serene landscapes—dense forests, rugged mountain peaks, hidden waterfalls—each one rewarding your effort with a beauty that can only be discovered on foot. As the sun sets and you reach the summit, the sense of accomplishment mixes with awe, reminding you of the power of simply walking through the world’s wonders.",
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
                    Description = "Feel the wind in your hair and the world rushing past as you glide down open roads or twisty trails on a bicycle. Whether you’re navigating through charming countryside, coasting along the beach, or zipping through bustling city streets, biking gives you a front-row seat to experience your surroundings. It’s a thrill of speed and freedom, where every turn offers a new vista, and every pedal brings you closer to your next adventure.",
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
                    Description = "The open road stretches ahead, promising new discoveries at every bend. There’s something intoxicating about a road trip—the thrill of spontaneous detours, the soundtrack of your favorite tunes, and the freedom to explore wherever your heart desires.",
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
                    Description = "Whether you’re navigating tranquil lakes, winding rivers, or riding the exhilarating currents of the ocean, kayaking is a personal journey into the heart of nature. As you skim over the water’s surface, you become part of the landscape, able to reach secret coves, hidden islands, and serene spots inaccessible by any other means.",
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
                    Description = "Slicing through fresh powder as you carve your way down a snow-covered mountain is a rush like no other. Skiing is the perfect blend of adrenaline and elegance—each swoop and turn making you feel weightless as the world becomes a blur of white and blue. From high alpine peaks with panoramic views to cozy mountain resorts where hot cocoa awaits, skiing offers a thrill that lingers long after the day’s last run.",
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
                    Description = "Feel the exhilaration as you rise out of the water, your skis skimming across the surface, and you pick up speed behind a powerful boat. Water skiing is pure adrenaline—the rush of wind in your face and the splash of water at your feet as you cut through waves. Each turn and jump offers a new challenge, a test of balance, and an opportunity to push yourself. It's the ultimate way to combine water, speed, and thrill, leaving you craving more.",
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
                    Description = "Underneath the surface, you’re free to lose yourself in the tranquility of the underwater world or power through a refreshing workout. Swimming is both a peaceful escape and a personal challenge, offering a sense of freedom that stays with you long after you leave the water.",
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
