using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            radRed4.Checked = true;       
            txtInput4.Focus();            
            this.CancelButton = btnExit4; 
        }

        private void txtInput4_TextChanged(object sender, EventArgs e)
        {
            lblDisplay4.Text = "Lập Trình Bởi: " + txtInput4.Text;
        }
        private void btnExit4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void radRed4_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed4.Checked) { txtInput4.ForeColor = Color.Red; lblDisplay4.ForeColor = Color.Red; }
        }

        private void radGreen4_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen4.Checked) { txtInput4.ForeColor = Color.Green; lblDisplay4.ForeColor = Color.Green; }
        }

        private void radBlue4_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue4.Checked) { txtInput4.ForeColor = Color.Blue; lblDisplay4.ForeColor = Color.Blue; }
        }

        private void radBlack4_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack4.Checked) { txtInput4.ForeColor = Color.Black; lblDisplay4.ForeColor = Color.Black; }
        }

        private void chkBold4_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplay4.Font = new Font(lblDisplay4.Font.Name, lblDisplay4.Font.Size, lblDisplay4.Font.Style ^ FontStyle.Bold);
            txtInput4.Font = new Font(txtInput4.Font.Name, txtInput4.Font.Size, txtInput4.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic4_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplay4.Font = new Font(lblDisplay4.Font.Name, lblDisplay4.Font.Size, lblDisplay4.Font.Style ^ FontStyle.Italic);
            txtInput4.Font = new Font(txtInput4.Font.Name, txtInput4.Font.Size, txtInput4.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline4_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplay4.Font = new Font(lblDisplay4.Font.Name, lblDisplay4.Font.Size, lblDisplay4.Font.Style ^ FontStyle.Underline);
            txtInput4.Font = new Font(txtInput4.Font.Name, txtInput4.Font.Size, txtInput4.Font.Style ^ FontStyle.Underline);
        }
    }
}