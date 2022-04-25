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

namespace SinavSistemi.UI
{
    public partial class User : Form
    {
        bool sidebarExpand;
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            //Form load olduğunda user controlleri Gizleme
            anaSayfa1.Hide();
            sonuclarim1.Hide();
            hesap1.Hide();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
        }

        private void btnAnaSayfa_Click_1(object sender, EventArgs e)
        {
            //Ana sayfa butonuna tıklandığında Başka user controllerin Gizlenmesi
            sonuclarim1.Hide();
            hesap1.Hide();
            kullanıcıKayıtlar1.Hide();
            //Ana sayfa User Controlünün Gösterilmesi
            anaSayfa1.Show();

            //Svg Resminin Değiştirilmesi
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            //Sonuçlarım butonuna tıklandığında Başka user controllerin Gizlenmesi
            anaSayfa1.Hide();
            hesap1.Hide();
            //Sonuçlarım User Controlünün Gösterilmesi
            sonuclarim1.Show();

        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
                //Hesap butonuna tıklandığında Başka user controllerin Gizlenmesi
                anaSayfa1.Hide();
                sonuclarim1.Hide();
                //Hesap User Controlünün Gösterilmesi
                hesap1.Show();
       
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            string message = "Uygulamadan Çıkmayı İstiyor musun?";
            string title = "Pencereyi Kapat";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //Sidebar Panelinin Minimum Boyutunu Tanımlama



            if (sidebarExpand)
            {
                //if sidebar is  expand, minimize 
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Geçişlerin daha temiz , ve düzgün görünmesi için Timer intervali en düşük değere çekme
            sidebarTimer.Stop();
            sidebarTimer.Start();
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hesap1_Load(object sender, EventArgs e)
        {

        }

        private void sonuclarim1_Load(object sender, EventArgs e)
        {

        }

        private void anaSayfa1_Load(object sender, EventArgs e)
        {

        }
    }
}
