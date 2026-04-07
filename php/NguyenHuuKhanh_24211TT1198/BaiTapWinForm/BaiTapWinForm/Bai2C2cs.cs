using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapWinForm;

namespace LTUD_C.Thiện
{
    public partial class Bai2C2cs : Form
    {
        public Bai2C2cs()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
            listView1.View = View.Details;

            listView1.Columns.Add("Mô tả");

            listView1.Items.Add(new ListViewItem(new string[] {
               "Mục tiêu của chương trình là liên kết tất cả các bài tập đã làm để tiện quản lí"
            }));

            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;

            if (progressBar1.Value >= 150)
            {
                timer1.Stop();

                Form1 f = new Form1();
                f.Show();

                this.Hide();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
