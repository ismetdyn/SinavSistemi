using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using SinavSistemi.Entity;
using DevExpress.XtraBars;

namespace SinavSistemi.UI
{
    public partial class FrgtPsswrdUI : DevExpress.XtraEditors.XtraForm
    {
        public FrgtPsswrdUI()
        {
            InitializeComponent();
        }

        Kullanici kullanici = new Kullanici();
        private void btnGonder_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int rand_num = rnd.Next(10000, 99999);
            //string sonuc = mailGonder(aliciText.Text, "Sınav Sistemi Şifre:", "Tekrar Uygulamaya Dönüp Şifrenizi Değiştirebilirsiniz!");
            //MessageBox.Show(sonuc);
        }

        private void FrgtPsswrdUI_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
        }

        private void aliciText_TextChanged(object sender, EventArgs e)
        {
            //kullanici.Eposta = aliciText.Text;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if(toggleSwitch1.IsOn)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");

            }
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
            }
        }

        public static string mailGonder(string aliciMail, string baslik, string mesaj, string ccler,
            string bccler, string ekliDosyaSunucuYolu)
        {
            string
                mailIstamcisi = "smtp.outlook.com",
                gonMail = "guneryusuff@outlook.com",
                gonMailSifre = "14420212714Yg";

            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(aliciMail);
                

                msg.From = new System.Net.Mail.MailAddress(gonMail);
                msg.Subject = baslik;
                //msg.IsBodyHtml = true;
                msg.Body = mesaj;

                System.Net.NetworkCredential guvenlikKarti = new System.Net.NetworkCredential(gonMail,
                    gonMailSifre);
                client.Credentials = guvenlikKarti;
                client.Port = 587;
                client.Host = mailIstamcisi;
                client.EnableSsl = true;
                client.Send(msg);
                client = null;
                msg = null;
                guvenlikKarti = null;
                return "Mailiniz başarılı bir şekilde gönderildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void btnGonder_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand_num = rnd.Next(1000, 9999);
            string sonuc = mailGonder(aliciText.Text, "Şifre onaylama: ", rand_num.ToString(), null, null, null);
            MessageBox.Show(sonuc);

            if(mailGonder(aliciText.Text,null,null,null,null,null) == "Mailiniz başarılı bir şekilde gönderildi")
            {
                panelControl1.Visible = true;
            }
            
        }

        private void svgImageBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}