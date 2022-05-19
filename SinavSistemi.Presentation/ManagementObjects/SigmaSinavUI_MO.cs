using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SinavSistemi.BusinessLayer;
using SinavSistemi.Common;
using SinavSistemi.Entity;
using SinavSistemi.Presentation.UIs;
using SinavSistemi.Presentation.ManagementObjects;
using DevExpress.XtraBars.Docking2010;

namespace SinavSistemi.Presentation
{
    class SigmaSinav_MO : Base_MO<SigmaSinav_MO, SigmaSinavUI>
    {
        SigmaSinavUI UI;
        DynamicDataTransferObject ddto;
        List<Soru> sorular;
        string[] cevaplar;
        int soruSayac = 0;
        DateTime zaman;
        public SigmaSinav_MO()
        {
            UI = new SigmaSinavUI();
            ddto = new DynamicDataTransferObject();
            UI.btnNext.Click += BtnNext_Click;
            UI.btnPrevious.Click += BtnPrevious_Click;
            UI.btnSinavBitir.Click += BtnSinavBitir_Click;
            UI.btnPnlCevapA.ButtonChecked += new ButtonEventHandler(SetUserAnwser);
            UI.btnPnlCevapA.ButtonUnchecked += new ButtonEventHandler(SetUserNullAnwser);
            UI.btnPnlCevapB.ButtonChecked += new ButtonEventHandler(SetUserAnwser);
            UI.btnPnlCevapB.ButtonUnchecked += new ButtonEventHandler(SetUserNullAnwser);
            UI.btnPnlCevapC.ButtonChecked += new ButtonEventHandler(SetUserAnwser);
            UI.btnPnlCevapC.ButtonUnchecked += new ButtonEventHandler(SetUserNullAnwser);
            UI.btnPnlCevapD.ButtonChecked += new ButtonEventHandler(SetUserAnwser);
            UI.btnPnlCevapD.ButtonUnchecked += new ButtonEventHandler(SetUserNullAnwser);
            UI.timer1.Tick += Timer1_Tick;
            Initialize();
            UI.Load += UI_Load;
            UI.Show();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            UI.Clear();
            UI.recSoru.SoruDeSerialize(sorular[0]);
            zaman = new DateTime(2000, 1, 1, 0, sorular.Count+2, 0);
            UI.timer1.Start();
        }

        void Initialize()
        {
            sorular = new List<Soru>();
            Result<List<Soru>> result1 = SoruBL.Current.GetQuestions(Program.kullanici);
            if (!result1.IsSuccess) MessageBox.Show(result1.Message);
            else sorular.AddRange(result1.Data);
            cevaplar = new string[sorular.Count];
        }

        private void FillDDTO() => ddto = UI.FillDDTO();

        void SetUserAnwser(object sender, ButtonEventArgs e)
        {
            string name = ((WindowsUIButtonPanel)sender).Name;
            cevaplar[soruSayac] = name.Substring(name.Length - 1, 1);
        }

        void SetUserNullAnwser(object sender, ButtonEventArgs e) => cevaplar[soruSayac] = null;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (zaman.Minute == 0 && zaman.Second == 0)
            {
                UI.timer1.Stop();
                UI.panelCevaplar.Enabled = false;
            }
            UI.lSure.Text = zaman.ToString("HH:mm:ss");
            zaman = zaman.AddSeconds(-1);
        }

        private void BtnSinavBitir_Click(object sender, EventArgs e)
        {
            UI.Close();
            UI.Dispose();
            MessageBox.Show(
                IstatistikBL.Current.MultipleIstatistikToDB(sorular,cevaplar,Program.kullanici).Message);
            InitializeForm.Current.Islem<UserUI_MO, UserUI>();
            Dispose();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            FillDDTO();
            if (soruSayac > 0)
            {
                soruSayac--;
                UI.Clear();
                UI.recSoru.SoruDeSerialize(sorular[soruSayac]);
                UI.SetAnswer(cevaplar[soruSayac]);
            }
            else MessageBox.Show("Başka soru yok");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            FillDDTO();
            if (soruSayac < sorular.Count-1)
            {
                UI.Clear();
                soruSayac++;
                UI.recSoru.SoruDeSerialize(sorular[soruSayac]);
                UI.SetAnswer(cevaplar[soruSayac]);
            }
            else MessageBox.Show("Başka soru yok");
        }
    }
}
