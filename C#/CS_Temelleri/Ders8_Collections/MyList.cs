using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_Collections
{
    class MyList<T> // Type'ın T'si. Belirli bir tip de belirlenebilir fakat bu şekilde oluna daha dinaik oluyor.
    {
        T[] items; // T tipinde items isimli bir array oluşturduk.
        public MyList() // Constructor (ctor->tab) // Class ile aynı isim olur.
        {
            // items newlendiğinde Constructor bloğu otomatik olarak çalışır. bu yüzden burada
            items = new T[0]; // ile sıfır elemanlı diziyi oluşturuyoruz.
        }
        public void Add(T item) // kullanıcı hangi tipte veri girerse o tipi alır, gocunmaz.
        {
            // yeni eleman eklerken öncelikle boyutunu 1 artırmamız lazım, fakat onun da öncesinde // 2.
            // yeni dizi oluşturunca referans adresi değişeceği için eski verileri kaybediyorduk, 
            // bunun için eski elemanları önce bir geçici diziye atıyoruz. // 1.
            // sonra döngüyle eski elemanları geri alıyoruz. // 3.
            // ve son olarak yeni elemanı yeni dizinin son elemanı olarak atıyoruz. // 4.
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
                items[i] = tempArray[i];
            items[items.Length-1] = item;
        }

        public int Length // items'ın Length'ine erişmek için oluşturduğumuz metot.
        {
            get { return items.Length; }
        }
        public T[] Items // elemanlara erişmek için
        {
            get { return items; }
        }
    }
}
