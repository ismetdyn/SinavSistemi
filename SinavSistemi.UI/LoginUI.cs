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
using DevExpress.XtraBars.Helpers;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using SinavSistemi.Entity;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using DevExpress.XtraEditors.DXErrorProvider;
//using FluentValidation;

namespace SinavSistemi.UI
{
    public partial class LoginUI : DevExpress.XtraEditors.XtraForm
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            WindowsFormsSettings.UseAdvancedFilterEditorControl = DevExpress.Utils.DefaultBoolean.True;
            //btnGonder.Enabled = false;
            
        }

        Kullanici Kullanici = new Kullanici();

        private void toggleSwitchGeceModu_Toggled(object sender, EventArgs e)
        {
            if(toggleSwitchGeceModu.IsOn)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            }else
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            }
        }

        private void beSifre_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beSifre.Properties.PasswordChar = '\0';
            beSifre.Properties.UseSystemPasswordChar = false;
            beSifre.Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibility;
            beSifre.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;

        }


        private void beSifre_Click(object sender, EventArgs e)
        {
            beSifre.Properties.PasswordChar = '*';
            beSifre.Properties.UseSystemPasswordChar = true;
            beSifre.Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibilityoff;
            beSifre.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }

       
        private void beSifre_Validating(object sender, CancelEventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(beSifre.Text))
            {
                //e.Cancel = true;
                //beSifre.Focus();
                epSifre.SetError(beSifre, "Şifre alanı boş olamaz", ErrorType.Warning);
                epSifre.SetIconAlignment(this.beSifre, ErrorIconAlignment.MiddleRight);
                btnGonder.Enabled = false;
            }
            else if (beSifre.Text.Length < 6)
            {
                //e.Cancel = true;
                //beSifre.Focus();
                epSifre.SetError(beSifre, "Şifre 6 karakterden küçük olamaz.", ErrorType.Warning);
                epSifre.SetIconAlignment(this.beSifre, ErrorIconAlignment.MiddleRight);
                btnGonder.Enabled = false;
            }
            else
            {
                //e.Cancel = false;
                epSifre.SetError(beSifre, "");
                btnGonder.Enabled = true;
            }
        
        }
        
        
        private void beSifre_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(beSifre.Text))
            {
                epSifre.SetError(beSifre, "Şifre alanı boş olamaz", ErrorType.Warning);
                epSifre.SetIconAlignment(this.beSifre, ErrorIconAlignment.MiddleRight);
                btnGonder.Enabled = false;
            }
            else if (beSifre.Text.Length < 6)
            {
                epSifre.SetError(beSifre, "Şifre 6 karakterden küçük olamaz.", ErrorType.Warning);
                epSifre.SetIconAlignment(this.beSifre, ErrorIconAlignment.MiddleRight);
                btnGonder.Enabled = false;
            }
            else
            {
                epSifre.SetError(beSifre, "");
                btnGonder.Enabled = true;
            }
            
        }

        private void beKullaniciAdi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(beKullaniciAdi.Text))
            {
                //e.Cancel = true;
                //beKullaniciAdi.Focus();
                epKullaniciAdi.SetError(beKullaniciAdi, "Kullanıcı adı boş olamaz", ErrorType.Warning);
                epKullaniciAdi.SetIconAlignment(this.beKullaniciAdi, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                //e.Cancel = false;
                epKullaniciAdi.SetError(beKullaniciAdi, "");
            }
        }

        private void beKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(beKullaniciAdi.Text))
            {
                epKullaniciAdi.SetError(beKullaniciAdi, "Kullanıcı adı boş olamaz", ErrorType.Warning);
                epKullaniciAdi.SetIconAlignment(this.beKullaniciAdi, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                epKullaniciAdi.SetError(beKullaniciAdi, "");
            }
            
        }
    }
}