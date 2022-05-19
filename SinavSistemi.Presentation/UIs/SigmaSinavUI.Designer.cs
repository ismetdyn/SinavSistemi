
namespace SinavSistemi.Presentation
{
    partial class SigmaSinavUI
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions13 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions14 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions15 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions16 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.toggleSwitchGeceModu = new DevExpress.XtraEditors.ToggleSwitch();
            this.panelUst = new DevExpress.XtraEditors.PanelControl();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.btnSinavBitir = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelCevaplar = new System.Windows.Forms.Panel();
            this.btnPnlCevapD = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnPnlCevapC = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnPnlCevapB = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnPnlCevapA = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.recSoru = new DevExpress.XtraRichEdit.RichEditControl();
            this.lSure = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchGeceModu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).BeginInit();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            this.panelCevaplar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleSwitchGeceModu
            // 
            this.toggleSwitchGeceModu.Dock = System.Windows.Forms.DockStyle.Left;
            this.toggleSwitchGeceModu.Location = new System.Drawing.Point(7, 12);
            this.toggleSwitchGeceModu.Name = "toggleSwitchGeceModu";
            this.toggleSwitchGeceModu.Properties.OffText = "Off";
            this.toggleSwitchGeceModu.Properties.OnText = "On";
            this.toggleSwitchGeceModu.Size = new System.Drawing.Size(109, 40);
            this.toggleSwitchGeceModu.TabIndex = 2;
            this.toggleSwitchGeceModu.Toggled += new System.EventHandler(this.toggleSwitchGeceModu_Toggled);
            // 
            // panelUst
            // 
            this.panelUst.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelUst.Appearance.Options.UseBackColor = true;
            this.panelUst.Controls.Add(this.lSure);
            this.panelUst.Controls.Add(this.toggleSwitchGeceModu);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Padding = new System.Windows.Forms.Padding(5, 10, 20, 0);
            this.panelUst.Size = new System.Drawing.Size(995, 54);
            this.panelUst.TabIndex = 6;
            // 
            // panel
            // 
            this.panel.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.panel.Appearance.Options.UseBackColor = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.btnSinavBitir);
            this.panel.Controls.Add(this.btnPrevious);
            this.panel.Controls.Add(this.btnNext);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 872);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(995, 82);
            this.panel.TabIndex = 7;
            // 
            // btnSinavBitir
            // 
            this.btnSinavBitir.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnSinavBitir.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavBitir.Appearance.Options.UseBackColor = true;
            this.btnSinavBitir.Appearance.Options.UseFont = true;
            this.btnSinavBitir.Location = new System.Drawing.Point(393, 2);
            this.btnSinavBitir.MaximumSize = new System.Drawing.Size(165, 80);
            this.btnSinavBitir.Name = "btnSinavBitir";
            this.btnSinavBitir.Size = new System.Drawing.Size(165, 80);
            this.btnSinavBitir.TabIndex = 6;
            this.btnSinavBitir.Text = "Sınavı Bitir";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnPrevious.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevious.Appearance.Options.UseBackColor = true;
            this.btnPrevious.Appearance.Options.UseFont = true;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.doublefirst_32x321;
            this.btnPrevious.Location = new System.Drawing.Point(2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(158, 78);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Önceki";
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.doublelast_32x321;
            this.btnNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(801, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(192, 78);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Sonraki";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // panelCevaplar
            // 
            this.panelCevaplar.Controls.Add(this.btnPnlCevapD);
            this.panelCevaplar.Controls.Add(this.btnPnlCevapC);
            this.panelCevaplar.Controls.Add(this.btnPnlCevapB);
            this.panelCevaplar.Controls.Add(this.btnPnlCevapA);
            this.panelCevaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCevaplar.Location = new System.Drawing.Point(0, 773);
            this.panelCevaplar.Name = "panelCevaplar";
            this.panelCevaplar.Size = new System.Drawing.Size(995, 99);
            this.panelCevaplar.TabIndex = 19;
            // 
            // btnPnlCevapD
            // 
            this.btnPnlCevapD.AllowGlyphSkinning = false;
            this.btnPnlCevapD.BackColor = System.Drawing.Color.Transparent;
            this.btnPnlCevapD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPnlCevapD.ButtonInterval = 0;
            windowsUIButtonImageOptions13.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.bo_validation1;
            this.btnPnlCevapD.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("D", true, windowsUIButtonImageOptions13, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, true, null, false, false, true, "D", 3, false)});
            this.btnPnlCevapD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPnlCevapD.EnableImageTransparency = true;
            this.btnPnlCevapD.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPnlCevapD.ForeColor = System.Drawing.Color.Black;
            this.btnPnlCevapD.Location = new System.Drawing.Point(599, 6);
            this.btnPnlCevapD.Name = "btnPnlCevapD";
            this.btnPnlCevapD.PeekFormOptions.ShowOnItemHover = true;
            this.btnPnlCevapD.Size = new System.Drawing.Size(97, 86);
            this.btnPnlCevapD.TabIndex = 3;
            this.btnPnlCevapD.Text = "Dogru Cevap";
            // 
            // btnPnlCevapC
            // 
            this.btnPnlCevapC.AllowGlyphSkinning = false;
            this.btnPnlCevapC.BackColor = System.Drawing.Color.Transparent;
            this.btnPnlCevapC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPnlCevapC.ButtonInterval = 0;
            windowsUIButtonImageOptions14.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.bo_validation1;
            this.btnPnlCevapC.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("C", true, windowsUIButtonImageOptions14, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, true, null, false, false, true, "C", 2, false)});
            this.btnPnlCevapC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPnlCevapC.EnableImageTransparency = true;
            this.btnPnlCevapC.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPnlCevapC.ForeColor = System.Drawing.Color.Black;
            this.btnPnlCevapC.Location = new System.Drawing.Point(477, 6);
            this.btnPnlCevapC.Name = "btnPnlCevapC";
            this.btnPnlCevapC.PeekFormOptions.ShowOnItemHover = true;
            this.btnPnlCevapC.Size = new System.Drawing.Size(97, 86);
            this.btnPnlCevapC.TabIndex = 2;
            // 
            // btnPnlCevapB
            // 
            this.btnPnlCevapB.AllowGlyphSkinning = false;
            this.btnPnlCevapB.BackColor = System.Drawing.Color.Transparent;
            this.btnPnlCevapB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPnlCevapB.ButtonInterval = 0;
            windowsUIButtonImageOptions15.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.bo_validation1;
            this.btnPnlCevapB.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("B", true, windowsUIButtonImageOptions15, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, true, null, false, false, true, "B", 1, false)});
            this.btnPnlCevapB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPnlCevapB.EnableImageTransparency = true;
            this.btnPnlCevapB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPnlCevapB.ForeColor = System.Drawing.Color.Black;
            this.btnPnlCevapB.Location = new System.Drawing.Point(359, 3);
            this.btnPnlCevapB.Name = "btnPnlCevapB";
            this.btnPnlCevapB.PeekFormOptions.ShowOnItemHover = true;
            this.btnPnlCevapB.Size = new System.Drawing.Size(97, 86);
            this.btnPnlCevapB.TabIndex = 1;
            // 
            // btnPnlCevapA
            // 
            this.btnPnlCevapA.AllowGlyphSkinning = false;
            this.btnPnlCevapA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPnlCevapA.BackColor = System.Drawing.Color.Transparent;
            this.btnPnlCevapA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPnlCevapA.ButtonInterval = 0;
            windowsUIButtonImageOptions16.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.bo_validation1;
            this.btnPnlCevapA.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("A", true, windowsUIButtonImageOptions16, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, true, null, false, false, true, "A", 0, false)});
            this.btnPnlCevapA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPnlCevapA.EnableImageTransparency = true;
            this.btnPnlCevapA.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPnlCevapA.ForeColor = System.Drawing.Color.Black;
            this.btnPnlCevapA.Location = new System.Drawing.Point(230, 3);
            this.btnPnlCevapA.Name = "btnPnlCevapA";
            this.btnPnlCevapA.PeekFormOptions.ShowOnItemHover = true;
            this.btnPnlCevapA.Size = new System.Drawing.Size(97, 86);
            this.btnPnlCevapA.TabIndex = 0;
            // 
            // recSoru
            // 
            this.recSoru.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recSoru.Appearance.Text.Options.UseTextOptions = true;
            this.recSoru.Appearance.Text.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.recSoru.Appearance.Text.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.recSoru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recSoru.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.recSoru.Location = new System.Drawing.Point(0, 54);
            this.recSoru.Name = "recSoru";
            this.recSoru.Options.Behavior.Copy = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.recSoru.Options.Behavior.OfficeScrolling = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.recSoru.Options.Behavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.recSoru.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Visible;
            this.recSoru.Options.Layout.SimpleView.ResizeTablesToFitContent = true;
            this.recSoru.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Visible;
            this.recSoru.ReadOnly = true;
            this.recSoru.Size = new System.Drawing.Size(995, 719);
            this.recSoru.TabIndex = 20;
            this.recSoru.Views.SimpleView.AdjustColorsToSkins = true;
            this.recSoru.RtfTextChanged += new System.EventHandler(this.recSoru_RtfTextChanged);
            // 
            // lSure
            // 
            this.lSure.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSure.Appearance.Options.UseFont = true;
            this.lSure.Location = new System.Drawing.Point(867, 15);
            this.lSure.Name = "lSure";
            this.lSure.Size = new System.Drawing.Size(78, 25);
            this.lSure.TabIndex = 3;
            this.lSure.Text = "00:00:00";
            // 
            // SigmaSinavUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(995, 954);
            this.Controls.Add(this.recSoru);
            this.Controls.Add(this.panelCevaplar);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelUst);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableAcrylicAccent = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.doctor;
            this.MinimizeBox = false;
            this.Name = "SigmaSinavUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigmaSinav";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchGeceModu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).EndInit();
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panelCevaplar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchGeceModu;
        private DevExpress.XtraEditors.PanelControl panel;
        protected internal DevExpress.XtraEditors.SimpleButton btnNext;
        protected internal DevExpress.XtraEditors.SimpleButton btnPrevious;
        protected internal System.Windows.Forms.Timer timer1;
        protected internal DevExpress.XtraEditors.PanelControl panelUst;
        protected internal DevExpress.XtraEditors.SimpleButton btnSinavBitir;
        protected internal DevExpress.XtraRichEdit.RichEditControl recSoru;
        protected internal DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPnlCevapD;
        protected internal DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPnlCevapC;
        protected internal DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPnlCevapB;
        protected internal DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnPnlCevapA;
        protected internal DevExpress.XtraEditors.LabelControl lSure;
        protected internal System.Windows.Forms.Panel panelCevaplar;
    }
}