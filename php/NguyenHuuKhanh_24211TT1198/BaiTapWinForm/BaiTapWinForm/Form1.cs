using System;
using System.Drawing;
using System.Windows.Forms;
using LTUD_C.Thiện;
using static System.Windows.Forms.DataFormats;

namespace BaiTapWinForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnExit_Global_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuBai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.Show();
            b1.MdiParent = this;
        }

        private void mnuBai2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.Show();
            b2.MdiParent = this;
        }

        private void mnuBai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.Show();
            b3.MdiParent = this;
        }

        private void mnuBai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.Show();
            b4.MdiParent = this;
        }

        private void mnuBai5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.Show();
            b5.MdiParent = this;
        }

        private void mnuBai6_Click(object sender, EventArgs e)
        {
            Bai6 b6 = new Bai6();
            b6.Show();
            b6.MdiParent = this;
        }

        private void mnuBai7_Click(object sender, EventArgs e)
        {
            Bai7 b7 = new Bai7();
            b7.Show(); b7.MdiParent = this;
        }

        private void mnuBai8_Click(object sender, EventArgs e)
        {
            Bai8 b8 = new Bai8();
            b8.Show(); b8.MdiParent = this;
        }

        private void bài9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai9 b9 = new Bai9();
            b9.Show(); b9.MdiParent = this;
        }

        private void bài10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai10 bai10 = new bai10();
            bai10.Show(); bai10.MdiParent = this;
        }

        private void bài11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai11 bai11 = new Bai11();
            bai11.Show(); bai11.MdiParent = this;
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1C2 bai1C2 = new Bai1C2();
            bai1C2.Show(); bai1C2.MdiParent = this;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog(); about.MdiParent = this;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
             "Bạn có muốn thoát không?",
             "Thông báo",
             MessageBoxButtons.OKCancel
            );

            if (kq == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bài8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai8C2 bai8C2 = new Bai8C2();
            bai8C2.Show(); bai8C2.MdiParent = this;
        }

        private void bài9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bai9C2 bai9C2 = new Bai9C2();
            bai9C2.Show(); bai9C2.MdiParent = this;
        }
    }
}
