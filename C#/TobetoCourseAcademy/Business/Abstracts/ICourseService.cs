using Core.Utilities.Result;
using Entites.Concretes;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetCourses();
        IDataResult<List<Course>> GetCoursesByCategoryId(int categoryId);
        IDataResult<List<Course>> GetCoursesByPrice(decimal min, decimal max);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IResult Add(Course course);
    }
}
