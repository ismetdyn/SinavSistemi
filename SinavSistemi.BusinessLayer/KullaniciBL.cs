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
    public class KullaniciBL
    {
        DAL dal = new DAL();
        public int KullaniciEkle(Kullanici kullanici)
        {
            dal.InputParametreEkle("@KullaniciAdi", kullanici.KullaniciAdi);
            dal.InputParametreEkle("@Ad", kullanici.Ad);
            dal.InputParametreEkle("@Soyad", kullanici.Soyad);
            dal.InputParametreEkle("@Eposta", kullanici.Eposta);
            dal.InputParametreEkle("@Sifre", kullanici.Sifre);
            dal.InputParametreEkle("@KullaniciTipi", kullanici.KullaniciTipi);
            int sonuc = dal.EkleSilGuncelle("sp_KullaniciEkle", CommandType.StoredProcedure);

            return sonuc;
        }

        public int KullaniciSil(Kullanici kullanici)
        {
            dal.InputParametreEkle("@KullaniciID", kullanici.KullaniciID);
            int sonuc = dal.EkleSilGuncelle("sp_KullaniciSil", CommandType.StoredProcedure);
            return sonuc;
        }

        public int KullaniciGuncelle(Kullanici kullanici)
        {
            dal.InputParametreEkle("@KullaniciID", kullanici.KullaniciID);
            dal.InputParametreEkle("@KullaniciAdi", kullanici.KullaniciAdi);
            dal.InputParametreEkle("@Ad", kullanici.Ad);
            dal.InputParametreEkle("@Soyad", kullanici.Soyad);
            dal.InputParametreEkle("@Eposta", kullanici.Eposta);
            dal.InputParametreEkle("@Sifre", kullanici.Sifre);
            dal.InputParametreEkle("@KullaniciTipi", kullanici.KullaniciTipi);
            int sonuc = dal.EkleSilGuncelle("sp_KullaniciGuncelle", CommandType.StoredProcedure);

            return sonuc;
        }

        public List<Kullanici> KullanicileriGetir()
        {
            SqlDataReader dr = dal.DRVeriCek("sp_KullanicilariGetir", CommandType.StoredProcedure);
            if (dr.HasRows)
            {
                List<Kullanici> kullanicilar = new List<Kullanici>();
                while (dr.Read())
                {
                    Kullanici kullanici = new Kullanici()
                    {
                        KullaniciID = Convert.ToInt32(dr["KullaniciID"].ToString()),
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Ad = dr["Ad"].ToString(),
                        Soyad = dr["Soyad"].ToString(),
                        Eposta = dr["Eposta"].ToString(),
                        Sifre = dr["Sifre"].ToString(),
                        KullaniciTipi = Convert.ToInt32(dr["KullaniciTipi"].ToString())
                    };

                    kullanicilar.Add(kullanici);
                }
                return kullanicilar;
            }

            return null;
        }
    }
}
