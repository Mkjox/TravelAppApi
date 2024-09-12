﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Dtos
{
    public class UserUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(50, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string UserName { get; set; }

        [DisplayName("E-Mail Address")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(100, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(10, ErrorMessage = "{0} can't be less than {1} characters.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(13, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(13, ErrorMessage = "{0} can't be less than {1} characters.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DisplayName("Add a Picture")]
        [DataType(DataType.Upload)]
        public IFormFile? PictureFile { get; set; }

        [DisplayName("Picture")]
        public string Picture { get; set; }

        [DisplayName("Name")]
        [MaxLength(30, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(2, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string FirstName { get; set; }

        [DisplayName("Surname")]
        [MaxLength(30, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(2, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string LastName { get; set; }

        [DisplayName("About")]
        [MaxLength(1000, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(5, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string About { get; set; }

        [DisplayName("Twitter")]
        [MaxLength(250, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(20, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string TwitterLink { get; set; }

        [DisplayName("Facebook")]
        [MaxLength(250, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(20, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string FacebookLink { get; set; }

        [DisplayName("Instagram")]
        [MaxLength(250, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(20, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string InstagramLink { get; set; }

        [DisplayName("Youtube")]
        [MaxLength(250, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(20, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string YoutubeLink { get; set; }

        //[DisplayName("Github")]
        //[MaxLength(250, ErrorMessage = "{0} can't be more than {1} characters.")]
        //[MinLength(20, ErrorMessage = "{0} can't be less than {1} characters.")]
        //public string GithubLink { get; set; }

        [DisplayName("Website")]
        [MaxLength(250, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(20, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string WebsiteLink { get; set; }
    }
}
