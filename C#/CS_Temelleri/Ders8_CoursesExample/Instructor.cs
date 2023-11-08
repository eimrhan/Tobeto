using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_CoursesExample
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public CourseInstructor[] CourseInstructors { get; set; }
        // class olan model tek 1 tane olurken, veritabanına yansıdığında tablo içinde birden fazla veri olabilir.
        // bu yüzden çoğul isimlendirme kullanıyoruz.
    }
}
