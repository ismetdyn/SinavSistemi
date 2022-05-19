using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using SinavSistemi.Common;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SinavSistemi.Presentation.UIs
{
    public partial class RegistrationUI : XtraForm
    {
        bool resize = true;
        DynamicDataTransferObject ddto;
        public RegistrationUI()
        {
            ddto = new DynamicDataTransferObject();
            InitializeComponent();
            timer1.Interval = 1;
        }

        private void RegistrationUI_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            WindowsFormsSettings.UseAdvancedFilterEditorControl = DevExpress.Utils.DefaultBoolean.True;
            tgTema.Toggled += new EventHandler(Toggled);
            beSifre.ButtonPressed += new ButtonPressedEventHandler(ButtonPressed);
            beSifre.ButtonClick += new ButtonPressedEventHandler(ButtonClick);
            beSifre.Validating += new CancelEventHandler(Validate);
            beSifre.TextChanged += new EventHandler(Validate);
            beSifreTekrar.ButtonPressed += new ButtonPressedEventHandler(ButtonPressed);
            beSifreTekrar.ButtonClick += new ButtonPressedEventHandler(ButtonClick);
            beSifreTekrar.Validating += new CancelEventHandler(Validate);
            beSifreTekrar.TextChanged += new EventHandler(Validate);
            beCode.ButtonPressed += new ButtonPressedEventHandler(ButtonPressed);
            beCode.ButtonClick += new ButtonPressedEventHandler(ButtonClick);
            beCode.Validating += new CancelEventHandler(Validate);
            beCode.TextChanged += new EventHandler(Validate);
            beKullaniciAdi.Validating += new CancelEventHandler(Validate);
            beKullaniciAdi.TextChanged += new EventHandler(Validate);
            bePosta.Validating += new CancelEventHandler(Validate);
            bePosta.TextChanged += new EventHandler(Validate);
            bePostaTekrar.Validating += new CancelEventHandler(Validate);
            bePostaTekrar.TextChanged += new EventHandler(Validate);
            beAd.Validating += new CancelEventHandler(Validate);
            beAd.TextChanged += new EventHandler(Validate);
            beSoyad.Validating += new CancelEventHandler(Validate);
            beSoyad.TextChanged += new EventHandler(Validate);
            btnKaydol.Enabled = false;
        }

        protected internal DynamicDataTransferObject FillDDTO()
        {
            ddto["KullaniciAdi"] = beKullaniciAdi.Text;
            ddto["Ad"] = beAd.Text;
            ddto["Soyad"] = beSoyad.Text;
            ddto["Eposta"] = bePosta.Text;
            ddto["EpostaTekrar"] = bePostaTekrar.Text;
            ddto["Sifre"] = beSifre.Text;
            ddto["SifreTekrar"] = beSifreTekrar.Text;
            ddto["Kod"] = beCode.Text;
            return ddto;
        }

        private void Toggled(object sender, EventArgs e)
        {
            if (((ToggleSwitch)sender).IsOn) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
        }

        void ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            ((ButtonEdit)sender).Properties.PasswordChar = '\0';
            ((ButtonEdit)sender).Properties.UseSystemPasswordChar = false;
            ((ButtonEdit)sender).Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibility;
            ((ButtonEdit)sender).Properties.ButtonsStyle = BorderStyles.UltraFlat;
        }

        void ButtonClick(object sender, EventArgs e)
        {
            ((ButtonEdit)sender).Properties.PasswordChar = '*';
            ((ButtonEdit)sender).Properties.UseSystemPasswordChar = true;
            ((ButtonEdit)sender).Properties.Buttons[0].ImageOptions.SvgImage = Properties.Resources.security_visibilityoff;
            ((ButtonEdit)sender).Properties.ButtonsStyle = BorderStyles.NoBorder;
        }

        void Validate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((ButtonEdit)sender).Text))
            {
                errorProvider.SetError(((ButtonEdit)sender), "Alan boş olamaz", ErrorType.Warning);
                errorProvider.SetIconAlignment(((ButtonEdit)sender), ErrorIconAlignment.MiddleRight);
                btnKaydol.Enabled = false;
            }
            else if (((ButtonEdit)sender).Text.Length < 3)
            {
                errorProvider.SetError(((ButtonEdit)sender), "Alan 3 karakterden küçük olamaz.", ErrorType.Warning);
                errorProvider.SetIconAlignment(((ButtonEdit)sender), ErrorIconAlignment.MiddleRight);
                btnKaydol.Enabled = false;
            }
            else
            {
                errorProvider.SetError(((ButtonEdit)sender), "");
                btnKaydol.Enabled = true;
            }
        }

        protected internal void UIResize()
        {
            panelReg.Enabled = false;
            panelReg.Visible = false;
            panelCode.Location = panelReg.Location;
            panelCode.Parent = panelControl1;
            panelReg.Dispose();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (resize)
            {
                this.Height -= 10;
                if (this.Height == this.MinimumSize.Height)
                {
                    resize = false;
                    timer1.Stop();
                    panelCode.Visible = true;
                    panelCode.Enabled = true;
                }
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
    }
}       