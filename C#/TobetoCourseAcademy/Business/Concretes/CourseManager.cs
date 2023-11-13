using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetCourses()
        {
            return _courseDal.GetAll();
        }

        public List<Course> GetCoursesByCategoryId(int categoryId)
        {
            return _courseDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Course> GetCoursesByPrice(decimal min, decimal max)
        {
            return _courseDal.GetAll(p => p.Price >= min && p.Price <= max);
        }
    }
}
