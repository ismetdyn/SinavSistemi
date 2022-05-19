using System;
using System.Windows.Forms;
using SinavSistemi.BusinessLayer;
using SinavSistemi.Common;
using SinavSistemi.Entity;
using SinavSistemi.Presentation.ManagementObjects;

namespace SinavSistemi.Presentation
{
    public class SoruEkleUI_MO : Base_MO<SoruEkleUI_MO, SoruEkleUI>
    {
        public SoruEkleUI UI;
        DynamicDataTransferObject ddto;

        public SoruEkleUI_MO()
        {
            UI = new SoruEkleUI();
            UI.btnSend.Click += BtnSend_Click;
            UI.Closed += UI_Closed;
            UI.Show();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            FillDDTO();
            MessageBox.Show(SoruBL.Current.SoruToDB(ddto).Message);
        }

        private void UI_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void FillDDTO() => ddto = UI.FillDDTO();
    }
}
