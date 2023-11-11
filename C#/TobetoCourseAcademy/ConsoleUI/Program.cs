using Business.Concretes;
using Entites.Concretes;

Category category1 = new Category() { Id = 1, Name = "Programming" };
CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category1);

Course course1 = new Course
{
    Id = 1,
    Name = "C#",
    Desc = "C Sharp",
    ImgUrl = "img.png",
    CategoryId = 1,
    Price = 100,
};
CourseManager courseManager = new CourseManager();
courseManager.Add(course1);

Instructor instructor1 = new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" };
InstructorManager instructorManager = new InstructorManager();
instructorManager.Add(instructor1);

CourseInstructor courseInstructor1 = new CourseInstructor { Id = 1, CourseId = 1, InstructorId = 1 };
CourseInstructorManager courseInstructorManager = new CourseInstructorManager();
courseInstructorManager.Add(courseInstructor1);