/****************************** Classlar ******************************/

using _1.OOP;

MyClass myClass = new MyClass(); // class'ın bir örneğini oluşturuyoruz.
myClass.Add(); // class'ın içindeki fonksiyonlara erişebildik.
myClass.Remove();

FirstClass firstClass = new FirstClass(); // classları harici sayfalarda da oluşturabiliriz.
firstClass.newClass(); // yine aynı şekilde erişiyoruz.

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


class MyClass
{
    public void Add()
    {
        Console.WriteLine("added");
    }
    public void Remove()
    {
        Console.WriteLine("removed");
    }
}