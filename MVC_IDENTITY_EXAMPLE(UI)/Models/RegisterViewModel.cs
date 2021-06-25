using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_IDENTITY_EXAMPLE_UI_.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string RepeatPassword { get; set; }

    }
}
