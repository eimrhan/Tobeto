using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.AdoNet
{
    public class AdoNetCourseInstructorDal
    {
        public void Add(CourseInstructor courseInstructor)
        {
            Console.WriteLine("Ado.Net kullanılarak veritabanına eklendi.");
        }
    }
}
