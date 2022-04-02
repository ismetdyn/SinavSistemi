using SinavSistemi.Common;
using System;

namespace SinavSistemi.Entity
{
   [TableAttribute("Sorular", "SoruID", "SoruID")]
    public class Soru : IDisposable
    {
        [DataObjectField("KullaniciID", true, true, true, false)]
        public int SoruID { get; set; }

        [DataObjectField]
        public string SoruMetni { get; set; }

        [DataObjectField]
        public int KonuID { get; set; }

        [DataObjectField]
        public int UniteID { get; set; }

        [DataObjectField]
        public string ResimYolu { get; set; }

        [DataObjectField]
        public string DogruCevap { get; set; }

        [DataObjectField]
        public string YanlisCevaplar { get; set; }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
