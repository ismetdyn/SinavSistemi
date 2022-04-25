using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace SinavSistemi.BusinessLayer
{
    class EmailBL
    {
        KullaniciBL kullanici = new KullaniciBL();
        public static string mailGonder(string aliciMail, string baslik, string mesaj)
        {
            string
                mailIstemcisi = "smtp.outlook.com",
                gonMail = "guneryusuff@outlook.com",
                gonMailSifre = "14420212714Yg";

            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(aliciMail);

                //if (ccler != null) msg.CC.Add(ccler);
                //if (bccler != null) msg.CC.Add(bccler);
                //if(ekliDosyaSunucuYolu != null)
                //{
                //    System.Net.Mail.Attachment data = new System.Net.Mail.Attachment(ekliDosyaSunucuYolu, System.Net.Mime.MediaTypeNames.Application.Octet);
                //    msg.Attachments.Add(data);
                //}



                msg.From = new System.Net.Mail.MailAddress(gonMail);
                msg.Subject = baslik;
                msg.IsBodyHtml = true;
                msg.Body = mesaj;

                NetworkCredential guvenlikKarti = new System.Net.NetworkCredential(gonMail, gonMailSifre);
                client.Credentials = guvenlikKarti;
                client.Port = 587;
                client.Host = mailIstemcisi;
                client.EnableSsl = true;
                client.Send(msg);
                client = null;
                msg = null;
                guvenlikKarti = null;
                return "Mailiniz Başarılı Bir Şekilde Gönderildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }



        }
    }
}
