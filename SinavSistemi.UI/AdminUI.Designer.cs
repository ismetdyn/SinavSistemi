
namespace SinavSistemi.UI
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnKayıtlar = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSorular = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblMenu = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.sidebar = new System.Windows.Forms.Panel();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucKayıtlar1 = new SinavSistemi.UI.UCKayıtlar();
            this.ucSorular1 = new SinavSistemi.UI.UCSorular();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnKayıtlar);
            this.panel5.Location = new System.Drawing.Point(1, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 75);
            this.panel5.TabIndex = 4;
            // 
            // btnKayıtlar
            // 
            this.btnKayıtlar.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayıtlar.Appearance.Options.UseFont = true;
            this.btnKayıtlar.Appearance.Options.UseTextOptions = true;
            this.btnKayıtlar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnKayıtlar.AppearancePressed.Options.UseTextOptions = true;
            this.btnKayıtlar.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnKayıtlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayıtlar.ImageOptions.Image = global::SinavSistemi.UI.Properties.Resources.report_32x32;
            this.btnKayıtlar.Location = new System.Drawing.Point(0, 3);
            this.btnKayıtlar.Name = "btnKayıtlar";
            this.btnKayıtlar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKayıtlar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKayıtlar.Size = new System.Drawing.Size(226, 63);
            this.btnKayıtlar.TabIndex = 0;
            this.btnKayıtlar.Text = "      Kayıtlar";
            this.btnKayıtlar.Click += new System.EventHandler(this.btnKayıtlar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSorular);
            this.panel4.Location = new System.Drawing.Point(0, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 75);
            this.panel4.TabIndex = 3;
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
            this.btnSorular.ImageOptions.Image = global::SinavSistemi.UI.Properties.Resources.home_32x32;
            this.btnSorular.Location = new System.Drawing.Point(0, 3);
            this.btnSorular.Name = "btnSorular";
            this.btnSorular.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSorular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSorular.Size = new System.Drawing.Size(227, 63);
            this.btnSorular.TabIndex = 0;
            this.btnSorular.Text = "      Sorular";
            this.btnSorular.Click += new System.EventHandler(this.btnSorular_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCikis);
            this.panel6.Location = new System.Drawing.Point(3, 298);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 75);
            this.panel6.TabIndex = 4;
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
            this.btnCikis.Location = new System.Drawing.Point(-3, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCikis.Size = new System.Drawing.Size(227, 63);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "      Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::SinavSistemi.UI.Properties.Resources.chartgridlineshorizontal_minor;
            this.simpleButton1.Location = new System.Drawing.Point(2, 48);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 40);
            this.simpleButton1.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Controls.Add(this.lblMenu);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 136);
            this.panel3.TabIndex = 5;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(4, 646);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 22);
            this.toggleSwitch1.TabIndex = 6;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.toggleSwitch1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(229, 669);
            this.sidebar.MinimumSize = new System.Drawing.Size(67, 669);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(229, 669);
            this.sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucKayıtlar1);
            this.panel1.Controls.Add(this.ucSorular1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 589);
            this.panel1.TabIndex = 3;
            // 
            // ucKayıtlar1
            // 
            this.ucKayıtlar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKayıtlar1.Location = new System.Drawing.Point(0, 0);
            this.ucKayıtlar1.Name = "ucKayıtlar1";
            this.ucKayıtlar1.Size = new System.Drawing.Size(863, 589);
            this.ucKayıtlar1.TabIndex = 1;
            // 
            // ucSorular1
            // 
            this.ucSorular1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSorular1.Location = new System.Drawing.Point(0, 0);
            this.ucSorular1.Name = "ucSorular1";
            this.ucSorular1.Size = new System.Drawing.Size(863, 589);
            this.ucSorular1.TabIndex = 0;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUI";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private DevExpress.XtraEditors.SimpleButton btnKayıtlar;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnSorular;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblMenu;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Panel sidebar;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private UCKayıtlar ucKayıtlar1;
        private UCSorular ucSorular1;
    }
}