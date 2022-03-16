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
            
        }

        Kullanici Kullanici = new Kullanici();

        private void svgImageExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

                

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void buttonEditSifre_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            buttonEditSifre.Properties.PasswordChar = '\0';
            buttonEditSifre.Properties.UseSystemPasswordChar = false;
            buttonEditSifre.Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibility;
            buttonEditSifre.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;

        }

        private void buttonEditSifre_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            buttonEditSifre.Properties.PasswordChar = '*';
            buttonEditSifre.Properties.UseSystemPasswordChar = true;
            buttonEditSifre.Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibilityoff;
            buttonEditSifre.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }
    }
}