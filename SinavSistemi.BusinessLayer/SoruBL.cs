using SinavSistemi.DataAccessLayer;
using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.BusinessLayer
{
    public class SoruBL
    {
        DAL dal = new DAL();

        public int SoruEkle(Soru soru)
        {
            dal.InputParametreEkle("@SoruMetni", soru.SoruMetni);
            dal.InputParametreEkle("@KonuID", soru.KonuID);
            dal.InputParametreEkle("@UniteID", soru.UniteID);
            dal.InputParametreEkle("@ResimYolu", soru.ResimYolu);
            dal.InputParametreEkle("@DogruCevap", soru.DogruCevap);
            dal.InputParametreEkle("@YanlisCevaplar", soru.YanlisCevaplar);
            int sonuc = dal.EkleSilGuncelle("sp_SoruEkle", CommandType.StoredProcedure);

            return sonuc;
        }

        public int SoruSil(Soru soru)
        {
            dal.InputParametreEkle("@SoruID", soru.SoruID);
            int sonuc = dal.EkleSilGuncelle("sp_SoruSil", CommandType.StoredProcedure);

            return sonuc;
        }

        public int SoruGuncelle(Soru soru)
        {
            dal.InputParametreEkle("@SoruID", soru.SoruID);
            dal.InputParametreEkle("@SoruMetni", soru.SoruMetni);
            dal.InputParametreEkle("@KonuID", soru.KonuID);
            dal.InputParametreEkle("@UniteID", soru.UniteID);
            dal.InputParametreEkle("@ResimYolu", soru.ResimYolu);
            dal.InputParametreEkle("@DogruCevap", soru.DogruCevap);
            dal.InputParametreEkle("@YanlisCevaplar", soru.YanlisCevaplar);
            int sonuc = dal.EkleSilGuncelle("sp_SoruGuncelle", CommandType.StoredProcedure);

            return sonuc;
        }

        public List<Soru> SorulariGetir()
        {
            SqlDataReader dr = dal.DRVeriCek("sp_SorulariGetir", CommandType.StoredProcedure);
            if (dr.HasRows)
            {
                List<Soru> sorular = new List<Soru>();
                while (dr.Read())
                {
                    Soru soru = new Soru()
                    {
                        SoruID = Convert.ToInt32(dr["SoruID"].ToString()),
                        SoruMetni = dr["SoruMetni"].ToString(),
                        KonuID = Convert.ToInt32(dr["KonuID"].ToString()),
                        UniteID = Convert.ToInt32(dr["UniteID"].ToString()),
                        ResimYolu = dr["ResimYolu"].ToString(),
                        DogruCevap = dr["DogruCevap"].ToString(),
                        YanlisCevaplar = dr["YanlisCevaplar"].ToString()
                    };

                    sorular.Add(soru);
                }
                return sorular;
            }
            return null;
        }


    }
}
