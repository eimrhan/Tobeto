using _1.OOP;


/****************************** Classlar ******************************/

/* ::::: FirstClass.cs ::::: */

FirstClass firstClass = new FirstClass(); // class'ın bir örneğini oluşturuyoruz.
firstClass.Add(); // class'ın içindeki fonksiyonlara erişebildik.
firstClass.Remove();

/* ::::: Customer.cs ::::: */

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
// ------------------------------------------------------------------ //


/****************************** Interface ******************************/

/* ::::: Interfaces.cs ::::: */

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

// ------------------------------------------------------------------ //


/*** Polymorphism ***/

/* ::::: IStudentDal.cs ::::: */

StudentManager studentManager = new StudentManager();
studentManager.Add(new SqlServerStudentDal());

// ayrıca ikisini (veya daha çoğunu) aynı anda da kullanabiliriz: 
IStudentDal[] studentDals = new IStudentDal[2]
{
    new SqlServerStudentDal(),
    new OracleStudentDal()
};
foreach (var studentDal in studentDals)
{
    studentDal.Add();
}
// ------------------------------------------------------------------ //


/*** Çoklu İmplementasyon ***/

/* ::::: IWorker.cs ::::: */

IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};
foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Manager(),
    new Worker()
};
foreach (var eat in eats)
{
    eat.Eat();
}
// ------------------------------------------------------------------ //



/****************************** Inheritance (Kalıtım) ******************************/

/* ::::: Inheritance.cs ::::: */

// Seller seller = new Seller();
Person[] persons = new Person[3]
{
    new Seller(),
    new Buyer(),
    new Person
    {
        Name = "Emirhan"
    }
    // Interface'ler Soyuttur, tek başına kullanılamaz. Fakat Inheritance tanımını (Person()) burada kullanabildik.
};
// ------------------------------------------------------------------ //
