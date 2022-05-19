using SinavSistemi.Common;
using SinavSistemi.Entity;
using System.Windows.Forms;

namespace SinavSistemi.Presentation.ManagementObjects
{
    public class AdminUI_MO : Base_MO<AdminUI_MO, AdminUI>
    {
        public AdminUI UI { get; set; }
        Kullanici kullanici = Program.kullanici;
        DynamicDataTransferObject ddto;

        public AdminUI_MO()
        {
            UI = new AdminUI();
            ddto = new DynamicDataTransferObject();
            UI.FormClosed += UI_FormClosed;
            UI.Show();
        }

        private void UI_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void FillDDTO() => ddto = UI.FillDDTO();


    }
}
