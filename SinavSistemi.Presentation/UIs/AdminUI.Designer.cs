
namespace SinavSistemi.Presentation
{
    partial class AdminUI
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnAnaliz = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSorular = new DevExpress.XtraEditors.SimpleButton();
            this.btnKullanicilar = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblMenu = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.analiz1 = new SinavSistemi.Presentation.AnalizUC();
            this.kullanicilar1 = new SinavSistemi.Presentation.KullanicilarUC();
            this.sorular1 = new SinavSistemi.Presentation.SorularUC();
            this.sidebar.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.btnAnaliz);
            this.sidebar.Controls.Add(this.btnCikis);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.btnKullanicilar);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(230, 670);
            this.sidebar.MinimumSize = new System.Drawing.Size(64, 670);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(230, 670);
            this.sidebar.TabIndex = 2;
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaliz.Appearance.Options.UseFont = true;
            this.btnAnaliz.Appearance.Options.UseTextOptions = true;
            this.btnAnaliz.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAnaliz.AppearancePressed.Options.UseTextOptions = true;
            this.btnAnaliz.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAnaliz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaliz.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.piestyledonut_32x32;
            this.btnAnaliz.Location = new System.Drawing.Point(2, 276);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnaliz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnaliz.Size = new System.Drawing.Size(226, 63);
            this.btnAnaliz.TabIndex = 38;
            this.btnAnaliz.Text = "      Analiz";
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click_1);
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
            this.btnCikis.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.cancel_32x321;
            this.btnCikis.Location = new System.Drawing.Point(-2, 345);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCikis.Size = new System.Drawing.Size(232, 63);
            this.btnCikis.TabIndex = 37;
            this.btnCikis.Text = "      Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSorular);
            this.panel5.Location = new System.Drawing.Point(-1, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 75);
            this.panel5.TabIndex = 36;
            // 
            // btnSorular
            // 
            this.btnSorular.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorular.Appearance.Options.UseFont = true;
            this.btnSorular.Appearance.Options.UseTextOptions = true;
            this.btnSorular.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSorular.AppearancePressed.Options.UseTextOptions = true;
            this.btnSorular.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSorular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorular.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.logical_32x32;
            this.btnSorular.Location = new System.Drawing.Point(3, 2);
            this.btnSorular.Name = "btnSorular";
            this.btnSorular.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSorular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSorular.Size = new System.Drawing.Size(226, 63);
            this.btnSorular.TabIndex = 0;
            this.btnSorular.Text = "      Sorular";
            this.btnSorular.Click += new System.EventHandler(this.btnSorular_Click_1);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullanicilar.Appearance.Options.UseFont = true;
            this.btnKullanicilar.Appearance.Options.UseTextOptions = true;
            this.btnKullanicilar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnKullanicilar.AppearancePressed.Options.UseTextOptions = true;
            this.btnKullanicilar.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnKullanicilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullanicilar.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.usergroup_32x321;
            this.btnKullanicilar.Location = new System.Drawing.Point(0, 138);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKullanicilar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKullanicilar.Size = new System.Drawing.Size(226, 63);
            this.btnKullanicilar.TabIndex = 35;
            this.btnKullanicilar.Text = "      Kullanıcılar";
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Controls.Add(this.lblMenu);
            this.panel3.Location = new System.Drawing.Point(-1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 136);
            this.panel3.TabIndex = 34;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::SinavSistemi.Presentation.Properties.Resources.chartgridlineshorizontal_minor;
            this.simpleButton1.Location = new System.Drawing.Point(4, 48);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 40);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // lblMenu
            // 
            this.lblMenu.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Appearance.Options.UseFont = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Location = new System.Drawing.Point(79, 58);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(42, 19);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.analiz1);
            this.panel1.Controls.Add(this.kullanicilar1);
            this.panel1.Controls.Add(this.sorular1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 670);
            this.panel1.TabIndex = 3;
            // 
            // analiz1
            // 
            this.analiz1.Location = new System.Drawing.Point(0, 0);
            this.analiz1.Name = "analiz1";
            this.analiz1.Size = new System.Drawing.Size(1119, 670);
            this.analiz1.TabIndex = 2;
            // 
            // kullanicilar1
            // 
            this.kullanicilar1.Location = new System.Drawing.Point(0, 1);
            this.kullanicilar1.Name = "kullanicilar1";
            this.kullanicilar1.Size = new System.Drawing.Size(1119, 670);
            this.kullanicilar1.TabIndex = 1;
            // 
            // sorular1
            // 
            this.sorular1.Location = new System.Drawing.Point(2, 0);
            this.sorular1.Name = "sorular1";
            this.sorular1.Size = new System.Drawing.Size(1119, 670);
            this.sorular1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.TopMost = true;
            this.sidebar.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel sidebar;
        private DevExpress.XtraEditors.SimpleButton btnAnaliz;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnSorular;
        private DevExpress.XtraEditors.SimpleButton btnKullanicilar;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblMenu;
        private System.Windows.Forms.Panel panel1;
        private AnalizUC analiz1;
        private KullanicilarUC kullanicilar1;
        private SorularUC sorular1;
    }
}