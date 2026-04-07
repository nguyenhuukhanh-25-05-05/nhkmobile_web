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
    public partial class Bai1C2 : Form
    {
        public Bai1C2()
        {
            InitializeComponent();
        }

        private void Bai1C2_Load(object sender, EventArgs e)
        {
            cboCountry.Items.Add("Vietnam");
            cboCountry.Items.Add("Thailand");

            lstCity.Items.Add("Hồ Chí Minh");
            lstCity.Items.Add("Nha Trang");
            lstCity.Items.Add("Hà Nội");

            lstQualification.Items.Add("University");
            lstQualification.Items.Add("Master");
            lstQualification.Items.Add("PhD");

            cboCountry.SelectedIndex = -1;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!");
                txtName.Focus();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!");
                txtName.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống!");
                txtName.Focus();
            }
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCity.Items.Clear();

            if (cboCountry.Text == "Vietnam")
            {
                lstCity.Items.Add("Hồ Chí Minh");
                lstCity.Items.Add("Nha Trang");
                lstCity.Items.Add("Hà Nội");
            }
            else if (cboCountry.Text == "Thailand")
            {
                lstCity.Items.Add("Bangkok");
                lstCity.Items.Add("Pattaya");
                lstCity.Items.Add("Chiang Mai");
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            string kq =
        "Name: " + txtName.Text + "\n" +
        "DOB: " + mtxtDOB.Text + "\n" +
        "Address: " + txtAddress.Text + "\n" +
        "City: " + lstCity.Text + "\n" +
        "Country: " + cboCountry.Text + "\n" +
        "Qualification: " + lstQualification.Text + "\n" +
        "Phone: " + mtxtPhone.Text + "\n" +
        "Email: " + txtEmail.Text + "\n" +
        "Joining Date: " + dtpJoin.Value.ToShortDateString();

            MessageBox.Show(kq, "Thông tin");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
