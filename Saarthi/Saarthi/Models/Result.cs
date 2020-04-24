using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Result
    {

        [Key]
        public string Id { get; set; }

        public DateTime QuizOn { get; set; }
        public int Total { get; set; }
        public int Obtained { get; set; }
        public string chepter { get; set; }
        public string Subject { get; set; }
        public string std { get; set; }
        public string LearnerId { get; set; }

        public Learner Learner { get; set; }

    }
}
