using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Dtos
{
    public class UserRegisterDto
    {
        [MaxLength(30, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(2, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string FirstName { get; set; }

        [MaxLength(30, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(2, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(50, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(100, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(10, ErrorMessage = "{0} can't be less than {1} characters.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(30, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(5, ErrorMessage = "{0} can't be less than {1} characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
