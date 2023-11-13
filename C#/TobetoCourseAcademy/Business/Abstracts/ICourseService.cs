using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetCourses();
        List<Course> GetCoursesByCategoryId(int categoryId);
        List<Course> GetCoursesByPrice(decimal min, decimal max);
    }
}
