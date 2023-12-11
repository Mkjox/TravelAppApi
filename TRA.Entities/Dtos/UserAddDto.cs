using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Entities.Dtos
{
    public class UserAddDto
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(50, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string UserName { get; set; }

        [DisplayName("E-Mail Address")]
        [Required(ErrorMessage = "{0} can't be empty.")]
        [MaxLength(100, ErrorMessage = "{0} can't be more than {1} characters.")]
        [MinLength(10, ErrorMessage = "{0} can't be less than {1} characters.")]
        public string Email { get; set; }

        // Password
        // Phone number
        // Picture

        // Name
        // Surname

        // and other things
    }
}
