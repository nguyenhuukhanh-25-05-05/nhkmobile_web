using System;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            btnSolve2.Enabled = false;
            btnClear2.Enabled = false;

            txtA2.TextChanged += new EventHandler(KiemTraDuLieu);
            txtB2.TextChanged += new EventHandler(KiemTraDuLieu);
        }

        private void KiemTraDuLieu(object sender, EventArgs e)
        {
            bool isAValid = false;
            bool isBValid = false;

            if (string.IsNullOrWhiteSpace(txtA2.Text))
            {
                errorProvider1.SetError(txtA2, "Không được để trống A!");
            }
            else if (!double.TryParse(txtA2.Text, out _))
            {
                errorProvider1.SetError(txtA2, "A phải là một số!");
            }
            else
            {
                errorProvider1.SetError(txtA2, ""); 
                isAValid = true;
            }

            if (string.IsNullOrWhiteSpace(txtB2.Text))
            {
                errorProvider1.SetError(txtB2, "Không được để trống B!");
            }
            else if (!double.TryParse(txtB2.Text, out _))
            {
                errorProvider1.SetError(txtB2, "B phải là một số!");
            }
            else
            {
                errorProvider1.SetError(txtB2, ""); 
                isBValid = true;
            }

            if (isAValid && isBValid)
            {
                btnSolve2.Enabled = true;
            }
            else
            {
                btnSolve2.Enabled = false;
            }
        }
        private void btnSolve2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtA2.Text, out double a) && double.TryParse(txtB2.Text, out double b))
            {
                if (a == 0)
                {
                    if (b == 0)
                        txtResult2.Text = "Vô số nghiệm";
                    else
                        txtResult2.Text = "Vô nghiệm";
                }
                else
                {
                    txtResult2.Text = $"x = {-b / a}";
                }

                btnClear2.Enabled = true;
                btnSolve2.Enabled = false;
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtA2.Clear();
            txtB2.Clear();
            txtResult2.Clear(); 
            errorProvider1.Clear(); 

            txtA2.Focus();

            btnClear2.Enabled = false;
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát khỏi ứng dụng hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}