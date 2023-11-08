using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_CoursesExample
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public CourseInstructor[] CourseInstructors { get; set; }
        // çoka çok ilişki için kullandığımız ara class
    }
}
