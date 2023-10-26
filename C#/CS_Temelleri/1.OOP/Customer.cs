using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OOP
{
    internal class Customer
    {
        // prop yazıp tab'a basınca temel yapı gelir.
        // bu şekilde property tanımlayabiliyoruz.
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        // { get; set; } olmadan tanımlarsan buna prop değil, field denir
        // public string Lastname;

        //! tanımlar üzerinde değişiklik yapman gerekirse prop kullanmak gereklidir.
        //şöyle ki; prop tanımının arka planı aslında bu şekildedir:

        private string _salary;
        public string Salary {
            get { return _salary + " TL"; }
            set { _salary = value; }
        } // buna ek olarak; get metodunu çalıştırdığımızda maaşın sonunda TL eklenmesi için özelleştirme yapıldı.
            /*** Encapsulation ***/
    }
}
