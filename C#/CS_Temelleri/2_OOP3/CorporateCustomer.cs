using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kurumsal / Tüzel Müşteri

namespace _2_OOP3
{
    internal class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string VergiNo { get; set; }
    }
}
