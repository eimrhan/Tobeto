using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OOP
{
    internal interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        // interface'de prop tanımlamalarında public keylerini sil.
    }

    class Student : IPerson
    {
        // 'Resharper' sayesinde ampüle basıp "implement missing members" seçeneğini seçerek propları otomatik ekleyebiliyoruz.
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Teacher : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; } // implentlerin haricinde devamına kendi tanımlarımızı yazıp devam ederiz.
    }

    class PersonManager // Manager isimlendirmeleri genellikle iş katmanı sınıfları için kullanılır.
    {
        public void Add(IPerson person)
        // burada methoda parametre olarak interface verdiğimiz için her bir class için ayrı ayrı method oluşturmaya gerek kalmadı
        // şimdi bu interface'i kullanan istediğin classa ait veriyi gönderebilirsin. (Program.cs satır:28-42)
        {
            Console.WriteLine(person.Name);
            // tabi bunun dezavantajları da mevcut. burada sadece interface'de (IPerson'da) tanımlı propları kullanabiliriz.
            // Teacher.Address propertysine bu şekilde erişilemez.
        }
    }
}
