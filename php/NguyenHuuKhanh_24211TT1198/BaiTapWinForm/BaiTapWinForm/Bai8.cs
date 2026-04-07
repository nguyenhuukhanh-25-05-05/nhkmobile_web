using System;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            txtInput8.Clear();
            lstNumbers8.Items.Clear();
            txtInput8.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput8.Text, out int n))
            {
                lstNumbers8.Items.Add(n);
                txtInput8.Clear();
                txtInput8.Focus();
            }
            else
            {
                MessageBox.Show("Nhập số nguyên giùm tui nha!", "Lỗi");
                txtInput8.SelectAll();
                txtInput8.Focus();
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNhap_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        // 2. Tổng các phần tử
        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lstNumbers8.Items) sum += (int)item;
            MessageBox.Show("Tổng là: " + sum);
        }

        // 3. Xóa đầu và cuối
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstNumbers8.Items.Count >= 2)
            {
                lstNumbers8.Items.RemoveAt(lstNumbers8.Items.Count - 1);
                lstNumbers8.Items.RemoveAt(0);
            }
            else if (lstNumbers8.Items.Count == 1) lstNumbers8.Items.Clear();
        }

        // 4. Xóa phần tử đang chọn (Phải chỉnh SelectionMode = MultiSimple)
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            while (lstNumbers8.SelectedItems.Count > 0)
            {
                lstNumbers8.Items.Remove(lstNumbers8.SelectedItems[0]);
            }
        }

        // 5. Tăng mỗi phần tử lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNumbers8.Items.Count; i++)
            {
                lstNumbers8.Items[i] = (int)lstNumbers8.Items[i] + 2;
            }
        }

        // 6. Thay bằng bình phương
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNumbers8.Items.Count; i++)
            {
                int val = (int)lstNumbers8.Items[i];
                lstNumbers8.Items[i] = val * val;
            }
        }

        // 7. Chọn số chẵn
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lstNumbers8.ClearSelected();
            for (int i = 0; i < lstNumbers8.Items.Count; i++)
            {
                if ((int)lstNumbers8.Items[i] % 2 == 0) lstNumbers8.SetSelected(i, true);
            }
        }

        // 8. Chọn số lẻ
        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lstNumbers8.ClearSelected();
            for (int i = 0; i < lstNumbers8.Items.Count; i++)
            {
                if ((int)lstNumbers8.Items[i] % 2 != 0) lstNumbers8.SetSelected(i, true);
            }
        }

        // 9. Kết thúc
        private void btnEnd8_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
             "Bạn có muốn thoát không?",
             "Thông báo",
             MessageBoxButtons.OKCancel
            );

            if (kq == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}