using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SinavSistemi.Entity;

namespace SinavSistemi.VerificationValidationLayer
{
    class SoruVVL : AbstractValidator<Soru>
    {
        public SoruVVL()
        {
            RuleFor(x => x.SoruMetni).NotNull().WithMessage("Soru Metni null ifade olamaz");
            RuleFor(x => x.SoruMetni).NotEmpty().WithMessage("Soru Metni boş geçilemez.");
            RuleFor(x => x.SoruMetni).Must(DoluMu).WithMessage("Soru Metni boş geçilemez");

            RuleFor(x => x.UniteID).NotNull().WithMessage("Unite ID NULL ifade olamaz");
            RuleFor(x => x.UniteID).NotEmpty().WithMessage("Unite ID boş olamaz.");

            RuleFor(x => x.KonuID).NotNull().WithMessage("Konu ID NULL ifade olamaz.");
            RuleFor(x => x.KonuID).NotEmpty().WithMessage("Konu ID boş geçilemez");

            RuleFor(x => x.DogruCevap).NotNull().WithMessage("Dogru cevap NULL ifade olamaz");
            RuleFor(x => x.DogruCevap).NotEmpty().WithMessage("Dogru cevap boş geçilemez");
            RuleFor(x => x.DogruCevap).Must(DoluMu).WithMessage("Dogru cevap boş geçilemez");
            
        }

        private bool DoluMu(string arg)
        {
            return arg != null && arg.Trim().Length > 0 && !string.IsNullOrWhiteSpace(arg);
        }
    }
}
