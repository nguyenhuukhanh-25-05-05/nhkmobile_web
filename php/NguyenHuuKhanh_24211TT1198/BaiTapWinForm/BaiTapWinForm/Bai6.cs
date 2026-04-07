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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void radVN_CheckedChanged(object sender, EventArgs e)
        {
            if (radVN.Checked)
            {
                picFlag.Image = imageList1.Images[0];
            }
        }

        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (radUSA.Checked)
            {
                picFlag.Image = imageList1.Images[1];
            }
        }

        private void radPhilippine_CheckedChanged(object sender, EventArgs e)
        {
            if (radPhilippine.Checked)
            {
                picFlag.Image = imageList1.Images[2];
            }
        }

        private void radItaly_CheckedChanged(object sender, EventArgs e)
        {
            if (radItaly.Checked)
            {
                picFlag.Image = imageList1.Images[3];
            }
        }
    }
}
