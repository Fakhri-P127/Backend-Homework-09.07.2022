using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_5.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Quote { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
