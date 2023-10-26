using _1.OOP;

/****************************** Classlar ******************************/

FirstClass firstClass = new FirstClass(); // class'ın bir örneğini oluşturuyoruz.
firstClass.Add(); // class'ın içindeki fonksiyonlara erişebildik.
firstClass.Remove();

// Class içerisinde tanımladığımız propslara 2 şekilde erişebiliriz:
Customer customer1 = new Customer();
customer1.Id = 1;
customer1.Name = "Emirhan";
customer1.City = "Sakarya";
// bu tanımlamalar 'set' bloğunu çalıştırır.
// kullanmak için çağırdımızda da 'get' bloğu çalışmış olur.
Customer customer2 = new Customer
{
    Id = 2,
    Name = "Engin",
    City = "İstanbul"
};


/****************************** Interface ******************************/

PersonManager manager = new PersonManager();

manager.Add(new Student { Id = 1, Name = "IEmirhan" });
// 2 farklı kullanımı tekrar görmüş olalım: ↑ ↓
Teacher teacher = new Teacher
{
    Id = 1,
    Name = "IEngin",
    Address = "İstanbul Kodluyor"
};
manager.Add(teacher);
// interface kullandığım için ikisinin de verilerini Add methoduna gönderebildim.

/*** ***/
StudentManager studentManager = new StudentManager();
studentManager.Add(new SqlServerStudentDal());

