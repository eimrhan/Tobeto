using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOP2
{
    // "Manager dosyası, demek ki Product ile ilgili operasyonlar (metotlar) var bu dosyada." denebilir.
    internal class ProductManager
    {
        public void Add(Product product) // Product tipinde bir product parametresi alır.
        {
            Console.WriteLine(product.Name + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " güncellendi.");
        }
    }
}
