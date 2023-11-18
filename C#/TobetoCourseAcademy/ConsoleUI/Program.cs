using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

Test1();

static void Test1()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetCategories())
        Console.WriteLine(category.Name);
    Console.WriteLine("---------------");


    InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

    foreach (var instructor in instructorManager.GetInstructors())
        Console.WriteLine(instructor.FirstName + ' ' + instructor.LastName);
    Console.WriteLine("---------------");


    CourseManager courseManager = new CourseManager(new EfCourseDal());

    foreach (var course in courseManager.GetCourses().Data)
        Console.WriteLine(course.Name);
    Console.WriteLine("---------------");

    foreach (var course in courseManager.GetCoursesByCategoryId(2).Data)
        Console.WriteLine(course.Name);
    Console.WriteLine("---------------");

    foreach (var course in courseManager.GetCoursesByPrice(50, 100).Data)
        Console.WriteLine(course.Name);
    Console.WriteLine("---------------");


    var result = courseManager.GetCourseDetails();

    foreach (var item in result.Data)
        Console.WriteLine(item.CourseName + " / " + item.InstructorName);
}
