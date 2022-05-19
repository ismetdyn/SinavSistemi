using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using SinavSistemi.Common;
using DevExpress.LookAndFeel;
using System;

namespace SinavSistemi.Presentation
{
    public partial class SigmaSinavUI : XtraForm
    {
        DynamicDataTransferObject ddto;

        public SigmaSinavUI()
        {
            InitializeComponent();
            btnPnlCevapA.ButtonChecked += new ButtonEventHandler(Check);
            btnPnlCevapA.ButtonUnchecked += new ButtonEventHandler(Uncheck);
            btnPnlCevapB.ButtonChecked += new ButtonEventHandler(Check);
            btnPnlCevapB.ButtonUnchecked += new ButtonEventHandler(Uncheck); 
            btnPnlCevapC.ButtonChecked += new ButtonEventHandler(Check);
            btnPnlCevapC.ButtonUnchecked += new ButtonEventHandler(Uncheck);
            btnPnlCevapD.ButtonChecked += new ButtonEventHandler(Check);
            btnPnlCevapD.ButtonUnchecked += new ButtonEventHandler(Uncheck);
            ddto = new DynamicDataTransferObject();
        }

        private void toggleSwitchGeceModu_Toggled(object sender, System.EventArgs e)
        {
            if (toggleSwitchGeceModu.IsOn) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
        }

        void Check(object sender, ButtonEventArgs e = null)
        {
            if (sender != null)
            {
                ((WindowsUIButtonPanel)sender).Buttons[0].Properties.Checked = true;
                ((WindowsUIButtonPanel)sender).Buttons[0].Properties.UseImage = true;
                foreach (WindowsUIButtonPanel panel in panelCevaplar.Controls)
                {
                    if (panel.Name == ((WindowsUIButtonPanel)sender).Name) continue;
                    panel.Buttons[0].Properties.Checked = false;
                    panel.Buttons[0].Properties.UseImage = false;
                }
            }
        }

        void Uncheck(object sender, ButtonEventArgs e = null) 
        {
            if (sender != null)
            {
                ((WindowsUIButtonPanel)sender).Buttons[0].Properties.UseImage = false;
                ((WindowsUIButtonPanel)sender).Buttons[0].Properties.Checked = false;
            }
        }

        void UnCheckAll()
        {
            foreach (WindowsUIButtonPanel panel in panelCevaplar.Controls)
            {
                panel.Buttons[0].Properties.Checked = false;
                panel.Buttons[0].Properties.UseImage = false;
            }
        }

        protected internal DynamicDataTransferObject FillDDTO()
        {
            ddto["RecSoru"] = recSoru;
           // ddto["Zaman"] = teZaman;
           // ddto["DogruCevap"] = Answer();

            return ddto;
        }

        

        private void recSoru_RtfTextChanged(object sender, EventArgs e)
        {

        }

        protected internal void Clear() => recSoru.RtfText = null;

        protected internal void SetAnswer(string cevap)
        {
            if (cevap == null) UnCheckAll();
            foreach (WindowsUIButtonPanel panel in panelCevaplar.Controls)
            {
                if (panel.Name.Substring(panel.Name.Length-1,1) == cevap) Check(panel);
            }
        }
    }
}