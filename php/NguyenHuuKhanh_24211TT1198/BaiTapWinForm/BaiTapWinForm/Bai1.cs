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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
        private void btnShow1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtYourName1.Text))
                errorProvider1.SetError(txtYourName1, "Tên không trống!");
            else if (!int.TryParse(txtYear1.Text, out int y))
                errorProvider1.SetError(txtYear1, "Năm phải là số!");
            else
                MessageBox.Show($"Name: {txtYourName1.Text}\nAge: {DateTime.Now.Year - y}");
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtYourName1.Clear();
            txtYear1.Clear();
            errorProvider1.Clear();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) this.Close();
        }
    }
}
