using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.DataAccessLayer
{
    public class DAL
    {
        private SqlCommand SorguYaz(string sorgu, CommandType sorguTipi)
        {
            Baglanti baglanti = Baglanti.TekNesneYarat();
            SqlCommand cmd = baglanti.BaglantiKablosu.CreateCommand();
            cmd.CommandText = sorgu;
            cmd.CommandType = sorguTipi;
            return cmd;
        }

        List<SqlParameter> Parametreler = new List<SqlParameter>();

        public void InputParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            SqlParameter parametre = new SqlParameter();
            parametre.ParameterName = ParametreAdi;
            parametre.Value = ParametreDegeri;
            Parametreler.Add(parametre);
        }

        public void OutputParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            SqlParameter parametre = new SqlParameter();
            parametre.ParameterName = ParametreAdi;
            parametre.Value = ParametreDegeri;
            parametre.Direction = ParameterDirection.Output;
            Parametreler.Add(parametre);
        }

        private void ParametreleriSorguyaEkle(SqlCommand commandNesnesi)
        {
            commandNesnesi.Parameters.AddRange(Parametreler.ToArray());
            Parametreler.Clear();
        }

        public object ParametreDegeriniGetir(string ParametreAdi)
        {
            foreach (var item in Parametreler)
            {
                if (item.ParameterName == ParametreAdi)
                {
                    return item.Value.ToString();
                }
            }
            return null;
        }

        public int EkleSilGuncelle(string sorgu, CommandType sorguTipi)
        {
            try
            {
                SqlCommand cmd = SorguYaz(sorgu, sorguTipi);
                ParametreleriSorguyaEkle(cmd);
                int sonuc = cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();
                Parametreler.Clear();

                return sonuc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object IlkSatirIlkSutun(string sorgu, CommandType sorguTipi)
        {
            try
            {
                SqlCommand cmd = SorguYaz(sorgu, sorguTipi);
                ParametreleriSorguyaEkle(cmd);
                object sonuc = cmd.ExecuteScalar();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();
                Parametreler.Clear();
                return sonuc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public SqlDataReader DRVeriCek(string sorgu, CommandType sorguTipi)
        {
            SqlCommand cmd = SorguYaz(sorgu, sorguTipi);
            ParametreleriSorguyaEkle(cmd);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Parametreler.Clear();
            return dr;
        }

        public DataTable DTVeriCek(string sorgu, CommandType sorguTipi)
        {
            try
            {
                SqlDataReader dr = DRVeriCek(sorgu, sorguTipi);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
