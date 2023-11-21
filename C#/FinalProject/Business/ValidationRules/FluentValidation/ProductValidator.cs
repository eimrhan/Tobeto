using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //RuleFor(p => p.ProductName).NotEmpty().MinimumLength(2);
            // bitişik kurallar yazılabilir. ama ayrı yazmak SOLID'e daha uygun.
            RuleFor(p => p.ProductName).MinimumLength(2);

            // RuleFor(p => p.UnitPrice > 0);
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10)
                .When(p => p.CategoryID == 1)   // alt durum ekleyebiliriz.
                .WithMessage("Kategori ID'si 1 olan ürünün fiyatı en az 10 TL olmalı.");

            RuleFor(p => p.ProductName).Must(StartWithA) // StartWithA kendi oluşturduğumuz özel metot.
                .WithMessage("Ürün ismi 'A' harfi ile başlamalı.");
                // default mesajlar yerine özel mesaj eklenebilir. (özel metotlarda kullanılması iyi olur.)
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
