using System;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            cboNum7.Items.Clear();
            lstDivisors7.Items.Clear();
            txtNum7.Clear();
            txtNum7.Focus();
        }

        private void btnUpdate7_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum7.Text, out int n))
            {
                if (!cboNum7.Items.Contains(n))
                {
                    cboNum7.Items.Add(n);
                }
                txtNum7.Clear();  
                txtNum7.Focus(); 
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum7.Clear();
                txtNum7.Focus();
            }
        }
        private void txtNum7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate7_Click(sender, e);
            }
        }
        private void cboNum7_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDivisors7.Items.Clear(); 

            if (cboNum7.SelectedItem != null)
            {
                int n = (int)cboNum7.SelectedItem;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        lstDivisors7.Items.Add(i);
                    }
                }
            }
        }

        private void btnSum7_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lstDivisors7.Items)
            {
                sum += (int)item;
            }
            MessageBox.Show("Tổng các ước số là: " + sum, "Kết quả");
        }
        private void btnCountEven7_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in lstDivisors7.Items)
            {
                if ((int)item % 2 == 0) count++;
            }
            MessageBox.Show("Số lượng các ước số chẵn là: " + count, "Kết quả");
        }
        private void btnCountPrime7_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in lstDivisors7.Items)
            {
                if (KiemTraNguyenTo((int)item))
                {
                    count++;
                }
            }
            MessageBox.Show("Số lượng các ước số nguyên tố là: " + count, "Kết quả");
        }

        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false; // Nếu chia hết cho số khác ngoài 1 và chính nó
            }
            return true;
        }
        private void btnExit7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}