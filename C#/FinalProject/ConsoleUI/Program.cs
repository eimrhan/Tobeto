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

//ProductManager productManager = new ProductManager(new InMemoryProductDal());
ProductManager productManager = new ProductManager(new EfProductDal());
// S'O'LID - O : Open Closed Principle ("projene yeni bir şey ekliyorsan, mevcut kodlara dokunamazsın.")
// Kodlarda değişim yapmadan sadece InMemoryProductDal'ı EfProductDal olarak değiştirerek yeni db'e geçtik.

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}
Console.WriteLine("--------------");

foreach (var product in productManager.GetAllByCategoryID(2))
{
    Console.WriteLine(product.ProductName);
}
Console.WriteLine("--------------");

foreach (var product in productManager.GetByUnitPrice(50,100))
{
    Console.WriteLine(product.ProductName);
}
Console.WriteLine("--------------");