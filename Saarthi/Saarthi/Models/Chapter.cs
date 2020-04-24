using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Chapter
    {
        public string Id { get; set; }

        public string Chp_Name { get; set; }

        public string SubjectId { get; set; }

        public Subject Subject { get; set; }
    }
}
