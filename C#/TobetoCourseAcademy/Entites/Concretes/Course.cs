using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
