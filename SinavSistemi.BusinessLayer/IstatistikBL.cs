using SinavSistemi.Common;
using SinavSistemi.Entity;
using SinavSistemi.ORM;
using System;
using System.Collections.Generic;

namespace SinavSistemi.BusinessLayer
{
    public class IstatistikBL : BaseBL<IstatistikBL>
    {

        public Result<List<Istatistik>> IstatistikleriOlustur
            (List<Soru> sorular, string[] cevaplar, Kullanici kullanici)
        {
            try
            {
                List<Istatistik> istatistikler = new List<Istatistik>();
                for (int i = 0; i < sorular.Count; i++)
                {
                    if(sorular[i].DogruCevap == cevaplar[i])
                    {
                        istatistikler.Add(new Istatistik()
                        {
                            SoruID = sorular[i].SoruID,
                            KullaniciID = kullanici.KullaniciID,
                            Zaman = DateTime.Now
                        }); 
                    }
                }
                return new Result<List<Istatistik>>
                {
                    IsSuccess = true,
                    Message = "İstatistik listesi oluşturma başarılı",
                    Data = istatistikler
                };
            }
            catch (Exception ex)
            {
                return new Result<List<Istatistik>>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<bool> IstatistikToDB(Istatistik istatistik)
        {
            try
            {
                if (istatistik == null)
                    throw new Exception("Hata!(IstatistikToDB) istatistik null");
                Result<Istatistik> result1 = IstatistikORM.Current.CheckIstatistikInDB(istatistik);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                if(result1.Data != null)
                {
                    istatistik = result1.Data;
                    if (istatistik.Basari == false)
                    {
                        if (istatistik.Tur < 6) istatistik.Tur++;
                        if (istatistik.Tur == 6) istatistik.Basari = true;
                    }
                    Result<bool> result2 = IstatistikORM.Current.Update(istatistik);
                    if (!result2.IsSuccess) throw new Exception(result2.Message);
                }
                else
                {
                    Result<bool> result3 = IstatistikORM.Current.Insert(istatistik);
                    if (!result3.IsSuccess) throw new Exception(result3.Message);
                }
                
                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Soru to istatisktikler başarılı."
                };
            }
            catch (Exception ex)
            {

                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<bool> MultipleIstatistikToDB(List<Soru> sorular, string[] cevaplar, Kullanici kullanici)
        {
            try
            {
                Result<List<Istatistik>> result1 = IstatistikleriOlustur(sorular, cevaplar, kullanici);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                if (result1.Data == null) throw new Exception("Liste null");
                foreach (Istatistik istatistik in result1.Data)
                {
                    if (istatistik != null)
                    {
                        Result<bool> result2 = IstatistikToDB(istatistik);
                        if (!result2.IsSuccess) throw new Exception(result2.Message);
                    }
                }

                return new Result<bool>
                {
                    IsSuccess = true,
                    Message = "Çoklu istatistik ekleme başarılı"
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
