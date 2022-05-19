
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;

namespace SinavSistemi.Presentation
{
    partial class LoginUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panelMainLogin = new DevExpress.XtraEditors.PanelControl();
            this.beSifre = new DevExpress.XtraEditors.ButtonEdit();
            this.checkEditBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.tgGeceModu = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkKaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkSifremiUnuttum = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.beKullaniciAdi = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainLogin)).BeginInit();
            this.panelMainLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditBeniHatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgGeceModu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panelMainLogin
            // 
            this.panelMainLogin.Controls.Add(this.beSifre);
            this.panelMainLogin.Controls.Add(this.checkEditBeniHatirla);
            this.panelMainLogin.Controls.Add(this.svgImageBox1);
            this.panelMainLogin.Controls.Add(this.tgGeceModu);
            this.panelMainLogin.Controls.Add(this.btnGiris);
            this.panelMainLogin.Controls.Add(this.hyperlinkKaydol);
            this.panelMainLogin.Controls.Add(this.hyperlinkSifremiUnuttum);
            this.panelMainLogin.Controls.Add(this.beKullaniciAdi);
            this.panelMainLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainLogin.Location = new System.Drawing.Point(0, 0);
            this.panelMainLogin.Name = "panelMainLogin";
            this.panelMainLogin.Size = new System.Drawing.Size(733, 433);
            this.panelMainLogin.TabIndex = 0;
            // 
            // beSifre
            // 
            this.beSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.beSifre.EditValue = "";
            this.errorProvider.SetIconAlignment(this.beSifre, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.beSifre.Location = new System.Drawing.Point(169, 261);
            this.beSifre.Name = "beSifre";
            this.beSifre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.beSifre.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.beSifre.Properties.Appearance.Options.UseFont = true;
            this.beSifre.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beSifre.Properties.AppearanceFocused.Options.UseFont = true;
            this.beSifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            editorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            editorButtonImageOptions1.ImageUri.Uri = "Show";
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            editorButtonImageOptions1.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.security_visibilityoff;
            editorButtonImageOptions1.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            serializableAppearanceObject2.Options.UseFont = true;
            serializableAppearanceObject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            serializableAppearanceObject3.Options.UseFont = true;
            serializableAppearanceObject3.Options.UseTextOptions = true;
            serializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.beSifre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Şifreyi Göster", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beSifre.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.beSifre.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("beSifre.Properties.ContextImageOptions.SvgImage")));
            this.beSifre.Properties.ContextImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.beSifre.Properties.Mask.BeepOnError = true;
            this.beSifre.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.beSifre.Properties.MaxLength = 20;
            this.beSifre.Properties.NullText = "Şifreniz..";
            this.beSifre.Properties.NullValuePrompt = "Şifreniz...";
            this.beSifre.Properties.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.beSifre.Properties.PasswordChar = '*';
            this.beSifre.Properties.UseSystemPasswordChar = true;
            this.beSifre.Size = new System.Drawing.Size(395, 46);
            this.beSifre.TabIndex = 11;
            // 
            // checkEditBeniHatirla
            // 
            this.checkEditBeniHatirla.Location = new System.Drawing.Point(169, 326);
            this.checkEditBeniHatirla.Name = "checkEditBeniHatirla";
            this.checkEditBeniHatirla.Properties.AutoWidth = true;
            this.checkEditBeniHatirla.Properties.Caption = "Beni Hatirla";
            this.checkEditBeniHatirla.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.checkEditBeniHatirla.Properties.CheckBoxOptions.SvgColorChecked = System.Drawing.Color.Green;
            this.checkEditBeniHatirla.Properties.CheckBoxOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.checkEditBeniHatirla.Properties.HotTrackWhenReadOnly = false;
            this.checkEditBeniHatirla.Properties.ImageOptions.ImageIndexChecked = 1;
            this.checkEditBeniHatirla.Properties.ImageOptions.ImageIndexUnchecked = 0;
            this.checkEditBeniHatirla.Properties.ImageOptions.SvgImageChecked = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("checkEditBeniHatirla.Properties.ImageOptions.SvgImageChecked")));
            this.checkEditBeniHatirla.Properties.ImageOptions.SvgImageGrayed = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("checkEditBeniHatirla.Properties.ImageOptions.SvgImageGrayed")));
            this.checkEditBeniHatirla.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkEditBeniHatirla.Size = new System.Drawing.Size(97, 22);
            this.checkEditBeniHatirla.TabIndex = 17;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(309, 49);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(120, 120);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 16;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // tgGeceModu
            // 
            this.tgGeceModu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tgGeceModu.Location = new System.Drawing.Point(6, 10);
            this.tgGeceModu.Name = "tgGeceModu";
            this.tgGeceModu.Properties.GlyphVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tgGeceModu.Properties.OffText = "Gündüz";
            this.tgGeceModu.Properties.OnText = "Gece";
            this.tgGeceModu.Size = new System.Drawing.Size(120, 20);
            this.tgGeceModu.TabIndex = 15;
            this.tgGeceModu.ToolTip = "Gündüz / Gece Modu";
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGiris.AppearanceHovered.Options.UseFont = true;
            this.btnGiris.Enabled = false;
            this.btnGiris.ImageOptions.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.actions_arrow4right1;
            this.btnGiris.Location = new System.Drawing.Point(451, 337);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGiris.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnGiris.Size = new System.Drawing.Size(114, 43);
            this.btnGiris.TabIndex = 13;
            this.btnGiris.Text = "Giriş";
            // 
            // hyperlinkKaydol
            // 
            this.hyperlinkKaydol.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkKaydol.Appearance.Options.UseFont = true;
            this.hyperlinkKaydol.Location = new System.Drawing.Point(169, 398);
            this.hyperlinkKaydol.Name = "hyperlinkKaydol";
            this.hyperlinkKaydol.Size = new System.Drawing.Size(45, 18);
            this.hyperlinkKaydol.TabIndex = 14;
            this.hyperlinkKaydol.Text = "Kaydol";
            // 
            // hyperlinkSifremiUnuttum
            // 
            this.hyperlinkSifremiUnuttum.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkSifremiUnuttum.Appearance.Options.UseFont = true;
            this.hyperlinkSifremiUnuttum.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.hyperlinkSifremiUnuttum.Location = new System.Drawing.Point(31, 398);
            this.hyperlinkSifremiUnuttum.Name = "hyperlinkSifremiUnuttum";
            this.hyperlinkSifremiUnuttum.ShowLineShadow = false;
            this.hyperlinkSifremiUnuttum.Size = new System.Drawing.Size(106, 18);
            this.hyperlinkSifremiUnuttum.TabIndex = 12;
            this.hyperlinkSifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // beKullaniciAdi
            // 
            this.beKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.beKullaniciAdi.EditValue = "";
            this.beKullaniciAdi.Location = new System.Drawing.Point(169, 196);
            this.beKullaniciAdi.Name = "beKullaniciAdi";
            this.beKullaniciAdi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.beKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.beKullaniciAdi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.beKullaniciAdi.Properties.AppearanceFocused.Options.UseFont = true;
            this.beKullaniciAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.beKullaniciAdi.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.beKullaniciAdi.Properties.ContextImageOptions.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.bo_user;
            this.beKullaniciAdi.Properties.MaxLength = 20;
            this.beKullaniciAdi.Properties.NullText = "Kullanıcı Adınız...";
            this.beKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adınız...";
            this.beKullaniciAdi.Properties.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.beKullaniciAdi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.beKullaniciAdi.Size = new System.Drawing.Size(395, 46);
            this.beKullaniciAdi.TabIndex = 10;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 433);
            this.Controls.Add(this.panelMainLogin);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUI";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinav Sistemi - Giriş";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainLogin)).EndInit();
            this.panelMainLogin.ResumeLayout(false);
            this.panelMainLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditBeniHatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgGeceModu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private PanelControl panelMainLogin;
        protected internal ButtonEdit beSifre;
        private CheckEdit checkEditBeniHatirla;
        private SvgImageBox svgImageBox1;
        private ToggleSwitch tgGeceModu;
        protected internal SimpleButton btnGiris;
        protected internal HyperlinkLabelControl hyperlinkKaydol;
        protected internal HyperlinkLabelControl hyperlinkSifremiUnuttum;
        private ButtonEdit beKullaniciAdi;
    }
}