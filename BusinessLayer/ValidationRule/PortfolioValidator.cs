using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen bir proje adı giriniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Lütfen bir resim ekleyiniz");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Lütfen bir resim ekleyiniz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Lütfen bir fiyat ekleyiniz");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Lütfen bir değer giriniz");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakter olabilir ");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın ");

        }
    }
}
