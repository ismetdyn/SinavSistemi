
namespace SinavSistemi.Presentation
{
    partial class KullanicilarUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.SvgImageItem svgImageItem1 = new DevExpress.XtraEditors.SvgImageItem("1/0");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanicilarUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnSilme = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnOnay = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sinavSistemiDBDataSet = new SinavSistemi.Presentation.SinavSistemiDBDataSet();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarTableAdapter = new SinavSistemi.Presentation.SinavSistemiDBDataSetTableAdapters.KullanicilarTableAdapter();
            this.colKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciTipID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toggleSwitch1);
            this.panel1.Controls.Add(this.btnSilme);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.svgImageBox1);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnOnay);
            this.panel1.Location = new System.Drawing.Point(606, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 670);
            this.panel1.TabIndex = 1;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(561, 6);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(109, 20);
            this.toggleSwitch1.TabIndex = 28;
            // 
            // btnSilme
            // 
            this.btnSilme.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSilme.Appearance.Options.UseFont = true;
            this.btnSilme.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.cancel_32x322;
            this.btnSilme.Location = new System.Drawing.Point(259, 574);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(175, 44);
            this.btnSilme.TabIndex = 27;
            this.btnSilme.Text = "Kayıt Silme";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGüncelle.Appearance.Options.UseFont = true;
            this.btnGüncelle.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.refreshallpivottable_32x32;
            this.btnGüncelle.Location = new System.Drawing.Point(368, 520);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(162, 48);
            this.btnGüncelle.TabIndex = 26;
            this.btnGüncelle.Text = "Güncelleme";
            // 
            // svgImageBox1
            // 
            svgImageItem1.Appearance.Normal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.svgImageBox1.CustomizedItems.Add(svgImageItem1);
            this.svgImageBox1.Location = new System.Drawing.Point(245, 66);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(202, 176);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 25;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(193, 440);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 24);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "PassWord";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(304, 437);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(143, 30);
            this.txtPassword.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(245, 400);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 24);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(304, 397);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(143, 30);
            this.txtMail.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(193, 351);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 24);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "SurName";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(304, 348);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSurname.Properties.Appearance.Options.UseFont = true;
            this.txtSurname.Size = new System.Drawing.Size(143, 30);
            this.txtSurname.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(226, 304);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 24);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(304, 301);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(143, 30);
            this.txtName.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(181, 260);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 24);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(304, 254);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(143, 30);
            this.txtUserName.TabIndex = 15;
            // 
            // btnOnay
            // 
            this.btnOnay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOnay.Appearance.Options.UseFont = true;
            this.btnOnay.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.apply_32x32;
            this.btnOnay.Location = new System.Drawing.Point(181, 520);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(167, 48);
            this.btnOnay.TabIndex = 14;
            this.btnOnay.Text = "Onaylama";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 664);
            this.panel2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kullanicilarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(595, 664);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKullaniciID,
            this.colKullaniciAdi,
            this.colAd,
            this.colSoyad,
            this.colEposta,
            this.colSifre,
            this.colKullaniciTipID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sinavSistemiDBDataSet
            // 
            this.sinavSistemiDBDataSet.DataSetName = "SinavSistemiDBDataSet";
            this.sinavSistemiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "Kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.sinavSistemiDBDataSet;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // colKullaniciID
            // 
            this.colKullaniciID.FieldName = "KullaniciID";
            this.colKullaniciID.MinWidth = 25;
            this.colKullaniciID.Name = "colKullaniciID";
            this.colKullaniciID.Visible = true;
            this.colKullaniciID.VisibleIndex = 0;
            this.colKullaniciID.Width = 94;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.MinWidth = 25;
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 1;
            this.colKullaniciAdi.Width = 94;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 2;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 3;
            this.colSoyad.Width = 94;
            // 
            // colEposta
            // 
            this.colEposta.FieldName = "Eposta";
            this.colEposta.MinWidth = 25;
            this.colEposta.Name = "colEposta";
            this.colEposta.Visible = true;
            this.colEposta.VisibleIndex = 4;
            this.colEposta.Width = 94;
            // 
            // colSifre
            // 
            this.colSifre.FieldName = "Sifre";
            this.colSifre.MinWidth = 25;
            this.colSifre.Name = "colSifre";
            this.colSifre.Visible = true;
            this.colSifre.VisibleIndex = 5;
            this.colSifre.Width = 94;
            // 
            // colKullaniciTipID
            // 
            this.colKullaniciTipID.FieldName = "KullaniciTipID";
            this.colKullaniciTipID.MinWidth = 25;
            this.colKullaniciTipID.Name = "colKullaniciTipID";
            this.colKullaniciTipID.Visible = true;
            this.colKullaniciTipID.VisibleIndex = 6;
            this.colKullaniciTipID.Width = 94;
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Kullanicilar";
            this.Size = new System.Drawing.Size(1279, 670);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSistemiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSilme;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnOnay;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private SinavSistemiDBDataSet sinavSistemiDBDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciID;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colEposta;
        private DevExpress.XtraGrid.Columns.GridColumn colSifre;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciTipID;
        private SinavSistemiDBDataSetTableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter;
    }
}
