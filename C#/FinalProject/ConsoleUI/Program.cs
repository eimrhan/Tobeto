/* Temel yapıyı oluştururken projeyi 3 katmana bölüyoruz;
   Entities, DataAccess, Business
   Entities içinde genellikle veritabanı nesnelerimiz bulunur,
   Business iş katmanıdır, veri erişiminden önce çalışır
   Data Access ise veri erişim katmanıdır.
   
   Bu 3 katmana şu 2 klasörü oluştururuz: */

/* (Concrete=Somut; Abstract=Soyut)
   Soyut nesneler (interface, abstract classlar, base classlar) Abstract klasörleri altında olacak.
   Somut nesneler Concrete klasörlerinde. */

// https://i.imgur.com/zh85O0v.png
/* ************************************** */

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//ProductTest();
//CategoryTest();
ResultTest();

static void ProductTest()
{
    // S'O'LID - O : Open Closed Principle ("projene yeni bir şey ekliyorsan, mevcut kodlara dokunamazsın.")
    // Kodlarda değişim yapmadan sadece InMemoryProductDal'ı EfProductDal olarak değiştirerek yeni db'e geçtik.
    //ProductManager productManager = new ProductManager(new InMemoryProductDal());

    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetAll().Data)
    {
        Console.WriteLine(product.ProductName);
    }
    Console.WriteLine("--------------");

    foreach (var product in productManager.GetAllByCategoryID(2).Data)
    {
        Console.WriteLine(product.ProductName);
    }
    Console.WriteLine("--------------");

    foreach (var product in productManager.GetByUnitPrice(50, 100).Data)
    {
        Console.WriteLine(product.ProductName);
    }
    Console.WriteLine("--------------");

    foreach (var p in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(p.ProductName + " / " + p.CategoryName);
    }

    Console.WriteLine("********************");
}
static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
        Console.WriteLine(category.CategoryName);
    Console.WriteLine("--------------");

    var c = categoryManager.GetById(2);
    Console.WriteLine(c.CategoryName);

    Console.WriteLine("********************");
}

static void ResultTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetails();

    if (result.IsSuccess)
    {
        foreach (var product in result.Data)
            Console.WriteLine(product.ProductName + " / " + product.CategoryName);
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}