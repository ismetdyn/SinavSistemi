using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraRichEdit;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Docking2010;

namespace SinavSistemi.UI
{
    public partial class SoruEkleUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SoruEkleUI()
        {
            InitializeComponent();
            recSoru.GotFocus += RecSoru_GotFocus;
            recA.GotFocus += RecASoru_GotFocus;
            recB.GotFocus += RecBSoru_GotFocus;
            recC.GotFocus += RecCSoru_GotFocus;
            recD.GotFocus += RecDSoru_GotFocus;
            npA.CustomButtonChecked += npA_CustomButtonChecked;
            npA.CustomButtonUnchecked += npA_CustomButtonUnchecked;
            npB.CustomButtonChecked += npB_CustomButtonChecked;
            npB.CustomButtonUnchecked += npB_CustomButtonUnchecked;
            npC.CustomButtonChecked += npC_CustomButtonChecked;
            npC.CustomButtonUnchecked += npC_CustomButtonUnchecked;
            npD.CustomButtonChecked += npD_CustomButtonChecked;
            npD.CustomButtonUnchecked += npD_CustomButtonUnchecked;
        }


        #region RichTextControllerFocus
        private void RecSoru_GotFocus(object sender, EventArgs e)
        {
            richEditBarController1.Control = (RichEditControl)sender;
        }

        private void RecASoru_GotFocus(object sender, EventArgs e)
        {
            richEditBarController1.Control = (RichEditControl)(sender);
        }

        private void RecBSoru_GotFocus(object sender, EventArgs e)
        {
            richEditBarController1.Control = (RichEditControl)sender;
        }

        private void RecCSoru_GotFocus(object sender, EventArgs e)
        {
            richEditBarController1.Control = (RichEditControl)(sender);
        }

        private void RecDSoru_GotFocus(object sender, EventArgs e)
        {
            richEditBarController1.Control = (RichEditControl)(sender);
        }

        #endregion

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitchGeceModu.IsOn)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            }
            else
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            }
        }


        #region Check Buton

        void npA_CustomButtonChecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = true;
            npB.CustomHeaderButtons[0].Properties.Checked = false;
            npC.CustomHeaderButtons[0].Properties.Checked = false;
            npD.CustomHeaderButtons[0].Properties.Checked = false;
            npA.ImageOptions.ImageIndex = 0;
        }

        void npA_CustomButtonUnchecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = false;
            npA.ImageOptions.ImageIndex = -1;
        }

        private void npB_CustomButtonChecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = true;
            npA.CustomHeaderButtons[0].Properties.Checked = false;
            npC.CustomHeaderButtons[0].Properties.Checked = false;
            npD.CustomHeaderButtons[0].Properties.Checked = false;
            npB.ImageOptions.ImageIndex = 0;
        }

        private void npB_CustomButtonUnchecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = false;
            npB.ImageOptions.ImageIndex = -1;
        }

        private void npC_CustomButtonChecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = true;
            npA.CustomHeaderButtons[0].Properties.Checked = false;
            npB.CustomHeaderButtons[0].Properties.Checked = false;
            npD.CustomHeaderButtons[0].Properties.Checked = false;
            npC.ImageOptions.ImageIndex = 0;
        }

        private void npC_CustomButtonUnchecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = false;
            npC.ImageOptions.ImageIndex = -1;
        }

        private void npD_CustomButtonChecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = true;
            npA.CustomHeaderButtons[0].Properties.Checked = false;
            npB.CustomHeaderButtons[0].Properties.Checked = false;
            npC.CustomHeaderButtons[0].Properties.Checked = false;
            npD.ImageOptions.ImageIndex = 0;
        }

        private void npD_CustomButtonUnchecked(object sender, ButtonEventArgs e)
        {
            e.Button.Properties.UseImage = false;
            npD.ImageOptions.ImageIndex = -1;
        }

        #endregion
    }
}