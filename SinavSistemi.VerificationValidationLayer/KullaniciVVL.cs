using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SinavSistemi.VerificationValidationLayer
{
    public class KullaniciVVL : AbstractValidator<Kullanici>
    {
        public KullaniciVVL()
        {
            RuleFor(x => x.KullaniciAdi).NotNull().WithMessage("Kullanıcı adı null ifade olamaz");
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.KullaniciAdi).MaximumLength(20).WithMessage("Kullanıcı adı 20 karakterden büyük olamaz.");
            RuleFor(x => x.KullaniciAdi).Must(DoluMu).WithMessage("Kullanıcı adı boş geçilemez");

            RuleFor(x => x.KullaniciTipi).NotNull().WithMessage("Kullanıcı tipi null ifade olamaz");
            RuleFor(x => x.KullaniciTipi).NotEmpty().WithMessage("Kullanıcı tipi boş olamaz");
            RuleFor(x => x.KullaniciTipi).GreaterThan(0).WithMessage("Kullanıcı tipi 0' dan büyük olmalıdır.");
            RuleFor(x => x.KullaniciTipi).LessThan(4).WithMessage("Kullanıcı tipi 4'ten büyük olamaz");

            RuleFor(x => x.Sifre).NotNull().WithMessage("Sifre null ifade olamaz");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Şifre boşgeçilemez");
            RuleFor(x => x.Sifre).Must(DoluMu).WithMessage("Lutfen bir şifre giriniz.");
            RuleFor(x => x.Sifre).Length(6,20).WithMessage("Şifre en az 6, fazla 20 karakter oluşabilir.");

            RuleFor(x => x.Eposta).NotNull().WithMessage("Mail null ifade olamaz");
            RuleFor(x => x.Eposta).NotEmpty().WithMessage("Mail boş geçilemez.");
            RuleFor(x => x.Eposta).Must(DoluMu).WithMessage("Eposta boş geçilemez");
            RuleFor(x => x.Eposta).EmailAddress().WithMessage("Geçerli bir eposta adresi giriniz.");
        }

        private bool DoluMu(string arg)
        {
            return arg != null && arg.Trim().Length > 0 && !string.IsNullOrWhiteSpace(arg);
        }
    }
}
