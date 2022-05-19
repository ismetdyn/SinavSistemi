using System;
using System.Windows.Forms;
using SinavSistemi.Common;

namespace SinavSistemi.Presentation
{
    public partial class AdminUI : DevExpress.XtraEditors.XtraForm
    {
        bool sidebarExpand;
        private DynamicDataTransferObject ddto;
        public AdminUI()
        {
            InitializeComponent();
            ddto = new DynamicDataTransferObject();
        }

        protected internal DynamicDataTransferObject FillDDTO()
        {
            //ddto["KullaniciAdi"] = beKullaniciAdi.Text;
            //ddto["Sifre"] = beSifre.Text;
            return ddto;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
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
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Stop();
            sidebarTimer.Start();
        }

        private void btnKullanicilar_Click_1(object sender, EventArgs e)
        {
            analiz1.Hide();
            sorular1.Hide();
            kullanicilar1.Show();
        }

        private void btnSorular_Click_1(object sender, EventArgs e)
        {
            kullanicilar1.Hide();
            analiz1.Hide();
            sorular1.Show();
        }

        private void btnAnaliz_Click_1(object sender, EventArgs e)
        {
            kullanicilar1.Hide();
            sorular1.Hide();
            analiz1.Show();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
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
    }
}