﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;

namespace TRA.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Picture).IsRequired(false);
            builder.Property(u => u.Picture).HasMaxLength(250);

            builder.Property(u => u.YoutubeLink).IsRequired(false);
            builder.Property(u => u.YoutubeLink).HasMaxLength(250);

            builder.Property(u=>u.TwitterLink).IsRequired(false);
            builder.Property(u => u.TwitterLink).HasMaxLength(250);

            builder.Property(u=>u.InstagramLink).IsRequired(false);
            builder.Property(u => u.InstagramLink).HasMaxLength(250);

            builder.Property(u=>u.FacebookLink).IsRequired(false);
            builder.Property(u => u.FacebookLink).HasMaxLength(250);

            builder.Property(u=>u.WebsiteLink).IsRequired(false);
            builder.Property(u => u.WebsiteLink).HasMaxLength(250);

            builder.Property(u=>u.PhoneNumber).IsRequired(false);

            builder.Property(u=>u.FirstName).IsRequired(false);
            builder.Property(u => u.FirstName).HasMaxLength(30);

            builder.Property(u => u.LastName).IsRequired(false);
            builder.Property(u => u.LastName).HasMaxLength(30);

            builder.Property(u=>u.About).IsRequired(false);
            builder.Property(u => u.About).HasMaxLength(1000);

            builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

            builder.ToTable("Users");

            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(u => u.UserName).HasMaxLength(50);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(100);

            // Each User can have many UserClaims
            builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var adminUser = new User
            {
                Id = 1,
                UserName = "adminuser",
                NormalizedUserName = "ADMINUSER",
                Email = "adminuser@gmail.com",
                NormalizedEmail = "ADMINUSER@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "~/img/userImages/defaultUser.png",
                FirstName = "Admin",
                LastName = "User",
                About = "Admin User of Travel App",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                WebsiteLink = "https://travelapp.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser.PasswordHash = CreatePasswordHash(adminUser, "adminuser");

            var editorUser = new User
            {
                Id = 2,
                UserName = "editoruser",
                NormalizedUserName = "EDITORUSER",
                Email = "editoruser@gmail.com",
                NormalizedEmail = "EDITORUSER@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "~/img/userImages/defaultUser.png",
                FirstName = "Editor",
                LastName = "User",
                About = "Editor User of Travel App",
                TwitterLink = "https://twitter.com/editoruser",
                InstagramLink = "https://instagram.com/editoruser",
                YoutubeLink = "https://youtube.com/editoruser",
                WebsiteLink = "https://travelapp.com/",
                FacebookLink = "https://facebook.com/editoruser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            editorUser.PasswordHash = CreatePasswordHash(editorUser, "editoruser");

            var testUser = new User
            {
                Id = 3,
                UserName = "testUser",
                NormalizedUserName = "TESTUSER",
                Email = "testuser@gmail.com",
                NormalizedEmail = "TESTUSER@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "~/img/userImages/defaultUser.png",
                FirstName = "Test",
                LastName = "User",
                About = "Test User of Travel App",
                TwitterLink = "https://twitter.com/testuser",
                InstagramLink = "https://instagram.com/testuser",
                YoutubeLink = "https://youtube.com/testuser",
                WebsiteLink = "https://travelapp.com/",
                FacebookLink = "https://facebook.com/testuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            testUser.PasswordHash = CreatePasswordHash(testUser, "testuser");

            builder.HasData(adminUser, editorUser, testUser);
        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
