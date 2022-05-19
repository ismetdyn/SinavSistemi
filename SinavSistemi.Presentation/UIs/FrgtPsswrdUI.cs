using System;
using SinavSistemi.Common;

namespace SinavSistemi.Presentation
{
    public partial class FrgtPsswrdUI : DevExpress.XtraEditors.XtraForm
    {
        //int rand_num;
        private DynamicDataTransferObject ddto;
        public FrgtPsswrdUI()
        {
            InitializeComponent();
            ddto = new DynamicDataTransferObject();
        }

        private void FrgtPsswrdUI_Load(object sender, EventArgs e) => 
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
        

        protected internal DynamicDataTransferObject FillDDTO()
        {
            ddto["Eposta"] = teEposta.Text;
            ddto["Kod"] = teKod.Text;
            ddto["Sifre"] = teSifre.Text;
            ddto["SifreTekrar"] = teSifreTekrar.Text;

            return ddto;
        }

        private void aliciText_TextChanged(object sender, EventArgs e)
        {
            //kullanici.Eposta = aliciText.Text;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn) DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
        }

        private void svgImageBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected internal void PanelVisibility()
        {
            panelSifreDegistir.Visible = true;
            panelSifreDegistir.Enabled = true;
        }
    }
}