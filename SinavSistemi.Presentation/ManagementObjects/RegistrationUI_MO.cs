using SinavSistemi.Presentation.UIs;
using SinavSistemi.Common;
using System.Windows.Forms;
using SinavSistemi.Entity;
using SinavSistemi.BusinessLayer;
using System;

namespace SinavSistemi.Presentation.ManagementObjects
{
    public class RegistrationUI_MO : Base_MO<RegistrationUI_MO, RegistrationUI>
    {
        public RegistrationUI UI { get; set; }
        protected internal DynamicDataTransferObject ddto;
        Kullanici kullanici;
        int num;
        public RegistrationUI_MO()
        {
            Program.kullanici = null;
            UI = new RegistrationUI();
            UI.btnKaydol.Click += BtnKaydol_Click;
            UI.btnKodOnayla.Click += BtnKodOnayla_Click;
            UI.FormClosed += UI_FormClosed;
            UI.Show();
        }

        void FillDDTO() => ddto = UI.FillDDTO();

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.kullanici == null) Application.Exit();
        }

        private void BtnKaydol_Click(object sender, System.EventArgs e)
        {
            FillDDTO();
            Result<int> result = KullaniciBL.Current.PreRegistration(ddto);
            if (!result.IsSuccess) MessageBox.Show(result.Message);
            else
            {
                num = result.Data;
                ddto["KullaniciTipID"] = 1;
                kullanici = KullaniciBL.Current.
                    KullaniciOlustur(ddto).Data;
                UI.UIResize();
            }
        }

        private void BtnKodOnayla_Click(object sender, System.EventArgs e)
        {
            FillDDTO();
            if((string)ddto["Kod"] == null || num != Convert.ToInt32((string)ddto["Kod"]))
                MessageBox.Show("Kod Boş veya Hatalı", "Kod Hatalı!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Result<Kullanici> result = KullaniciBL.Current.InsertAndGetUser(kullanici);
                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                else
                {
                    kullanici = result.Data;
                    Program.kullanici = kullanici.DeepCopy();
                    UI.Close();
                    UI.Dispose();
                    InitializeForm.Current.Islem<UserUI_MO, UserUI>();
                    this.Dispose();
                }
            }
        }
    }
}
