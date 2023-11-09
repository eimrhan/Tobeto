using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOP4
{
    internal class BasvuruManager
    {
        // Method Injection

        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            /* ...diğer kodlar... */

            krediManager.Hesapla();
            loggerService.Log();
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


        // birden fazla loglama isteği gönderdiğimiz örnek senaryo için ise bu şekilde bir metot oluşturmamız gerekiyor:
        internal void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            /* ...diğer kodlar... */

            krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
                loggerService.Log();
        }
    }
}
