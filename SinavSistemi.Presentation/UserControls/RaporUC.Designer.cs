
namespace SinavSistemi.Presentation
{
    partial class RaporUC
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
            this.btnAnalizCikar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnAnalizCikar
            // 
            this.btnAnalizCikar.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnAnalizCikar.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnalizCikar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAnalizCikar.Appearance.Options.UseBackColor = true;
            this.btnAnalizCikar.Appearance.Options.UseFont = true;
            this.btnAnalizCikar.Appearance.Options.UseForeColor = true;
            this.btnAnalizCikar.ImageOptions.Image = global::SinavSistemi.Presentation.Properties.Resources.report2_32x32;
            this.btnAnalizCikar.Location = new System.Drawing.Point(400, 265);
            this.btnAnalizCikar.Name = "btnAnalizCikar";
            this.btnAnalizCikar.Size = new System.Drawing.Size(456, 109);
            this.btnAnalizCikar.TabIndex = 0;
            this.btnAnalizCikar.Text = "Analiz Raporumu Çıkar";
            // 
            // RaporUC
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnalizCikar);
            this.Name = "RaporUC";
            this.Size = new System.Drawing.Size(1274, 670);
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal DevExpress.XtraEditors.SimpleButton btnAnalizCikar;
    }
}
