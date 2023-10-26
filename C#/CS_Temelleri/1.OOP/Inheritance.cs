using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface'ler de bir Inheritance örneği gibi çalışırlar ama değillerdir, onlar implemantasyondur.
// Fakat yeni nesil dillerde Inheritance gibi kullanım senaryoları mevcut (imiş).

namespace _1.OOP
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Seller : Person
    {
        public string City { get; set; }
    }
    internal class Buyer : Person
    {
        public string Address { get; set; }
    }

    // Person da kendi başına somut bir nesnedir, diğerleri ondan sadece kalıtım almıştır. Person nesnesini de istediğin yerde kullanabilirsin.
    // Fakat Interface tanımı soyut olarak tabir edilir, o tanımı sadece özellik aktarmak için kullanabilirsin, tek başıba bir değeri yoktur.

    // Interface'den bir diğer farkı ise, sadece 1 nesneye kalıtım verebilir. Buradaki ilişki direkt olarak child-parent ilişkisidir.
    internal class Person2 {
        public string LastName { get; set; } 
    }
    /// internal class Seller2 : Person, Person2 { }
    // bu şekilde çoklu implementasyon Inheritence'de münkün değil.

    //! fakat.. herhangi bir nesneye 1 adet Inheritence ardından dilediğin kadar Interface implementasyonu yapabilirsin.
    interface IPerson3 { }
    interface IPerson4 { }

    internal class Seller3:Person,IPerson3,IPerson4 { } // Inheritence'ı önce yazdığın sürece sonrasında istediğin kadar Interface eklenebilir.
}

//! ikisinin de iş gördüğü bir senaryoda Interface kullan, onun işi çözemediği durumda Inheritance.