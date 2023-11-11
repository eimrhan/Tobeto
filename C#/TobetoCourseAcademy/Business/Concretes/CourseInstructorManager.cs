using DataAccess.Concretes;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseInstructorManager
    {
        public void Add(CourseInstructor courseInstructor)
        {
            AdoNetCourseInstructorDal courseInstructorDal = new AdoNetCourseInstructorDal();
            courseInstructorDal.Add(courseInstructor);
        }
    }
}
