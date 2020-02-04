using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Learner
    {
        [Key]
        public string LearnerId { get; set; }

        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public string M_Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The Password and Confirm PassWord fields do not match.")]
        public string confPassWord { get; set; }
    }
}
