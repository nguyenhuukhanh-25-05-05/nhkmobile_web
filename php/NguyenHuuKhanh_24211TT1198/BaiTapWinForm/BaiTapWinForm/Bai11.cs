using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD_C.Thiện
{
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }

        private void Bai11_Load(object sender, EventArgs e)
        {
            tbR.Maximum = 255;
            tbG.Maximum = 255;
            tbB.Maximum = 255;

            tbR.Value = 0;
            tbG.Value = 0;
            tbB.Value = 0;
        }
        void DoiMau()
        {
            lblR.Text = "R = " + tbR.Value;
            lblG.Text = "G = " + tbG.Value;
            lblB.Text = "B = " + tbB.Value;

            pnlMau.BackColor = Color.FromArgb(tbR.Value, tbG.Value, tbB.Value);
        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            DoiMau();
        }

        private void tbG_Scroll(object sender, EventArgs e)
        {
            DoiMau();
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            DoiMau();
        }
    }
}
