using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SinavSistemi.Presentation
{
    public partial class HesapUC : UserControl
    {
        public HesapUC()
        {
            InitializeComponent();
        }

        

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");

            }
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
            }
        }

        //private void svgImageBox1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog fileOpen = new OpenFileDialog();
        //    fileOpen.Title = "Open Image file";
        //    fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

        //    if (fileOpen.ShowDialog() == DialogResult.OK)
        //    {
        //         pictureBox1.Image= Image.FromFile(fileOpen.FileName);
        //    }
        //    fileOpen.Dispose();
        //}

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileOpen.FileName);
            }
            fileOpen.Dispose();

        }
    }
}
