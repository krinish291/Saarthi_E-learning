using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Subject
    {
        public string Id { get; set; }

        public string Sub_Name { get; set; }

        public string StandardId { get; set; }

        public Standard Standard { get; set; }
    }
}
