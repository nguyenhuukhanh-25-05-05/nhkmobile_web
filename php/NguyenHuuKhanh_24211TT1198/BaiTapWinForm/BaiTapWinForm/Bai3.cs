using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void radAdd3_CheckedChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum3_1.Text, out double n1) || !double.TryParse(txtNum3_2.Text, out double n2)) return;
            RadioButton rad = sender as RadioButton;
            txtResult3.Text = (n1 + n2).ToString();
        }

        private void radSub3_CheckedChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum3_1.Text, out double n1) || !double.TryParse(txtNum3_2.Text, out double n2)) return;
            RadioButton rad = sender as RadioButton;
            txtResult3.Text = (n1 - n2).ToString();
        }

        private void radMul3_CheckedChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum3_1.Text, out double n1) || !double.TryParse(txtNum3_2.Text, out double n2)) return;
            RadioButton rad = sender as RadioButton;
            txtResult3.Text = (n1 * n2).ToString();
        }

        private void radDiv3_CheckedChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum3_1.Text, out double n1) || !double.TryParse(txtNum3_2.Text, out double n2)) return;
            RadioButton rad = sender as RadioButton;
            txtResult3.Text = (n2 == 0) ? "Div/0" : (n1 / n2).ToString();
        }
    }
}
