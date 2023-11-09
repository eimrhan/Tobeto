using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bireysel / Gerçek Müşteri

namespace _2_OOP3
{
    internal class IndividualCustomer:Customer // Miras (Inheritance)
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        /* Normalde sayısal verilerden oluşan TcNo gibi verileri
            üzerinde matematiksel olarak işlem yapılmayacaksa
            string olarak tutmak daha sağlıklı bir yöntem. */
    }
}
