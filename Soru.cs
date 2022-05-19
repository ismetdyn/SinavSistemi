using SinavSistemi.Common;
using System;

namespace SinavSistemi.Entity
{
   [Table("Sorular", "SoruID", "SoruID")]
    public class Soru : IDisposable
    {
        [DataObjectField("SoruID", true, true, true, false)]
        public int SoruID { get; set; }

        [DataObjectField]
        public byte[] SoruMetni { get; set; }

        [DataObjectField]
        public int KonuID { get; set; }

        [DataObjectField]
        public int UniteID { get; set; }

        [DataObjectField]
        public string DogruCevap { get; set; }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
