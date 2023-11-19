using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    // içeriği sabir olacak, newlenmeyecek. o yüzden static verdik.
    {
        // değişken isimlerini Public tanımlandığı için büyük harfle başlatıyoruz.
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün Adı Geçersiz!";
        public static string MaintenanceTime = "Sistem Bakımda!";
        public static string ProductListed = "Ürünler Listelendi.";
    }
}
