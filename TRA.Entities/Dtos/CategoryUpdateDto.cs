using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(30, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
        [MaxLength(500, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string Description { get; set; }

        [DisplayName("Is it active?")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        public bool IsActive { get; set; }

        [DisplayName("Is it deleted?")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        public bool IsDeleted { get; set; }
    }
}
