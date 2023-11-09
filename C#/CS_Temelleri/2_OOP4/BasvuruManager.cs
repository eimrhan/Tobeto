using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOP4
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            /* ...diğer kodlar... */

            krediManager.Hesapla();
        }
        // üstteki senaryoda müşteri hangi krediyi alacağını bilir ve hesaplamanın harici
        // diğer gerekli kodlarla birlikte BasvuruYap metodu işleme alınır.

        // alttaki senaryoda ise müşteri hangisini seçeceğini bilemez ve
        // tüm kredilerin ön bilgilendirmesi olarak bi hesaplaması alınır.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
                kredi.Hesapla();
        }
    }
}
