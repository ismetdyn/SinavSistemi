using System;
using System.Windows.Forms;
using SinavSistemi.BusinessLayer;
using SinavSistemi.Common;
using SinavSistemi.Entity;
using SinavSistemi.Presentation.UIs;
using Tulpep.NotificationWindow;

namespace SinavSistemi.Presentation.ManagementObjects
{
    public class LoginUI_MO : Base_MO<LoginUI_MO, LoginUI>
    {
        public LoginUI UI { get; set; }
        DynamicDataTransferObject ddto;

        public LoginUI_MO()
        {
            UI = new LoginUI();
            UI.btnGiris.Click += BtnGiris_Click;
            UI.hyperlinkSifremiUnuttum.Click += HyperlinkSifremiUnuttum_Click;
            UI.hyperlinkKaydol.Click += HyperlinkKaydol_Click;
            UI.FormClosed += UI_FormClosed;
            UI.Show();
        }

        void FillDDTO() => ddto = UI.FillDDTO();

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.kullanici == null) Application.Exit();
        }

        private void HyperlinkKaydol_Click(object sender, EventArgs e)
        {
            Program.kullanici = new Kullanici();
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<RegistrationUI_MO, RegistrationUI>();
            Dispose();
        }

        private void HyperlinkSifremiUnuttum_Click(object sender, EventArgs e)
        {
            Program.kullanici = new Kullanici();
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<FrgtPsswrdUI_MO, RegistrationUI>();
            Dispose();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FillDDTO();
            Result<Kullanici> result = KullaniciBL.Current.Giris(ddto);
            if (!result.IsSuccess) MessageBox.Show(result.Message);
            else
            {
                Program.kullanici = result.Data.DeepCopy();
                UI.Close();
                UI.Dispose();
                this.Dispose();
                switch (result.Data.KullaniciTipID)
                {
                    case 1:
                        InitializeForm.Current.Islem<AdminUI_MO, AdminUI>();
                        break;
                    case 2:
                        InitializeForm.Current.Islem<SoruEkleUI_MO, SoruEkleUI>();
                        break;
                    case 3:
                        InitializeForm.Current.Islem<UserUI_MO, UserUI>();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
