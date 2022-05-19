using SinavSistemi.Common;
using SinavSistemi.Entity;
using SinavSistemi.Presentation.UIs;
using System;
using System.Windows.Forms;

namespace SinavSistemi.Presentation.ManagementObjects
{
    public class UserUI_MO : Base_MO<UserUI_MO, UserUI>
    {
        public UserUI UI { get; set; }

        protected internal DynamicDataTransferObject ddto;
        public UserUI_MO()
        {
            UI = new UserUI();
            UI.AnaSayfaUC.btnSinavaGir.Click += BtnSinavaGir_Click;
            UI.RaporUC.btnAnalizCikar.Click += BtnAnalizCikar_Click;
            UI.HesapUC.btnSave.Click += BtnSave_Click;
            UI.AyarlarUC.btnKaydet.Click += BtnKaydet_Click;
            ddto = new DynamicDataTransferObject();
            UI.Show();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAnalizCikar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSinavaGir_Click(object sender, EventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<SigmaSinav_MO, SigmaSinavUI>();
            Dispose();
        }
    }
}
