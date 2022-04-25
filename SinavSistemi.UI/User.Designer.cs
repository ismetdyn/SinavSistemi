
namespace SinavSistemi.UI
{
    partial class User
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblMenu = new DevExpress.XtraEditors.LabelControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHesap = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSonuc = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hesap1 = new SinavSistemi.UI.Hesap();
            this.sonuclarim1 = new SinavSistemi.UI.Sonuclarim();
            this.anaSayfa1 = new SinavSistemi.UI.AnaSayfa();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.kullanıcıKayıtlar1 = new SinavSistemi.UI.KullanıcıKayıtlar();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.toggleSwitch1);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(229, 669);
            this.sidebar.MinimumSize = new System.Drawing.Size(67, 669);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(229, 669);
            this.sidebar.TabIndex = 0;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(4, 646);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 22);
            this.toggleSwitch1.TabIndex = 6;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCikis);
            this.panel7.Location = new System.Drawing.Point(3, 376);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 75);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
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
            this.btnCikis.ImageOptions.Image = global::SinavSistemi.UI.Properties.Resources.cancel_32x321;
            this.btnCikis.Location = new System.Drawing.Point(0, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCikis.Size = new System.Drawing.Size(226, 63);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "      Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Controls.Add(this.lblMenu);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 136);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources.chartgridlineshorizontal_minor;
            this.simpleButton1.Location = new System.Drawing.Point(2, 48);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 40);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHesap);
            this.panel6.Location = new System.Drawing.Point(3, 298);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 75);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnHesap
            // 
            this.btnHesap.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesap.Appearance.Options.UseFont = true;
            this.btnHesap.Appearance.Options.UseTextOptions = true;
            this.btnHesap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnHesap.AppearancePressed.Options.UseTextOptions = true;
            this.btnHesap.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnHesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesap.ImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources.bo_mydetails;
            this.btnHesap.Location = new System.Drawing.Point(0, 3);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHesap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHesap.Size = new System.Drawing.Size(226, 63);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.Text = "    Hesap";
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAnaSayfa);
            this.panel4.Location = new System.Drawing.Point(0, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 75);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfa.Appearance.Options.UseFont = true;
            this.btnAnaSayfa.Appearance.Options.UseTextOptions = true;
            this.btnAnaSayfa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAnaSayfa.AppearancePressed.Options.UseTextOptions = true;
            this.btnAnaSayfa.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAnaSayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaSayfa.ImageOptions.Image = global::SinavSistemi.UI.Properties.Resources.home_32x32;
            this.btnAnaSayfa.Location = new System.Drawing.Point(0, 3);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnaSayfa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnaSayfa.Size = new System.Drawing.Size(226, 63);
            this.btnAnaSayfa.TabIndex = 0;
            this.btnAnaSayfa.Text = "      Ana Sayfa";
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSonuc);
            this.panel5.Location = new System.Drawing.Point(1, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 75);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSonuc.Appearance.Options.UseFont = true;
            this.btnSonuc.Appearance.Options.UseTextOptions = true;
            this.btnSonuc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSonuc.AppearancePressed.Options.UseTextOptions = true;
            this.btnSonuc.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSonuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonuc.ImageOptions.Image = global::SinavSistemi.UI.Properties.Resources.report_32x32;
            this.btnSonuc.Location = new System.Drawing.Point(0, 3);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSonuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSonuc.Size = new System.Drawing.Size(226, 63);
            this.btnSonuc.TabIndex = 0;
            this.btnSonuc.Text = "      Sonuçlarım";
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kullanıcıKayıtlar1);
            this.panel2.Controls.Add(this.hesap1);
            this.panel2.Controls.Add(this.sonuclarim1);
            this.panel2.Controls.Add(this.anaSayfa1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 670);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // hesap1
            // 
            this.hesap1.BackColor = System.Drawing.SystemColors.Control;
            this.hesap1.Location = new System.Drawing.Point(0, 90);
            this.hesap1.Name = "hesap1";
            this.hesap1.Size = new System.Drawing.Size(944, 579);
            this.hesap1.TabIndex = 4;
            this.hesap1.Load += new System.EventHandler(this.hesap1_Load);
            // 
            // sonuclarim1
            // 
            this.sonuclarim1.Location = new System.Drawing.Point(0, 90);
            this.sonuclarim1.Name = "sonuclarim1";
            this.sonuclarim1.Size = new System.Drawing.Size(998, 577);
            this.sonuclarim1.TabIndex = 1;
            this.sonuclarim1.Load += new System.EventHandler(this.sonuclarim1_Load);
            // 
            // anaSayfa1
            // 
            this.anaSayfa1.Location = new System.Drawing.Point(0, 48);
            this.anaSayfa1.Name = "anaSayfa1";
            this.anaSayfa1.Size = new System.Drawing.Size(1025, 619);
            this.anaSayfa1.TabIndex = 0;
            this.anaSayfa1.Load += new System.EventHandler(this.anaSayfa1_Load);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // kullanıcıKayıtlar1
            // 
            this.kullanıcıKayıtlar1.Location = new System.Drawing.Point(336, 156);
            this.kullanıcıKayıtlar1.Name = "kullanıcıKayıtlar1";
            this.kullanıcıKayıtlar1.Size = new System.Drawing.Size(927, 636);
            this.kullanıcıKayıtlar1.TabIndex = 5;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private DevExpress.XtraEditors.SimpleButton btnAnaSayfa;
        private System.Windows.Forms.Panel panel2;
        private Sonuclarim sonuclarim1;
        private AnaSayfa anaSayfa1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.SimpleButton btnHesap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Hesap hesap1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.SimpleButton btnSonuc;
        private KullanıcıKayıtlar kullanıcıKayıtlar1;
    }
}