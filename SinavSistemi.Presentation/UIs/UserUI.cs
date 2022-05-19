using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SinavSistemi.Presentation
{
    public partial class UserUI : Form
    {
        bool sidebarExpand;
        protected internal AnaSayfaUC AnaSayfaUC { get; set; }
        protected internal SonuclarimUC SonuclarimUC { get; set; }
        protected internal HesapUC HesapUC { get; set; }
        protected internal AyarlarUC AyarlarUC { get; set; }
        protected internal RaporUC RaporUC { get; set; }
        public UserUI()
        {
            InitializeComponent();
            AnaSayfaUC = new AnaSayfaUC();
            SonuclarimUC = new SonuclarimUC();
            HesapUC = new HesapUC();
            AyarlarUC = new AyarlarUC();
            RaporUC = new RaporUC();
        }

        private void User_Load(object sender, EventArgs e)
        {
            AnaSayfaUC.Parent = panelRight;
            AnaSayfaUC.Dock = DockStyle.Fill;
            SonuclarimUC.Parent = panelRight;
            SonuclarimUC.Dock = DockStyle.Fill;
            HesapUC.Parent = panelRight;
            HesapUC.Dock = DockStyle.Fill;
            AyarlarUC.Parent = panelRight;
            AyarlarUC.Dock = DockStyle.Fill;
            RaporUC.Parent = panelRight;
            RaporUC.Dock = DockStyle.Fill;
            AnaSayfaUC.Show();
            this.BackColor = Color.Lavender;
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            string message = "Uygulamadan Çıkmayı İstiyor musun?";
            string title = "Pencereyi Kapat";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn) DevExpress.LookAndFeel.UserLookAndFeel.
                    Default.SetSkinStyle("Office 2019 Black");
            else DevExpress.LookAndFeel.UserLookAndFeel.
                    Default.SetSkinStyle("Office 2010 Silver");
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Hamburger Strip İkonuna basıldığında SideBar'ın davranışının belirlenmesi
            sidebarTimer.Stop();
            sidebarTimer.Start();
        }

        void ShowAndHideUC(UserControl  _UC)
        {
            foreach (UserControl UC in panelRight.Controls)
            {
                if (UC.Name == _UC.Name) UC.Show();
                else UC.Hide();
            }
        }

        private void btnSubMenuAnaSayfa_Click(object sender, EventArgs e) => ShowAndHideUC(AnaSayfaUC);

        private void btnSubMenuSonuclarim_Click(object sender, EventArgs e) => ShowAndHideUC(SonuclarimUC);

        private void btnSubMenuHesap_Click(object sender, EventArgs e) => ShowAndHideUC(HesapUC);

        private void btnSubMenuAyarlar_Click(object sender, EventArgs e) => ShowAndHideUC(AyarlarUC);

        private void btnSubMenuRaporlama_Click(object sender, EventArgs e) => ShowAndHideUC(RaporUC);
    }
}
