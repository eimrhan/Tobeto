using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// InMemory: Bu örnekte bellekte çalışacağız,
// ilerleyen süreçte EntityFramework ile gerçek veritabanına bağlanacağız.

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // global değişken (class'ın içinde ama bütün metotların dışında)
        // global değişkenler isimlendirme standartı olarak _ ile kullanılır.

        //ctor - Constructor bloğu oluşturma
        public InMemoryProductDal()
        {
            // Projemizi çalıştırdığımızda, bize gerçek bir veritabanında geliyormuş gibi bir veri oluşturur.
            _products = new List<Product>
            {
                new Product { Id=1, CategoryId=1, Name="Bardak", UnitPrice=15, UnitsInStock=15 },
                new Product { Id=2, CategoryId=1, Name="Tencere", UnitPrice=500, UnitsInStock=3 },
                new Product { Id=3, CategoryId=2, Name="Telefon", UnitPrice=1500, UnitsInStock=2 },
                new Product { Id=4, CategoryId=2, Name="Klavye", UnitPrice=150, UnitsInStock=65 },
                new Product { Id=5, CategoryId=2, Name="Fare", UnitPrice=85, UnitsInStock=1 },
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            /*
                Product productToDelete = null;
                foreach (var p in _products)
                    if (product.Id == p.Id)
                        productToDelete = p;
             */

            // LINQ - Language Integrated Query (Dile Gömülü Sorgulama)
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            // foreach ile aynı işi görür.

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            // Where burada şarta uyanları yeni bir liste haline getirir ve onu döndürür.
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün Id'sine sahip olan ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);

            productToUpdate.Name = product.Name;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}

// Bu anlatılanlar işin mantığı, EntityFramework (veya başka bir alternatif) bunları bizim yerimize yapıyor.