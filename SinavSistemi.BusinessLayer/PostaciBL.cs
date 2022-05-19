using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinavSistemi.Entity;
using SinavSistemi.Common;

namespace SinavSistemi.BusinessLayer
{
    public class PostaciBL : BaseBL<PostaciBL>
    {
        private int sayi;
        protected int Sayi
        {
            get {
                Random rnd = new Random();
                sayi = rnd.Next(100, 999);
                return sayi;
            }
        }

        public Result<int> MailGonder(string eposta)
        {
            string
                mailIstemcisi = "smtp.outlook.com",
                gondericiMail = "guneryusuff@outlook.com",
                gondericiSifre = "14420212714Yg";
            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(eposta);

                msg.From = new System.Net.Mail.MailAddress(gondericiMail);
                msg.IsBodyHtml = true;
                msg.Body = Sayi.ToString();

                System.Net.NetworkCredential guvenlikKarti =
                    new System.Net.NetworkCredential(gondericiMail, gondericiSifre);
                client.Credentials = guvenlikKarti;
                client.Port = 587;
                client.Host = mailIstemcisi;
                client.EnableSsl = true;
                client.Send(msg);
                client = null;
                msg = null;
                guvenlikKarti = null;
                return new Result<int>
                {
                    IsSuccess = true,
                    Message = "Mesaj gönderme başarılı",
                    Data = sayi
                };
            }
            catch(Exception ex)
            {
                return new Result<int>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
