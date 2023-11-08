using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_CoursesExample
{
    public class CourseInstructor
    {
        // Course ve Instructor arasında çoka-çok ilişki var.
        // bu yüzden bi 2 classın ilişkisini bir ara classta sağlıyoruz.
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        // CourseInstructor.Instructor yazarak Course içerisindeki verilere erişilebilir.
    }
}
