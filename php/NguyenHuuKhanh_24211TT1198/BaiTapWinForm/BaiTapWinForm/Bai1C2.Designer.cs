namespace LTUD_C.Thiện
{
    partial class Bai1C2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            mtxtDOB = new MaskedTextBox();
            txtAddress = new TextBox();
            lstCity = new ListBox();
            cboCountry = new ComboBox();
            lstQualification = new ListBox();
            mtxtPhone = new MaskedTextBox();
            txtEmail = new TextBox();
            dtpJoin = new DateTimePicker();
            btnSumbit = new Button();
            btnExit = new Button();
            linkLabel1 = new LinkLabel();
            lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(266, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // mtxtDOB
            // 
            mtxtDOB.Location = new Point(266, 64);
            mtxtDOB.Mask = "00/00/0000";
            mtxtDOB.Name = "mtxtDOB";
            mtxtDOB.Size = new Size(150, 31);
            mtxtDOB.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(266, 101);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 2;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // lstCity
            // 
            lstCity.FormattingEnabled = true;
            lstCity.ItemHeight = 25;
            lstCity.Location = new Point(266, 138);
            lstCity.Name = "lstCity";
            lstCity.Size = new Size(180, 129);
            lstCity.TabIndex = 3;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(266, 273);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(182, 33);
            cboCountry.TabIndex = 4;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // lstQualification
            // 
            lstQualification.FormattingEnabled = true;
            lstQualification.ItemHeight = 25;
            lstQualification.Location = new Point(268, 312);
            lstQualification.Name = "lstQualification";
            lstQualification.Size = new Size(180, 129);
            lstQualification.TabIndex = 5;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(268, 447);
            mtxtPhone.Mask = "000-0000000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(150, 31);
            mtxtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(268, 484);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // dtpJoin
            // 
            dtpJoin.Format = DateTimePickerFormat.Custom;
            dtpJoin.Location = new Point(266, 521);
            dtpJoin.Name = "dtpJoin";
            dtpJoin.Size = new Size(300, 31);
            dtpJoin.TabIndex = 8;
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(266, 558);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(112, 34);
            btnSumbit.TabIndex = 9;
            btnSumbit.Text = "Sumbit";
            btnSumbit.UseVisualStyleBackColor = true;
            btnSumbit.Click += btnSumbit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(454, 558);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(170, 563);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 25);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(118, 27);
            lbl.Name = "lbl";
            lbl.Size = new Size(142, 25);
            lbl.TabIndex = 12;
            lbl.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 64);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 13;
            label2.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 101);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 14;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 138);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 15;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 273);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 16;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 312);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 17;
            label6.Text = "Qualification";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(189, 447);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 18;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(189, 484);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 19;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 521);
            label9.Name = "label9";
            label9.Size = new Size(142, 25);
            label9.TabIndex = 20;
            label9.Text = "Date of Joinning";
            // 
            // Bai1C2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 624);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl);
            Controls.Add(linkLabel1);
            Controls.Add(btnExit);
            Controls.Add(btnSumbit);
            Controls.Add(dtpJoin);
            Controls.Add(txtEmail);
            Controls.Add(mtxtPhone);
            Controls.Add(lstQualification);
            Controls.Add(cboCountry);
            Controls.Add(lstCity);
            Controls.Add(txtAddress);
            Controls.Add(mtxtDOB);
            Controls.Add(txtName);
            Name = "Bai1C2";
            Text = "Bai1C2";
            Load += Bai1C2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private MaskedTextBox mtxtDOB;
        private TextBox txtAddress;
        private ListBox lstCity;
        private ComboBox cboCountry;
        private ListBox lstQualification;
        private MaskedTextBox mtxtPhone;
        private TextBox txtEmail;
        private DateTimePicker dtpJoin;
        private Button btnSumbit;
        private Button btnExit;
        private LinkLabel linkLabel1;
        private Label lbl;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}