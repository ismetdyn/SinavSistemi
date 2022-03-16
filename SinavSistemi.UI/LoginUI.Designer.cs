
namespace SinavSistemi.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.hyperlinkSifremiUnuttum = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkKaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitchGeceModu = new DevExpress.XtraEditors.ToggleSwitch();
            this.tbKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.checkEditBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.buttonEditSifre = new DevExpress.XtraEditors.ButtonEdit();
            this.svgImageExit = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchGeceModu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditBeniHatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hyperlinkSifremiUnuttum
            // 
            this.hyperlinkSifremiUnuttum.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkSifremiUnuttum.Appearance.Options.UseFont = true;
            this.hyperlinkSifremiUnuttum.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.hyperlinkSifremiUnuttum.Location = new System.Drawing.Point(37, 386);
            this.hyperlinkSifremiUnuttum.Name = "hyperlinkSifremiUnuttum";
            this.hyperlinkSifremiUnuttum.ShowLineShadow = false;
            this.hyperlinkSifremiUnuttum.Size = new System.Drawing.Size(106, 18);
            this.hyperlinkSifremiUnuttum.TabIndex = 2;
            this.hyperlinkSifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // hyperlinkKaydol
            // 
            this.hyperlinkKaydol.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkKaydol.Appearance.Options.UseFont = true;
            this.hyperlinkKaydol.Location = new System.Drawing.Point(175, 386);
            this.hyperlinkKaydol.Name = "hyperlinkKaydol";
            this.hyperlinkKaydol.Size = new System.Drawing.Size(45, 18);
            this.hyperlinkKaydol.TabIndex = 3;
            this.hyperlinkKaydol.Text = "Kaydol";
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGonder.AppearanceHovered.Options.UseFont = true;
            this.btnGonder.ImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources.actions_arrow4right1;
            this.btnGonder.Location = new System.Drawing.Point(457, 325);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGonder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnGonder.Size = new System.Drawing.Size(114, 43);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Giriş";
            // 
            // toggleSwitchGeceModu
            // 
            this.toggleSwitchGeceModu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSwitchGeceModu.Location = new System.Drawing.Point(530, 8);
            this.toggleSwitchGeceModu.Name = "toggleSwitchGeceModu";
            this.toggleSwitchGeceModu.Properties.GlyphVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.toggleSwitchGeceModu.Properties.OffText = "Gündüz";
            this.toggleSwitchGeceModu.Properties.OnText = "Gece";
            this.toggleSwitchGeceModu.Size = new System.Drawing.Size(120, 24);
            this.toggleSwitchGeceModu.TabIndex = 5;
            this.toggleSwitchGeceModu.ToolTip = "Gündüz / Gece Modu";
            this.toggleSwitchGeceModu.Toggled += new System.EventHandler(this.toggleSwitchGeceModu_Toggled);
            // 
            // tbKullaniciAdi
            // 
            this.behaviorManager1.SetBehaviors(this.tbKullaniciAdi, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Large, null, null)))});
            this.tbKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbKullaniciAdi.EditValue = "";
            this.tbKullaniciAdi.EnterMoveNextControl = true;
            this.tbKullaniciAdi.Location = new System.Drawing.Point(175, 184);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.tbKullaniciAdi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbKullaniciAdi.Properties.AppearanceFocused.Options.UseFont = true;
            this.tbKullaniciAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbKullaniciAdi.Properties.ContextImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources.bo_user;
            this.tbKullaniciAdi.Properties.MaxLength = 20;
            this.tbKullaniciAdi.Properties.NullText = "Kullanıcı Adınız...";
            this.tbKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adınız...";
            this.tbKullaniciAdi.Properties.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tbKullaniciAdi.Size = new System.Drawing.Size(395, 46);
            this.tbKullaniciAdi.TabIndex = 0;
            // 
            // checkEditBeniHatirla
            // 
            this.checkEditBeniHatirla.Location = new System.Drawing.Point(175, 314);
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
            this.checkEditBeniHatirla.TabIndex = 9;
            // 
            // buttonEditSifre
            // 
            this.buttonEditSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEditSifre.Location = new System.Drawing.Point(175, 249);
            this.buttonEditSifre.Name = "buttonEditSifre";
            this.buttonEditSifre.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.buttonEditSifre.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEditSifre.Properties.Appearance.Options.UseFont = true;
            this.buttonEditSifre.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEditSifre.Properties.AppearanceFocused.Options.UseFont = true;
            this.buttonEditSifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            editorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            editorButtonImageOptions1.ImageUri.Uri = "Show";
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            editorButtonImageOptions1.SvgImage = global::SinavSistemi.UI.Properties.Resources.security_visibilityoff;
            editorButtonImageOptions1.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            serializableAppearanceObject2.Options.UseFont = true;
            serializableAppearanceObject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            serializableAppearanceObject3.Options.UseFont = true;
            serializableAppearanceObject3.Options.UseTextOptions = true;
            serializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.buttonEditSifre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Şifreyi Göster", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEditSifre.Properties.ContextImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources._private;
            this.buttonEditSifre.Properties.ContextImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.buttonEditSifre.Properties.Mask.BeepOnError = true;
            this.buttonEditSifre.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.buttonEditSifre.Properties.MaxLength = 20;
            this.buttonEditSifre.Properties.NullText = "Şifreniz..";
            this.buttonEditSifre.Properties.NullValuePrompt = "Şifreniz...";
            this.buttonEditSifre.Properties.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.buttonEditSifre.Properties.PasswordChar = '*';
            this.buttonEditSifre.Properties.UseSystemPasswordChar = true;
            this.buttonEditSifre.Size = new System.Drawing.Size(395, 50);
            this.buttonEditSifre.TabIndex = 1;
            this.buttonEditSifre.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditSifre_ButtonClick);
            this.buttonEditSifre.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditSifre_ButtonPressed);
            // 
            // svgImageExit
            // 
            this.svgImageExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.svgImageExit.Location = new System.Drawing.Point(677, 12);
            this.svgImageExit.Margin = new System.Windows.Forms.Padding(0);
            this.svgImageExit.Name = "svgImageExit";
            this.svgImageExit.Size = new System.Drawing.Size(45, 39);
            this.svgImageExit.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageExit.SvgImage")));
            this.svgImageExit.TabIndex = 8;
            this.svgImageExit.Text = "svgImageBox2";
            this.svgImageExit.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.svgImageExit.Click += new System.EventHandler(this.svgImageExit_Click);
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(315, 37);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(120, 120);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 6;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 433);
            this.Controls.Add(this.buttonEditSifre);
            this.Controls.Add(this.checkEditBeniHatirla);
            this.Controls.Add(this.svgImageExit);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.toggleSwitchGeceModu);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.hyperlinkKaydol);
            this.Controls.Add(this.hyperlinkSifremiUnuttum);
            this.Controls.Add(this.tbKullaniciAdi);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUI";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinav Sistemi";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchGeceModu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditBeniHatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkSifremiUnuttum;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkKaydol;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchGeceModu;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SvgImageBox svgImageExit;
        private DevExpress.XtraEditors.TextEdit tbKullaniciAdi;
        private DevExpress.XtraEditors.CheckEdit checkEditBeniHatirla;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.ButtonEdit buttonEditSifre;
    }
}