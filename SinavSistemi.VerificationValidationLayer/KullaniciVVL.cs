using SinavSistemi.BusinessLayer;
using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.VerificationValidationLayer
{
    public class KullaniciVVL
    {
        public bool KullaniciOnayla(Kullanici kullanici)
        {
            return KullaniciDogrulama(kullanici);
        }

        private bool KullaniciDogrulama(Kullanici kullanici)
        {
            if (!DoluMu(kullanici.Ad))
            { return false; }
            if (!isValidAlphaNumeric(kullanici.Ad))
            { return false; }
            if (kullanici.Eposta == null || kullanici.Eposta.Trim().Length == 0)
            { return false; }
            if (!isValidEmail(kullanici.Eposta))
            { return false; }
            return true;
        }

        private bool DoluMu(string value)
        { return value != null && value.Trim().Length > 0; }

        private bool isValidAlphaNumeric(string value)
        {
            return true;
        }

        private bool isValidEmail(string value)
        {
            return true;
        }
    }
}
