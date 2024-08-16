using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulamsi1.Forms
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        private string veriTabanıSeçimi;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            veriTabanıSeçimi = "SQLite";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            veriTabanıSeçimi = "SqlServer";
        }
        FrmAnaMenü FrmAnaMenü;
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Lütfen çalışmak istediğiniz veri tabanını seçiniz.");
            }
            else
            {
                if (FrmAnaMenü == null || FrmAnaMenü.IsDisposed)
                {
                    FrmAnaMenü = new FrmAnaMenü(veriTabanıSeçimi);
                    FrmAnaMenü.Show();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
