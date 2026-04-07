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
    public partial class bai10 : Form
    {
        public bai10()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hocky = "";

            if (radI.Checked) hocky = radI.Text;
            else if (radII.Checked) hocky = radII.Text;
            else if (radIII.Checked) hocky = radIII.Text;
            else if (radIV.Checked) hocky = radIV.Text;

            string kq =
        "MSSV: " + txtMSSV.Text + "\n" +
        "Họ tên: " + txtHoTen.Text + "\n" +
        "Niên khóa: " + cboLienKhoa.Text + "\n" +
        "Lớp: " + cboLop.Text + "\n" +
        "Học kỳ: "+ radI.Text + "\n" +
        "Môn học: "+checkedListBox1.Text;


            MessageBox.Show(kq, "Thông tin");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();

            cboLienKhoa.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;

            radI.Checked = false;
            radII.Checked = false;
            radIII.Checked = false;
            radIV.Checked = false;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            txtMSSV.Focus();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void bai10_Load(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();

            cboLienKhoa.Items.Add("2007");
            cboLienKhoa.Items.Add("2008");
            cboLienKhoa.Items.Add("2009");
            cboLienKhoa.Items.Add("2010");

            cboLop.Items.Add("TH01");
            cboLop.Items.Add("TH02");
            cboLop.Items.Add("TH03");

            cboLienKhoa.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;

            checkedListBox1.Items.Add("Lập trình C#");
            checkedListBox1.Items.Add("Cơ sở dữ liệu");
            checkedListBox1.Items.Add("Mạng máy tính");
            checkedListBox1.Items.Add("Hệ điều hành");
            checkedListBox1.Items.Add("Trí tuệ nhân tạo");
        }
    }
}
