using System;
using DevExpress.LookAndFeel;
using DevExpress.XtraRichEdit;
using DevExpress.XtraBars.Docking2010;
using SinavSistemi.Common;
using DevExpress.XtraBars.Navigation;

namespace SinavSistemi.Presentation
{
    public partial class SoruEkleUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DynamicDataTransferObject ddto;
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
            ddto = new DynamicDataTransferObject();
        }

        protected internal DynamicDataTransferObject FillDDTO()
        {
            ddto["RecSoru"] = recSoru;
            ddto["RecA"] = recA;
            ddto["RecB"] = recB;
            ddto["RecC"] = recC;
            ddto["RecD"] = recD;
            ddto["KonuID"] = cbKonu.SelectedIndex;
            ddto["UniteID"] = cbKonu.SelectedIndex;
            ddto["DogruCevap"] = RightAnswer();

            return ddto;
        }

        protected internal void Clear()
        {
            recSoru.RtfText = null;
            recA.RtfText = null;
            recB.RtfText = null;
            recC.RtfText = null;
            recD.RtfText = null;
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

        #region Check Buttons

        void Checked(NavigationPage _nav)
        {
            _nav.ImageOptions.ImageIndex = 0;
            _nav.CustomHeaderButtons[0].Properties.Checked = true;
            _nav.CustomHeaderButtons[0].Properties.UseImage = true;
            foreach (NavigationPage nav in npCevaplar.Pages)
            {
                if (nav.Name == _nav.Name) continue;
                nav.CustomHeaderButtons[0].Properties.Checked = false;
                nav.CustomHeaderButtons[0].Properties.UseImage = false;
            }
        }

        void UnCheck(NavigationPage nav)
        {
            nav.CustomHeaderButtons[0].Properties.UseImage = false;
            nav.ImageOptions.ImageIndex = -1;
        }

        void npA_CustomButtonChecked(object sender, ButtonEventArgs e) => Checked(npA);

        void npA_CustomButtonUnchecked(object sender, ButtonEventArgs e) => UnCheck(npA);

        private void npB_CustomButtonChecked(object sender, ButtonEventArgs e) => Checked(npB);

        private void npB_CustomButtonUnchecked(object sender, ButtonEventArgs e) => UnCheck(npB);

        private void npC_CustomButtonChecked(object sender, ButtonEventArgs e) => Checked(npC);

        private void npC_CustomButtonUnchecked(object sender, ButtonEventArgs e) => UnCheck(npC);

        private void npD_CustomButtonChecked(object sender, ButtonEventArgs e) => Checked(npD);
        private void npD_CustomButtonUnchecked(object sender, ButtonEventArgs e) => UnCheck(npD);

        #endregion

        protected internal string RightAnswer()
        {
            if (npA.CustomHeaderButtons[0].Properties.Checked) return "A";
            if (npB.CustomHeaderButtons[0].Properties.Checked) return "B";
            if (npC.CustomHeaderButtons[0].Properties.Checked) return "C";
            if (npD.CustomHeaderButtons[0].Properties.Checked) return "D";
            return null;
        }
    }
}