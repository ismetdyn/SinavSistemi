using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using SinavSistemi.Common;
using SinavSistemi.Entity;

namespace SinavSistemi.ORM
{
    public class SoruORM : ORMBase<Soru, SoruORM> 
    {
        public Result<List<Soru>> GetSoruToSigma(Kullanici kullanici)
        {
            try
            {
                if (kullanici  == null) throw new Exception("Hata! Kullanici null.");
                string query = string.Format("SELECT * FROM Sorular" +
                    " WHERE SoruID NOT IN" +
                    " (SELECT s.SoruID FROM Sorular s INNER JOIN Istatistikler i" +
                    " ON s.SoruID = i.SoruID where i.KullaniciID = @KullaniciID)");
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@KullaniciID", kullanici.KullaniciID);
                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count <= 0 || dt.Rows[0][0] == DBNull.Value) throw new Exception("Eşleşen veri bulunamadı");
                Result<List<Soru>> result =  dt.ToList<Soru>();
                if(!result.IsSuccess) throw new Exception(result.Message);

                return new Result<List<Soru>>
                {
                    IsSuccess = true,
                    Message = "Sorular başarıyla getirildi",
                    Data = result.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<List<Soru>>
                {
                    IsSuccess = false,
                    Message =ex.Message
                };
            }
        }

        public Result<List<Soru>> GetQuestionsByGapTime(Kullanici kullanici, int beginTime, int lastTime)
        {
            try
            {
                if (lastTime <= 0 || beginTime <= 0 || beginTime > lastTime ) 
                    throw new Exception("Gap zaman hatası");
                string query = string.Format("SELECT " +
                    "s.SoruID, s.SoruMetni, s.KonuID, s.UniteID, s.DogruCevap " +
                    "FROM Sorular s INNER JOIN Istatistikler i ON S.SoruID = i.SoruID where " +
                    "i.KullaniciID = @KullaniciID AND " +
                    "(GETDATE() BETWEEN DATEADD(day, @BeginTime, Zaman) AND DATEADD(day, @LastTime, Zaman)) ");
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@KullaniciID", kullanici.KullaniciID);
                cmd.Parameters.AddWithValue("@BeginTime", beginTime);
                cmd.Parameters.AddWithValue("@LastTime", lastTime);
                cmd.CommandText = query;
                cmd.Connection = Tools.Connection;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count <= 0 || dt.Rows[0][0] == DBNull.Value) throw new Exception("Eşleşen veri bulunamadı");
                Result<List<Soru>> result = dt.ToList<Soru>();
                if (!result.IsSuccess) throw new Exception(result.Message);

                return new Result<List<Soru>>
                {
                    IsSuccess = true,
                    Message = "Sorular başarıyla getirildi",
                    Data = result.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<List<Soru>>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

    }
}
