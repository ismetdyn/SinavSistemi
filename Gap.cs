using SinavSistemi.Common;
using System;

namespace SinavSistemi.Entity
{
    [Table("KullaniciGaps", "ID", "ID","KullaniciID")]
    public class Gap : IDisposable
    {
        [DataObjectField("ID", true, true, true, false)]
        public int ID { get; set; }

        [DataObjectField("KullaniciID", true, false, false, true)]
        public int KullaniciID { get; set; }

        [DataObjectField]
        public int Gap1 { get; set; }

        [DataObjectField]
        public int Gap2 { get; set; }

        [DataObjectField]
        public int Gap3 { get; set; }

        [DataObjectField]
        public int Gap4 { get; set; }

        [DataObjectField]
        public int Gap5 { get; set; }

        [DataObjectField]
        public int Gap6 { get; set; }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
