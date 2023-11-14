using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // "Manager görürsen, anla ki o iş katmanının somut sınıfı."
    public class ProductManager : IProductService
    {
        // Dipnot: "Bir iş sınıfı başka sınıfları new'lemez."

        IProductDal _productDal; // Business katmanı veri erişim katmanına (dal) bağımlı
        // bağımlılığımızı minimize etmemiz lazım. (belki bir gün o bağ değişir ihtimali)
        // bağımlılığımızı constructor injection ile yapıyoruz:
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları ...

            // iş kodlarından geçtiyse sıra veri erişiminde. // DataAccess

            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryID(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
