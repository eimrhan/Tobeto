using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface'lerin tek başına bir anlamı yoktur,
// sadece kalıtım vermek amaçlı kullanılır.
// Buradaki tüm tanımlamalar, kalıtım alan child classlarda kullanılmak zorunda!

namespace _2_OOP4
{
    interface IKrediManager
    {
        void Hesapla();

        void DoSomething();
    }
}