using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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

        IProductDal _productDal;

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
    }
}
