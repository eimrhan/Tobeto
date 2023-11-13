using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

foreach (var category in categoryManager.GetCategories())
    Console.WriteLine(category.Name);
Console.WriteLine("---------------");


CourseManager courseManager = new CourseManager(new EfCourseDal());

foreach (var course in courseManager.GetCourses())
    Console.WriteLine(course.Name);
Console.WriteLine("---------------");

foreach (var course in courseManager.GetCoursesByCategoryId(2))
    Console.WriteLine(course.Name);
Console.WriteLine("---------------");

foreach (var course in courseManager.GetCoursesByPrice(50,100))
    Console.WriteLine(course.Name);
Console.WriteLine("---------------");


InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

foreach (var instructor in instructorManager.GetInstructors())
    Console.WriteLine(instructor.FirstName + ' ' + instructor.LastName);
Console.WriteLine("---------------");
