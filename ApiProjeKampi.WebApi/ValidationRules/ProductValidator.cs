using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("Ürün Adı En Az 2 Karakter Olmalıdır");
            RuleFor  (p => p.ProductName).MaximumLength(50).WithMessage("Ürün Adı En Fazla 50 Karakter Olmalıdır");
            RuleFor(p => p.ProductDescription).NotEmpty().WithMessage("Ürün Açıklaması Boş Geçilemez");
            RuleFor(p => p.ProductDescription).MinimumLength(10).WithMessage("Ürün Açıklaması En Az 10 Karakter Olmalıdır");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Fiyat 0'dan Büyük Olmalıdır");
            RuleFor(p => p.ImageUrl).NotEmpty().WithMessage("Resim URL'si Boş Geçilemez");
            RuleFor(p=>p.Price).NotEmpty().WithMessage("Fiyat Boş Geçilemez").GreaterThan(0).
                WithMessage("Fiyat 0'dan Küçük Olamaz").LessThan(1000).WithMessage("Fiyat 1000'den Büyük Olamaz");


        }
    }
}
