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
    public partial class Bai9C2 : Form
    {
        public Bai9C2()
        {
            InitializeComponent();
        }

        private void Bai9C2_Load(object sender, EventArgs e)
        {
            lvSV.View = View.Details;
            lvSV.Columns.Add("Ten SV", 150); 
            lvSV.Columns.Add("Lop", 100);

            TreeNode khoa = new TreeNode("Khoa Tin Hoc");

            TreeNode lop1 = new TreeNode("THTH5A");
            lop1.Nodes.Add(new TreeNode("Nguyen van Tuan"));
            lop1.Nodes.Add(new TreeNode("Nguyen thi Lan"));
            lop1.Nodes.Add(new TreeNode("Nguyen van Luong"));

            TreeNode lop2 = new TreeNode("THTH5B");
            lop2.Nodes.Add(new TreeNode("le Nghiep"));
            lop2.Nodes.Add(new TreeNode("Tran Long"));
            lop2.Nodes.Add(new TreeNode("Ly Hai"));

            khoa.Nodes.Add(lop1);
            khoa.Nodes.Add(lop2);

            treeView1.Nodes.Add(khoa);
            treeView1.ExpandAll();

            txtTim.Focus();


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvSV.Items.Clear();
            TreeNode node = e.Node;

            if (node.Level == 0) 
            {
                foreach (TreeNode lop in node.Nodes)
                {
                    foreach (TreeNode sv in lop.Nodes)
                    {
                        ListViewItem lvi = new ListViewItem(sv.Text);
                        lvi.SubItems.Add(lop.Text); 
                        lvSV.Items.Add(lvi);
                    }
                }
            }
            else if (node.Level == 1) 
            {
                foreach (TreeNode sv in node.Nodes)
                {
                    ListViewItem lvi = new ListViewItem(sv.Text);
                    lvi.SubItems.Add(node.Text); 
                    lvSV.Items.Add(lvi);
                }
            }
            else if (node.Level == 2) 
            {
                ListViewItem lvi = new ListViewItem(node.Text);
                lvi.SubItems.Add(node.Parent.Text); 
                lvSV.Items.Add(lvi);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text.Trim().ToLower();

            if (key == "")
            {
                MessageBox.Show("Nhập tên cần tìm!");
                return;
            }

            lvSV.Items.Clear();
            TreeNode node = treeView1.SelectedNode;

            if (node == null) return;

            if (node.Level == 0)
            {
                foreach (TreeNode lop in node.Nodes)
                {
                    foreach (TreeNode sv in lop.Nodes)
                    {
                        if (sv.Text.ToLower().Contains(key))
                        {
                            ListViewItem lvi = new ListViewItem(sv.Text);
                            lvi.SubItems.Add(lop.Text);
                            lvSV.Items.Add(lvi);
                        }
                    }
                }
            }
            else if (node.Level == 1)
            {
                foreach (TreeNode sv in node.Nodes)
                {
                    if (sv.Text.ToLower().Contains(key))
                    {
                        ListViewItem lvi = new ListViewItem(sv.Text);
                        lvi.SubItems.Add(node.Text);
                        lvSV.Items.Add(lvi);
                    }
                }
            }
            else if (node.Level == 2)
            {
                if (node.Text.ToLower().Contains(key))
                {
                    ListViewItem lvi = new ListViewItem(node.Text);
                    lvi.SubItems.Add(node.Parent.Text);
                    lvSV.Items.Add(lvi);
                }
            }
        }
    }
}