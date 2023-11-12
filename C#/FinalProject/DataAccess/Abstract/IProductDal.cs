using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // "İş Classlarını oluştururken, önce onun Interface'ini oluştur. Bunu kural haline getir! (gerek görmesen bile)" 
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        // interface metodları default olarak public'dir, başına public vermene gerek yok.

        List<Product> GetByCategory(int categoryId);
    }
}
