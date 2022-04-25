using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi.UI
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            ucSorular1.Hide();
            ucKayıtlar1.Hide();
        }

        private void btnSorular_Click(object sender, EventArgs e)
        {
            ucKayıtlar1.Hide();
            ucSorular1.Show();
        }

        private void btnKayıtlar_Click(object sender, EventArgs e)
        {
            ucSorular1.Hide();
            ucKayıtlar1.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            string message = "Uygulamadan Çıkmayı İstiyor musun?";
            string title = "Pencereyi Kapat";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
