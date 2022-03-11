using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MvcWebUI.Models;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Adı alanı boş bırakılamaz."); // NotEmpty(); required demek boş geçilemez.
            RuleFor(s => s.FirstName).MinimumLength(2); // minimum 2 karakterden oluşmalı.

            RuleFor(s => s.LastName).NotEmpty();

            RuleFor(s => s.Address).NotEmpty();

            //yaşı 18'den küçük ise şehir bilgisi girilmesi zorunlu.
            RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);

            // vermek istediğimiz kural yoksa Must() ile kendi kuralımızı oluşturuyoruz. Adlar A ile başlamak zorunda diyoruz.
            //RuleFor(s => s.FirstName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
