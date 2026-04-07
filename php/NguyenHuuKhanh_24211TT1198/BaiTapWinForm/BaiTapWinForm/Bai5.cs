using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if (radArial5.Checked)
            { 
                txtDisplay5.Font = new Font("Arial", txtDisplay5.Font.Size);
            }
        }

        private void radTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimes5.Checked)
            {
                txtDisplay5.Font = new Font("Times New Roman", txtDisplay5.Font.Size);
            }
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (radTahoma5.Checked)
            {
                txtDisplay5.Font = new Font("Tahoma", txtDisplay5.Font.Size);
            }
        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radCourier5.Checked)
            {
                txtDisplay5.Font = new Font("Courier New", txtDisplay5.Font.Size);
            }
        }

        private void btnExit5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}