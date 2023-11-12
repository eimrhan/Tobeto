﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Product { ProductID=1, CategoryID=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15 },
                new Product { ProductID=2, CategoryID=1, ProductName="Tencere", UnitPrice=500, UnitsInStock=3 },
                new Product { ProductID=3, CategoryID=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2 },
                new Product { ProductID=4, CategoryID=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65 },
                new Product { ProductID=5, CategoryID=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1 },
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
                    if (product.ProductID == p.ProductID)
                        productToDelete = p;
             */

            // LINQ - Language Integrated Query (Dile Gömülü Sorgulama)
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            // foreach ile aynı işi görür.

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();
            // Where burada şarta uyanları yeni bir liste haline getirir ve onu döndürür.
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün ID'sine sahip olan ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.CategoryID == product.CategoryID);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}

// Bu anlatılanlar işin mantığı, EntityFramework (veya başka bir alternatif) bunları bizim yerimize yapıyor.