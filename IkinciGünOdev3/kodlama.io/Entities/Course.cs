using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.Entities
{
    public class Course : BaseClass
    {
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseName { get; set; }
        public string CourseDesciription { get; set; }
        public int CoursePrice { get; set; }
    }
}
