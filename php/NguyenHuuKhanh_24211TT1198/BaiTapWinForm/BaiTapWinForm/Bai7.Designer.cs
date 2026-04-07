namespace BaiTapWinForm
{
    partial class Bai7
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
            btnExit7 = new Button();
            btnCountPrime7 = new Button();
            btnCountEven7 = new Button();
            btnSum7 = new Button();
            lstDivisors7 = new ListBox();
            lblDivisors7 = new Label();
            cboNum7 = new ComboBox();
            btnUpdate7 = new Button();
            txtNum7 = new TextBox();
            lblNum7 = new Label();
            SuspendLayout();
            // 
            // btnExit7
            // 
            btnExit7.Location = new Point(332, 359);
            btnExit7.Margin = new Padding(4);
            btnExit7.Name = "btnExit7";
            btnExit7.Size = new Size(94, 45);
            btnExit7.TabIndex = 10;
            btnExit7.Text = "Thoát";
            btnExit7.Click += btnExit7_Click;
            // 
            // btnCountPrime7
            // 
            btnCountPrime7.Location = new Point(456, 359);
            btnCountPrime7.Margin = new Padding(4);
            btnCountPrime7.Name = "btnCountPrime7";
            btnCountPrime7.Size = new Size(225, 45);
            btnCountPrime7.TabIndex = 11;
            btnCountPrime7.Text = "Số lượng các ước số nguyên tố";
            btnCountPrime7.Click += btnCountPrime7_Click;
            // 
            // btnCountEven7
            // 
            btnCountEven7.Location = new Point(456, 309);
            btnCountEven7.Margin = new Padding(4);
            btnCountEven7.Name = "btnCountEven7";
            btnCountEven7.Size = new Size(225, 45);
            btnCountEven7.TabIndex = 12;
            btnCountEven7.Text = "Số lượng các ước số chẵn";
            btnCountEven7.Click += btnCountEven7_Click;
            // 
            // btnSum7
            // 
            btnSum7.Location = new Point(456, 259);
            btnSum7.Margin = new Padding(4);
            btnSum7.Name = "btnSum7";
            btnSum7.Size = new Size(225, 45);
            btnSum7.TabIndex = 13;
            btnSum7.Text = "Tổng các ước số";
            btnSum7.Click += btnSum7_Click;
            // 
            // lstDivisors7
            // 
            lstDivisors7.ItemHeight = 25;
            lstDivisors7.Location = new Point(456, 84);
            lstDivisors7.Margin = new Padding(4);
            lstDivisors7.Name = "lstDivisors7";
            lstDivisors7.Size = new Size(224, 154);
            lstDivisors7.TabIndex = 14;
            // 
            // lblDivisors7
            // 
            lblDivisors7.Location = new Point(456, 47);
            lblDivisors7.Margin = new Padding(4, 0, 4, 0);
            lblDivisors7.Name = "lblDivisors7";
            lblDivisors7.Size = new Size(225, 29);
            lblDivisors7.TabIndex = 15;
            lblDivisors7.Text = "Danh sách các ước số";
            // 
            // cboNum7
            // 
            cboNum7.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNum7.Location = new Point(119, 147);
            cboNum7.Margin = new Padding(4);
            cboNum7.Name = "cboNum7";
            cboNum7.Size = new Size(306, 33);
            cboNum7.TabIndex = 16;
            cboNum7.Click += cboNum7_SelectedIndexChanged;
            // 
            // btnUpdate7
            // 
            btnUpdate7.Location = new Point(293, 73);
            btnUpdate7.Margin = new Padding(4);
            btnUpdate7.Name = "btnUpdate7";
            btnUpdate7.Size = new Size(132, 56);
            btnUpdate7.TabIndex = 17;
            btnUpdate7.Text = "Cập nhật";
            btnUpdate7.Click += btnUpdate7_Click;
            // 
            // txtNum7
            // 
            txtNum7.Location = new Point(119, 84);
            txtNum7.Margin = new Padding(4);
            txtNum7.Name = "txtNum7";
            txtNum7.Size = new Size(149, 31);
            txtNum7.TabIndex = 18;
            // 
            // lblNum7
            // 
            lblNum7.Location = new Point(119, 47);
            lblNum7.Margin = new Padding(4, 0, 4, 0);
            lblNum7.Name = "lblNum7";
            lblNum7.Size = new Size(125, 29);
            lblNum7.TabIndex = 19;
            lblNum7.Text = "Nhập Số";
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit7);
            Controls.Add(btnCountPrime7);
            Controls.Add(btnCountEven7);
            Controls.Add(btnSum7);
            Controls.Add(lstDivisors7);
            Controls.Add(lblDivisors7);
            Controls.Add(cboNum7);
            Controls.Add(btnUpdate7);
            Controls.Add(txtNum7);
            Controls.Add(lblNum7);
            Name = "Bai7";
            Text = "Bai7";
            Load += Bai7_Load;
            Click += btnCountEven7_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit7;
        private Button btnCountPrime7;
        private Button btnCountEven7;
        private Button btnSum7;
        private ListBox lstDivisors7;
        private Label lblDivisors7;
        private ComboBox cboNum7;
        private Button btnUpdate7;
        private TextBox txtNum7;
        private Label lblNum7;
    }
}