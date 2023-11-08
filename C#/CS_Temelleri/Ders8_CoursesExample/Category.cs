using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_CoursesExample
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        public Course[] Courses { get; set; }
        // Her kursun 1 kategorisi olur fakat her kategoride 1'den fazla kurs olabilir.
    }
}
