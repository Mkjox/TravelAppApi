using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRA.Entities.Concrete;

namespace TRA.Entities.Dtos
{
    public class PostAddDto
    {
        [DisplayName("Title")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(100, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(5, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string Title { get; set; }

        [DisplayName("Content")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MinLength(20, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string Content { get; set; }

        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(250, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(5, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string? Thumbnail { get; set; }

        [DisplayName("Balance")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(6, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(1, ErrorMessage = "{0} can't be less than {1} characters.")]
        public int Balance { get; set; }

        [DisplayName("Rating")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(1, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(0, ErrorMessage = "{0} can't be less than {1} characters.")]
        public int Rating { get; set; }

        [DisplayName("Duration")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(2, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(1, ErrorMessage = "{0} can't be less than {1} characters.")]
        public int Duration { get; set; }

        [DisplayName("Date")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        public int CategoryId { get; set; }

        [DisplayName("Is it Active?")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        public bool IsActive { get; set; }
    }
}
