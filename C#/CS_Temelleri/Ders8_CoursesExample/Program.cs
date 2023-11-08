using Ders8_CoursesExample;

Category category1 = new Category();
category1.Id = 1;
category1.Name = "Programming";

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Desc = "...";
course1.CategoryId = 1;
course1.Category = category1;

Instructor instructor1 = new Instructor();
instructor1.Id = 1;
instructor1.FirstName = "Engin";
instructor1.LastName = "Demiroğ";


CourseInstructor courseInstructor1 = new CourseInstructor();
courseInstructor1.Id = 1;
courseInstructor1.CourseId = 1;
courseInstructor1.InstructorId = 1;

CourseInstructor courseInstructor2 = new CourseInstructor();
courseInstructor1.Id = 2;
courseInstructor1.CourseId = 2;
courseInstructor1.InstructorId = 1;

CourseInstructor courseInstructor3 = new CourseInstructor();
courseInstructor1.Id = 3;
courseInstructor1.CourseId = 1;
courseInstructor1.InstructorId = 2;

// https://i.imgur.com/PMIGpTA.png