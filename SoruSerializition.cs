using System;
using System.IO;
using DevExpress.XtraRichEdit;
using SinavSistemi.Common;
using SinavSistemi.Entity;

namespace SinavSistemi.BusinessLayer
{
    public static class SoruSerializition
    {
        public static Result<byte[]> SoruSerialize(object dosyaAdi)
        {
            try
            {
                FileStream stream = new FileStream(
                    (string)dosyaAdi,
                    FileMode.Open, FileAccess.Read);
                int sizeSoru = Convert.ToInt32(stream.Length);
                byte[] bytes = new byte[sizeSoru];
                stream.Read(bytes, 0, sizeSoru);
                return new Result<byte[]>
                {
                    IsSuccess = true,
                    Message = "Soru serialize işlemi başarılı",
                    Data = bytes
                };
            }
            catch (Exception ex)
            {
                return new Result<byte[]>
                {
                    IsSuccess = true,
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        public static Result<bool> SoruDeSerialize(this object rec, Soru soru)
        {
            try
            {
                Stream s = new MemoryStream(soru.SoruMetni as byte[]);
                ((RichEditControl)rec).LoadDocument(s);
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Soru serialize işlemi başarılı",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = ex.Message,
                    Data = false
                };
            }
        }
    }
}
