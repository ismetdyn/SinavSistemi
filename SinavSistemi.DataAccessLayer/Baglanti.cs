using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.DataAccessLayer
{
    class Baglanti
    {
        private static Baglanti baglanti;
        static object kilitliNesne = new object();

        private Baglanti() { }

        public static Baglanti TekNesneYarat()
        {
            lock (kilitliNesne)
            {
                if (baglanti == null)
                    baglanti = new Baglanti();
            }
            return baglanti;
        }

        SqlConnection baglantiKablosu;
        public SqlConnection BaglantiKablosu
        {
            get
            {
                if (baglantiKablosu != null)
                {
                    if (baglantiKablosu.State == ConnectionState.Open)
                    {
                        baglantiKablosu.Close();
                        baglantiKablosu.Open();
                    }
                    else
                    {
                        baglantiKablosu.Open();
                    }
                    return baglantiKablosu;
                }
                else
                {
                    baglantiKablosu = new SqlConnection(Provider());
                    if (baglantiKablosu.State == ConnectionState.Closed)
                    {
                        baglantiKablosu.Open();
                    }
                    return baglantiKablosu;
                }
            }
        }

        private string Provider()
        {
            return ConfigurationManager.AppSettings["BaglantiCumlesi"];
        }


    }
}
