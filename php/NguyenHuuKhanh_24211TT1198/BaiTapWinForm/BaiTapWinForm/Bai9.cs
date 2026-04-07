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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void Bai9_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            lstA.SelectionMode = SelectionMode.MultiExtended;
            lstB.SelectionMode = SelectionMode.MultiExtended;

            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");
            cboLop.SelectedIndex = 0;

            txtTen.TabIndex = 0;
            btnCapNhat.TabIndex = 1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Nhập tên đi!");
                return;
            }

            if (cboLop.Text == "Lớp A")
                lstA.Items.Add(txtTen.Text);
            else
                lstB.Items.Add(txtTen.Text);

            txtTen.Clear();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            foreach (var item in lstA.SelectedItems)
            {
                lstB.Items.Add(item);
            }

            for (int i = lstA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstA.Items.Remove(lstA.SelectedItems[i]);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn!");
                return;
            }

            if (MessageBox.Show("Xóa?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = lstA.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstA.Items.Remove(lstA.SelectedItems[i]);
                }
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            foreach (var item in lstB.SelectedItems)
            {
                lstA.Items.Add(item);
            }

            for (int i = lstB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstB.Items.Remove(lstB.SelectedItems[i]);
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            foreach (var item in lstA.Items)
            {
                lstB.Items.Add(item);
            }

            lstA.Items.Clear();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            foreach (var item in lstB.Items)
            {
                lstA.Items.Add(item);
            }

            lstB.Items.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
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
