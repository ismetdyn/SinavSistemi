using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SinavSistemi.Presentation
{
    public partial class AnaSayfaUC : UserControl
    {
        public AnaSayfaUC()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            labelControl1.Text = " Merhaba Sizin Sıavlarınız İçin\r\n Geliştirilmiş Uygulamamıza Hoşgeldiniz\r\n Hadi Bakalım Sınav Sistemimiz\r\n Hakkında Birazcık Bilgi Sahibi Olalım\r\n Öncelikle Sınav Sistemimiz\r\n " +
                "6 SİGMA PRENSİBİNE\r\n Dayanan Bir Yöntem İzler.\r\n Yani Senden  6 Farklı Zamanda\r\n Sınav Yapmanı İsteyeceğiz. Tabii\r\n İstersen Daha Fazla da Sınav Yapabilirsin.\r\n 6 Farklı Zamanda da Aynı Soruya \r\n 6 Kere Doğru Cevap Verirsen Bize Bu Konuyu " +
                "\r\n Bildiğini Göstermiş Olup Bizde Bu\r\n Soruyu Senin Bildiğin Sorular Havuzuna Atacağız.\r\n Bilmezsen Eğer Bu Soruları\r\n Bilmediğin Sorular Havuzuna Atacağız. ";
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");

            }
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
            }
        }
    }
}
