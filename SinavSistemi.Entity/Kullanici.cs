using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Entity
{
    public class Kullanici : IDisposable
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public int KullaniciTipi { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
