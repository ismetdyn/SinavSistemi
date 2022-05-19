using DevExpress.XtraEditors;
using SinavSistemi.Common;
using SinavSistemi.Presentation.ManagementObjects;
using System;
using System.Windows.Forms;

namespace SinavSistemi.Presentation.UIs
{
    public partial class InitializeForm : XtraForm
    {
        private static InitializeForm _current;

        public static InitializeForm Current
        {
            get 
            {
                if (_current == null) return new InitializeForm();
                return _current; 
            }
        }

        private InitializeForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Hide();
        }

        private void InitializeForm_Load(object sender, System.EventArgs e)
        {
            Islem<LoginUI_MO, LoginUI>();
            //Islem<FrgtPsswrdUI_MO, FrgtPsswrdUI>();
            //Islem<UserUI_MO, UserUI>();
            //Islem<SoruEkleUI_MO, SoruEkleUI>();
            //Islem<SigmaSinav_MO, SigmaSinavUI>();
        }

        public void Islem<MO, UI>() where MO : class, new() where UI : Form, new()
        {
            MO mo = new MO();
        }
    }
}