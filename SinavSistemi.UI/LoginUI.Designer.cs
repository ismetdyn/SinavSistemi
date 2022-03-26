
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
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
            this.beKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.checkEditBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.beSifre = new DevExpress.XtraEditors.ButtonEdit();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.epKullaniciAdi = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.epSifre = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchGeceModu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditBeniHatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKullaniciAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
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
            this.toggleSwitchGeceModu.Location = new System.Drawing.Point(12, -2);
            this.toggleSwitchGeceModu.Name = "toggleSwitchGeceModu";
            this.toggleSwitchGeceModu.Properties.GlyphVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.toggleSwitchGeceModu.Properties.OffText = "Gündüz";
            this.toggleSwitchGeceModu.Properties.OnText = "Gece";
            this.toggleSwitchGeceModu.Size = new System.Drawing.Size(120, 20);
            this.toggleSwitchGeceModu.TabIndex = 5;
            this.toggleSwitchGeceModu.ToolTip = "Gündüz / Gece Modu";
            this.toggleSwitchGeceModu.Toggled += new System.EventHandler(this.toggleSwitchGeceModu_Toggled);
            // 
            // beKullaniciAdi
            // 
            this.behaviorManager1.SetBehaviors(this.beKullaniciAdi, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Large, null, null)))});
            this.beKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.beKullaniciAdi.EditValue = "";
            this.beKullaniciAdi.EnterMoveNextControl = true;
            this.beKullaniciAdi.Location = new System.Drawing.Point(175, 184);
            this.beKullaniciAdi.Name = "beKullaniciAdi";
            this.beKullaniciAdi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.beKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.beKullaniciAdi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.beKullaniciAdi.Properties.AppearanceFocused.Options.UseFont = true;
            this.beKullaniciAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.beKullaniciAdi.Properties.ContextImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources.bo_user;
            this.beKullaniciAdi.Properties.MaxLength = 20;
            this.beKullaniciAdi.Properties.NullText = "Kullanıcı Adınız...";
            this.beKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adınız...";
            this.beKullaniciAdi.Properties.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.beKullaniciAdi.Size = new System.Drawing.Size(395, 46);
            this.beKullaniciAdi.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "alan boş olmamalı.";
            this.dxValidationProvider1.SetValidationRule(this.beKullaniciAdi, conditionValidationRule1);
            this.beKullaniciAdi.TextChanged += new System.EventHandler(this.beKullaniciAdi_TextChanged);
            this.beKullaniciAdi.Validating += new System.ComponentModel.CancelEventHandler(this.beKullaniciAdi_Validating);
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
            // beSifre
            // 
            this.beSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.beSifre.Location = new System.Drawing.Point(175, 249);
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
            editorButtonImageOptions1.SvgImage = global::SinavSistemi.UI.Properties.Resources.security_visibilityoff;
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
            this.beSifre.Properties.ContextImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources._private;
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
            this.beSifre.TabIndex = 1;
            this.beSifre.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beSifre_ButtonPressed);
            this.beSifre.TextChanged += new System.EventHandler(this.beSifre_TextChanged);
            this.beSifre.Click += new System.EventHandler(this.beSifre_Click);
            this.beSifre.Validating += new System.ComponentModel.CancelEventHandler(this.beSifre_Validating);
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
            // epKullaniciAdi
            // 
            this.epKullaniciAdi.ContainerControl = this;
            // 
            // epSifre
            // 
            this.epSifre.ContainerControl = this;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 433);
            this.Controls.Add(this.beSifre);
            this.Controls.Add(this.checkEditBeniHatirla);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.toggleSwitchGeceModu);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.hyperlinkKaydol);
            this.Controls.Add(this.hyperlinkSifremiUnuttum);
            this.Controls.Add(this.beKullaniciAdi);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUI";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinav Sistemi";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchGeceModu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditBeniHatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKullaniciAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkSifremiUnuttum;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkKaydol;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchGeceModu;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.TextEdit beKullaniciAdi;
        private DevExpress.XtraEditors.CheckEdit checkEditBeniHatirla;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.ButtonEdit beSifre;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider epKullaniciAdi;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider epSifre;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}