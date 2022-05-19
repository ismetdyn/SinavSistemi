using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.DXErrorProvider;
using SinavSistemi.Common;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors.Controls;

namespace SinavSistemi.Presentation
{
    public partial class LoginUI : XtraForm
    {
        private DynamicDataTransferObject ddto;
        public LoginUI()
        {
            InitializeComponent();
            ddto = new DynamicDataTransferObject();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            WindowsFormsSettings.UseAdvancedFilterEditorControl = DevExpress.Utils.DefaultBoolean.True;
            btnGiris.Enabled = false;
            beSifre.ButtonPressed += new ButtonPressedEventHandler(ButtonPressed);
            beSifre.ButtonClick += new ButtonPressedEventHandler(ButtonClick);
            tgGeceModu.Toggled += new EventHandler(Toggled);
            beSifre.Validating += new CancelEventHandler(SetError);
            beKullaniciAdi.Validating += new CancelEventHandler(SetError);
            beSifre.TextChanged += new EventHandler(SetError);
            beKullaniciAdi.TextChanged += new EventHandler(SetError);
        }

        protected internal DynamicDataTransferObject FillDDTO()
        {
            ddto["KullaniciAdi"] = beKullaniciAdi.Text;
            ddto["Sifre"] = beSifre.Text;
            return ddto;
        }


        private void Toggled(object sender, EventArgs e)
        {
            if (((ToggleSwitch)sender).IsOn) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");   
        }

        private void ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            ((ButtonEdit)sender).Properties.PasswordChar = '\0';
            ((ButtonEdit)sender).Properties.UseSystemPasswordChar = false;
            ((ButtonEdit)sender).Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibility;
            ((ButtonEdit)sender).Properties.ButtonsStyle = BorderStyles.UltraFlat;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            ((ButtonEdit)sender).Properties.PasswordChar = '*';
            ((ButtonEdit)sender).Properties.UseSystemPasswordChar = true;
            ((ButtonEdit)sender).Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibilityoff;
            ((ButtonEdit)sender).Properties.ButtonsStyle = BorderStyles.NoBorder;
        }


        void SetError(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((ButtonEdit)sender).Text))
            {
                errorProvider.SetError(((ButtonEdit)sender), "Alan boş olamaz", ErrorType.Warning);
                errorProvider.SetIconAlignment(((ButtonEdit)sender), ErrorIconAlignment.MiddleRight);
                btnGiris.Enabled = false;
            }
            else if (((ButtonEdit)sender).Text.Length < 3)
            {
                errorProvider.SetError(((ButtonEdit)sender), "3 karakterden küçük olamaz.", ErrorType.Warning);
                errorProvider.SetIconAlignment(((ButtonEdit)sender), ErrorIconAlignment.MiddleRight);
                btnGiris.Enabled = false;
            }
            else
            {
                errorProvider.SetError(((ButtonEdit)sender), "");
                btnGiris.Enabled = true;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateRegion();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            Region prevRgn = Region;
            Region = new Region(CreateFormRegion(8));
            if (prevRgn != null)
                prevRgn.Dispose();
        }

        public GraphicsPath CreateFormRegion(int cornerRadius)
        {
            GraphicsPath GrpRect = new GraphicsPath();
            int width = Width + 1;
            int height = Height + 1;
            GrpRect.AddArc(new Rectangle(0, 0, cornerRadius * 5, cornerRadius * 5), 180f, 90f);//left-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 5) - 1, 0, cornerRadius * 5, cornerRadius * 5), -90f, 90f);//right-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 5) - 1, (height - cornerRadius * 5) - 1, cornerRadius * 5, cornerRadius * 5), 0f, 90f);//right-bottom
            GrpRect.AddArc(new Rectangle(0, (height - cornerRadius * 5) - 1, cornerRadius * 5, cornerRadius * 5), 90f, 90f);//left-bottom
            GrpRect.CloseAllFigures();
            return GrpRect;
        }

        public new void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}