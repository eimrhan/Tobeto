using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entites.Concretes;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, DatabaseContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                var result = from course in dbContext.Courses
                             join courseInstructors in dbContext.CoursesInstructors on course.Id equals courseInstructors.CourseId
                             join instructors in dbContext.Instructors on courseInstructors.InstructorId equals instructors.Id
                             select new CourseDetailDto
                             {
                                 CourseId = course.Id,
                                 CourseName = course.Name,
                                 Price = course.Price,
                                 InstructorName = instructors.FirstName
                             };
                return result.ToList();
            }
        }
    }
}
