using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinavSistemi.Entity;

namespace SinavSistemi.BusinessLayer
{
    public class PostaciBL
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

        public string  MailGonder(Kullanici alici)
        {
            string
                mailIstemcisi = "smtp.gmail.com",
                gondericiMail = "ismetdayan1@gmail.com",
                gondericiSifre = "SD1049_id1093";
            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(alici.Eposta);

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
                return sayi.ToString() + "BAŞARILI";
            }
            catch(Exception ex)
            {
                return ex.Message; 
            }
        }
    }
}
