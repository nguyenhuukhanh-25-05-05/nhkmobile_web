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
    public partial class FormAbout : Form
    {
        Label lblTitle, lblName, lblVersion, lblAuthor;
        Button btnOK;
        public FormAbout()
        {
            InitializeComponent();
            this.Text = "About";
            this.Size = new Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ShowInTaskbar = false;

            lblTitle = new Label();
            lblTitle.Text = "THÔNG TIN CHƯƠNG TRÌNH";
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(60, 20);

            lblName = new Label();
            lblName.Text = "Tên: Quản lý bài tập WinForms";
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 70);

            lblVersion = new Label();
            lblVersion.Text = "Version: 1.0";
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(50, 100);

            lblAuthor = new Label();
            lblAuthor.Text = "Tác giả: Dao Chi Thien";
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(50, 130);

            btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Size = new Size(80, 30);
            btnOK.Location = new Point(150, 170);
            btnOK.Click += BtnOK_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblName);
            this.Controls.Add(lblVersion);
            this.Controls.Add(lblAuthor);
            this.Controls.Add(btnOK);
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
