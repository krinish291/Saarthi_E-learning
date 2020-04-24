using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Question
    {
        [Key]
        public string Id { get; set; }

        public string Statment { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Correct { get; set; }

        public string ChapterId { get; set; }

        public Chapter Chapter { get; set; }
    }
}
