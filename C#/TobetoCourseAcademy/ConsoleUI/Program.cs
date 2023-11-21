using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entites.Concretes;

//Test1();
Test2();

static void Test1()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetCategories().Data)
        Console.WriteLine(category.Name);
    Console.WriteLine("---------------");


    InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

    foreach (var instructor in instructorManager.GetInstructors().Data)
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

    foreach (var course in courseManager.GetCourses().Data)
        Console.WriteLine(course.ToString());
    Console.WriteLine("---------------");


    var result = courseManager.GetCourseDetails();

    foreach (var item in result.Data)
        Console.WriteLine(item.CourseName + " / " + item.InstructorName);
}

static void Test2()
{
    CourseManager courseManager = new CourseManager(new EfCourseDal());

    var model = new Course()
    {
        Id = 8,
        //Name = "Test3",
        //Desc = "Tesasda3t",
        //Price = 2000,
        //ImgUrl = "---",
        //CategoryId = 1,
    };
    //courseManager.Add(model);
    //courseManager.Update(model);
    var result = courseManager.Delete(model);
    Console.WriteLine(result.Message);
}