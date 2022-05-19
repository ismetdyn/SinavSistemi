using SinavSistemi.Common;
using System;

namespace SinavSistemi.Entity
{
    [Table("Kullanicilar", "KullaniciID", "KullaniciID", "KullaniciAdi")]
    public class Kullanici : IDisposable
    {
        [DataObjectField("KullaniciID", true, true, true, false)]
        public int KullaniciID { get; set; }

        [DataObjectField("KullaniciAdi", true, false, false, true)]
        public string KullaniciAdi { get; set; }

        [DataObjectField]
        public string Ad { get; set; }

        [DataObjectField]
        public string Soyad { get; set; }

        [DataObjectField]
        public string Eposta { get; set; }

        [DataObjectField]
        public string Sifre { get; set; }

        [DataObjectField]
        public int KullaniciTipID { get; set; }

        public Kullanici DeepCopy()
        {
            Kullanici other = (Kullanici)MemberwiseClone();
            other.KullaniciID = Convert.ToInt32(string.Copy(KullaniciID.ToString()));
            other.KullaniciAdi = string.Copy(KullaniciAdi);
            other.Ad = string.Copy(Ad);
            other.Soyad = string.Copy(Soyad);
            other.Eposta = string.Copy(Eposta);
            other.Sifre = string.Copy(Sifre);
            other.KullaniciTipID = Convert.ToInt32(string.Copy(KullaniciTipID.ToString()));
            return other;
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
