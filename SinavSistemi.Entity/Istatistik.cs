using SinavSistemi.Common;
using System;

namespace SinavSistemi.Entity
{
    [Table("Istatistikler", "IstatistikID", "IstatistikID")]
    public class Istatistik : IDisposable
    {

        public Istatistik()
        {
            Tur = 1;
            Basari = false;
            Zaman = DateTime.Now;
        }

        [DataObjectField("IstatistikID", true, true, true, false)]
        public int IstatistikID { get; set; }

        [DataObjectField]
        public int KullaniciID { get; set; }

        [DataObjectField]
        public int SoruID { get; set; }

        [DataObjectField]
        public bool Basari { get; set; }

        [DataObjectField]
        public DateTime Zaman { get; set; }

        [DataObjectField]
        public int Tur { get; set; }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
