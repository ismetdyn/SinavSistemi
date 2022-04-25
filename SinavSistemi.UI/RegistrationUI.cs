using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinavSistemi.UI;

namespace SinavSistemi.UI
{
    public partial class RegistrationUI : DevExpress.XtraEditors.XtraForm
    {
        public RegistrationUI()
        {
            InitializeComponent();
        }

        private void RegistrationUI_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            User frm2 = new User();
            frm2.Show();
            this.Hide();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if(toggleSwitch1.IsOn)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            }
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
            }

        }

        private void svgImageBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}