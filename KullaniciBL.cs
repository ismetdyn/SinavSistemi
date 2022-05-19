using System;
using System.Reflection;
using SinavSistemi.Common;
using SinavSistemi.Entity;
using SinavSistemi.ORM;

namespace SinavSistemi.BusinessLayer
{
    public class KullaniciBL : BaseBL<KullaniciBL>
    {
        public Result<Kullanici> KullaniciOlustur(DynamicDataTransferObject ddto)
        {
            try
            {
                if (ddto == null) throw new Exception();
                Kullanici kullanici = new Kullanici();
                foreach (var kvp in ddto.dictionary)
                {
                    foreach (PropertyInfo pi in typeof(Kullanici).GetProperties())
                    {
                        if (pi.Name == kvp.Key) 
                            pi.SetValue(kullanici, kvp.Value);
                    }
                }

                return new Result<Kullanici>
                {
                    IsSuccess = true,
                    Message = "Kullanici başarıyla oluşturuldu",
                    Data = kullanici
                };


            }
            catch (Exception ex)
            {
                return new Result<Kullanici>
                {
                    IsSuccess = false, 
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        public Result<Kullanici> LoginAuthorize(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Kullanici> result1 = KullaniciOlustur(ddto);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Result<Kullanici> result2 = KullaniciORM.Current.GetBy("KullaniciAdi", (string)ddto["KullaniciAdi"]);
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                if (result1.Data.Sifre != result2.Data.Sifre) throw new Exception("Şifre Hatalı");
                return new Result<Kullanici>
                {
                    IsSuccess = true,
                    Message = "Kullnıcı veritabanından başarıla getirildi.",
                    Data = result2.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<Kullanici>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        public Result<Kullanici> GetUserByEmail(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Kullanici> result1 = KullaniciORM.Current.GetBy("Eposta",(string)ddto["Eposta"]);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                return new Result<Kullanici>
                {
                    IsSuccess = true, 
                    Message = result1.Message, 
                    Data = result1.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<Kullanici>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
                throw;
            }
        }

        public Result<bool> UpdateUser(Kullanici kullanici)
        {
            try
            {
                Result<bool> result2 = KullaniciORM.Current.Update(kullanici);
                if(!result2.IsSuccess) throw new Exception(result2.Message);
                return new Result<bool>
                {
                    IsSuccess = true, Message = result2.Message
                };
            }
            catch (Exception ex)
            {
                return new Result<bool>
                {
                    IsSuccess = false, Message = ex.Message
                };
            }
        }

        public Result<Kullanici> Giris(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Kullanici> result1 = KullaniciORM.Current.GetBy(
                    "KullaniciAdi",(string)ddto["KullaniciAdi"]);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                if (result1.Data.Sifre != (string)ddto["Sifre"]) throw new Exception("Şifre Hatalı!");
                return new Result<Kullanici>
                {
                    IsSuccess = true,
                    Message = "Giriş Başarılı",
                    Data = result1.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<Kullanici>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<Kullanici> ForgetPaswordSendMail(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Kullanici> result1 = Current.GetUserByEmail(ddto);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Result<int> result2 = PostaciBL.Current.MailGonder((string)ddto["Eposta"]);
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                int rand_num = result2.Data;
                return new Result<Kullanici>
                {
                    IsSuccess = true,
                    Message = result2.Data.ToString(),
                    Data = result1.Data
                };
            }

            catch (Exception ex)
            {
                return new Result<Kullanici>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<int> RegistrationSendMail(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<int> result1 = PostaciBL.Current.MailGonder((string)ddto["Eposta"]);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                int rand_num = Convert.ToInt32(result1.Data);
                return new Result<int>
                {
                    IsSuccess = true,
                    Data = result1.Data
                };
            }

            catch (Exception ex)
            {
                return new Result<int>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<Kullanici> GetUserByUserName(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Kullanici> result1 = KullaniciORM.Current.GetBy("KullaniciAdi", (string)ddto["KullaniciAdi"]);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                return new Result<Kullanici>
                {
                    IsSuccess = true,
                    Message = result1.Message,
                    Data = result1.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<Kullanici>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
                throw;
            }
        }

        public Result<int> PreRegistration(DynamicDataTransferObject ddto)
        {
            try
            {
                Result<Kullanici> result1 = GetUserByUserName(ddto);
                if (result1.IsSuccess) throw new Exception("Aynı isimli kullanıcı veritabanında var!");
                Result<Kullanici> result2 = GetUserByEmail(ddto);
                if (result2.IsSuccess) throw new Exception("Eposta veritabanında var!");
                Result<int> result3 = RegistrationSendMail(ddto);
                if (!result3.IsSuccess) throw new Exception(result3.Message);
                return new Result<int>
                {
                    IsSuccess = true,
                    Message = result3.Message,
                    Data = result3.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<int>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public Result<Kullanici> InsertAndGetUser(Kullanici kullanici)
        {
            try
            {
                Result<bool> result1 = KullaniciORM.Current.Insert(kullanici);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                Result<Kullanici> result2 = KullaniciORM.Current.GetBy(
                    "KullaniciAdi", kullanici.KullaniciAdi);
                if(!result2.IsSuccess) throw new Exception(result2.Message);
                return new Result<Kullanici>
                {
                    IsSuccess = true,
                    Message = "Yeni kullanıcı veritabanıa eklendi ve getiriidi.",
                    Data = result2.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<Kullanici>
                {
                    IsSuccess =  false,
                    Message = ex.Message
                };
            }
            
        }
    }
}
