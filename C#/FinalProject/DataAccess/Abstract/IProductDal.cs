using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product> // "sen bir Product repositorysisin" diyoruz.
    {
        //List<Product> GetAll();
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
        //List<Product> GetByCategory(int categoryId);

        // IEntityRepository ile dinamik bir yapı oluşturduk ve
        // her bir obje için ayrı ayrı yapı oluşturmaya gerek kalmadı.
        // IEntityRepository'den kalıtım almak yeterli artık.


        List<ProductDetailDto> GetProductDetails();
    }
}
