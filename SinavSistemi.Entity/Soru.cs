using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Entity
{
    public class Soru : IDisposable
    {
        public int SoruID { get; set; }
        public string SoruMetni { get; set; }
        public int KonuID { get; set; }
        public int UniteID { get; set; }
        public string ResimYolu { get; set; }
        public string DogruCevap { get; set; }
        public string YanlisCevaplar { get; set; }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
