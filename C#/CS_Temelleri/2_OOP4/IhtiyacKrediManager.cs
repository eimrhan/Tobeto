using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOP4
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı.");
        }
    }
}
