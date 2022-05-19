using SinavSistemi.Common;
using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SinavSistemi.ORM
{
    public class IstatistikORM : ORMBase<Istatistik, IstatistikORM>
    {
        public Result<Istatistik> CheckIstatistikInDB(Istatistik istatistik)
        {
            try
            {
                if (istatistik == null) throw new Exception
                        ("\"CheckQuestionInIstatistik\" başarısız! Kullanici veya Soru null");
                string query = 
                    string.Format("SELECT * FROM Istatistikler WHERE KullaniciID = @KullaniciID AND SoruID = @SoruID");
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@KullaniciID", istatistik.KullaniciID);
                cmd.Parameters.AddWithValue("@SoruID", istatistik.SoruID);
                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                
                Result<Istatistik> result1 = new Result<Istatistik>() { IsSuccess = true };
                
                if (dt.Rows.Count <= 0 || dt.Rows[0][0] == DBNull.Value)
                {
                    result1.Message =
                        "CheckIstatistikInDB komutu başarıyla çalıştı " +
                        "fakat eşleşen öğe bulunamadı";
                    result1.Data = null;
                }
                else
                {
                    result1.Message =
                        "CheckIstatistikInDB komutu başarıyla çalıştı, " +
                        "eşleşen öğe bulundu";
                    Result<Istatistik> result2 = dt.Rows[0].ToEntity<Istatistik>();
                    if (!result2.IsSuccess) throw new Exception(result2.Message);
                    result1.Data = result2.Data;
                }


                return result1;
            }
            catch (Exception ex)
            {
                return new Result<Istatistik>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
