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
    public partial class Bai8C2 : Form
    {
        public Bai8C2()
        {
            InitializeComponent();
        }

        private void Bai8C2_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView1.Nodes.Add(c.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string lastname = txtTen2.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show("Nhập tên!");
                return;
            }

            char first = char.ToUpper(ten[0]);

            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text[0] == first)
                {
                    node.Nodes.Add(ten+" "+lastname);
                    node.Expand(); 
                    break;
                }
            }

            txtTen.Clear();
            txtTen.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
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
