
using System;

namespace SinavSistemi.Presentation
{
    partial class UserUI : IDisposable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) => GC.SuppressFinalize(this);

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panelSubMenus = new System.Windows.Forms.Panel();
            this.btnSubMenuRaporlama = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubMenuAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubMenuHesap = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubMenuAyarlar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubMenuSonuclarim = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnMenu = new DevExpress.XtraEditors.SimpleButton();
            this.lblMenu = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRight = new DevExpress.XtraEditors.PanelControl();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panelSubMenus.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.panelSubMenus);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(229, 669);
            this.sidebar.MinimumSize = new System.Drawing.Size(67, 669);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(229, 669);
            this.sidebar.TabIndex = 0;
            // 
            // panelSubMenus
            // 
            this.panelSubMenus.Controls.Add(this.btnSubMenuRaporlama);
            this.panelSubMenus.Controls.Add(this.btnSubMenuAnaSayfa);
            this.panelSubMenus.Controls.Add(this.btnSubMenuHesap);
            this.panelSubMenus.Controls.Add(this.btnSubMenuAyarlar);
            this.panelSubMenus.Controls.Add(this.btnSubMenuSonuclarim);
            this.panelSubMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubMenus.Location = new System.Drawing.Point(0, 136);
            this.panelSubMenus.Name = "panelSubMenus";
            this.panelSubMenus.Size = new System.Drawing.Size(229, 458);
            this.panelSubMenus.TabIndex = 6;
            // 
            // btnSubMenuRaporlama
            // 
            this.btnSubMenuRaporlama.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuRaporlama.Appearance.Options.UseFont = true;
            this.btnSubMenuRaporlama.Appearance.Options.UseTextOptions = true;
            this.btnSubMenuRaporlama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSubMenuRaporlama.AppearancePressed.Options.UseTextOptions = true;
            this.btnSubMenuRaporlama.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSubMenuRaporlama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuRaporlama.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.showtestreport_32x32;
            this.btnSubMenuRaporlama.Location = new System.Drawing.Point(3, 213);
            this.btnSubMenuRaporlama.Name = "btnSubMenuRaporlama";
            this.btnSubMenuRaporlama.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenuRaporlama.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubMenuRaporlama.Size = new System.Drawing.Size(226, 63);
            this.btnSubMenuRaporlama.TabIndex = 0;
            this.btnSubMenuRaporlama.Tag = "RaporUC";
            this.btnSubMenuRaporlama.Text = "      Raporlama";
            this.btnSubMenuRaporlama.Click += new System.EventHandler(this.btnSubMenuRaporlama_Click);
            // 
            // btnSubMenuAnaSayfa
            // 
            this.btnSubMenuAnaSayfa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuAnaSayfa.Appearance.Options.UseFont = true;
            this.btnSubMenuAnaSayfa.Appearance.Options.UseTextOptions = true;
            this.btnSubMenuAnaSayfa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSubMenuAnaSayfa.AppearancePressed.Options.UseTextOptions = true;
            this.btnSubMenuAnaSayfa.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSubMenuAnaSayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuAnaSayfa.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.home_32x32;
            this.btnSubMenuAnaSayfa.Location = new System.Drawing.Point(3, 6);
            this.btnSubMenuAnaSayfa.Name = "btnSubMenuAnaSayfa";
            this.btnSubMenuAnaSayfa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenuAnaSayfa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubMenuAnaSayfa.Size = new System.Drawing.Size(226, 63);
            this.btnSubMenuAnaSayfa.TabIndex = 0;
            this.btnSubMenuAnaSayfa.Tag = "AnaSayfaUC";
            this.btnSubMenuAnaSayfa.Text = "      Ana Sayfa";
            this.btnSubMenuAnaSayfa.Click += new System.EventHandler(this.btnSubMenuAnaSayfa_Click);
            // 
            // btnSubMenuHesap
            // 
            this.btnSubMenuHesap.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuHesap.Appearance.Options.UseFont = true;
            this.btnSubMenuHesap.Appearance.Options.UseTextOptions = true;
            this.btnSubMenuHesap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSubMenuHesap.AppearancePressed.Options.UseTextOptions = true;
            this.btnSubMenuHesap.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSubMenuHesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuHesap.ImageOptions.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.bo_user;
            this.btnSubMenuHesap.Location = new System.Drawing.Point(3, 144);
            this.btnSubMenuHesap.Name = "btnSubMenuHesap";
            this.btnSubMenuHesap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenuHesap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubMenuHesap.Size = new System.Drawing.Size(226, 63);
            this.btnSubMenuHesap.TabIndex = 0;
            this.btnSubMenuHesap.Tag = "HesapUC";
            this.btnSubMenuHesap.Text = "    Hesap";
            this.btnSubMenuHesap.Click += new System.EventHandler(this.btnSubMenuHesap_Click);
            // 
            // btnSubMenuAyarlar
            // 
            this.btnSubMenuAyarlar.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuAyarlar.Appearance.Options.UseFont = true;
            this.btnSubMenuAyarlar.Appearance.Options.UseTextOptions = true;
            this.btnSubMenuAyarlar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSubMenuAyarlar.AppearancePressed.Options.UseTextOptions = true;
            this.btnSubMenuAyarlar.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSubMenuAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuAyarlar.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.technology_32x32;
            this.btnSubMenuAyarlar.Location = new System.Drawing.Point(-1, 282);
            this.btnSubMenuAyarlar.Name = "btnSubMenuAyarlar";
            this.btnSubMenuAyarlar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenuAyarlar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubMenuAyarlar.Size = new System.Drawing.Size(227, 63);
            this.btnSubMenuAyarlar.TabIndex = 0;
            this.btnSubMenuAyarlar.Tag = "AyarlarUC";
            this.btnSubMenuAyarlar.Text = "      Ayarlar";
            this.btnSubMenuAyarlar.Click += new System.EventHandler(this.btnSubMenuAyarlar_Click);
            // 
            // btnSubMenuSonuclarim
            // 
            this.btnSubMenuSonuclarim.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuSonuclarim.Appearance.Options.UseFont = true;
            this.btnSubMenuSonuclarim.Appearance.Options.UseTextOptions = true;
            this.btnSubMenuSonuclarim.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSubMenuSonuclarim.AppearancePressed.Options.UseTextOptions = true;
            this.btnSubMenuSonuclarim.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSubMenuSonuclarim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuSonuclarim.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.report_32x32;
            this.btnSubMenuSonuclarim.Location = new System.Drawing.Point(3, 75);
            this.btnSubMenuSonuclarim.Name = "btnSubMenuSonuclarim";
            this.btnSubMenuSonuclarim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenuSonuclarim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubMenuSonuclarim.Size = new System.Drawing.Size(226, 63);
            this.btnSubMenuSonuclarim.TabIndex = 0;
            this.btnSubMenuSonuclarim.Tag = "SonuclarimUC";
            this.btnSubMenuSonuclarim.Text = "      Sonuçlarım";
            this.btnSubMenuSonuclarim.Click += new System.EventHandler(this.btnSubMenuSonuclarim_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCikis);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 594);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 75);
            this.panel7.TabIndex = 4;
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.Appearance.Options.UseTextOptions = true;
            this.btnCikis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCikis.AppearancePressed.Options.UseTextOptions = true;
            this.btnCikis.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCikis.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.cancel_32x321;
            this.btnCikis.Location = new System.Drawing.Point(0, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCikis.Size = new System.Drawing.Size(229, 75);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "      Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toggleSwitch1);
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Controls.Add(this.lblMenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 136);
            this.panel3.TabIndex = 5;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(3, 3);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 20);
            this.toggleSwitch1.TabIndex = 6;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // btnMenu
            // 
            this.btnMenu.ImageOptions.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.alignjustify;
            this.btnMenu.Location = new System.Drawing.Point(11, 48);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(46, 40);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Appearance.Options.UseFont = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Location = new System.Drawing.Point(70, 58);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(42, 19);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelRight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 670);
            this.panel2.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1115, 670);
            this.panelRight.TabIndex = 0;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.sidebar.ResumeLayout(false);
            this.panelSubMenus.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private DevExpress.XtraEditors.SimpleButton btnSubMenuAnaSayfa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnSubMenuHesap;
        private DevExpress.XtraEditors.LabelControl lblMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private DevExpress.XtraEditors.SimpleButton btnMenu;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.SimpleButton btnSubMenuSonuclarim;
        private DevExpress.XtraEditors.SimpleButton btnSubMenuAyarlar;
        private DevExpress.XtraEditors.SimpleButton btnSubMenuRaporlama;
        private DevExpress.XtraEditors.PanelControl panelRight;
        private System.Windows.Forms.Panel panelSubMenus;
    }
}