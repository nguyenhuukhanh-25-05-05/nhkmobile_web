namespace LTUD_C.Thiện
{
    partial class bai10
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
            txtMSSV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboLienKhoa = new ComboBox();
            btnKetThuc = new Button();
            label3 = new Label();
            txtHoTen = new TextBox();
            cboLop = new ComboBox();
            radI = new RadioButton();
            radII = new RadioButton();
            radIII = new RadioButton();
            radIV = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(164, 71);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(181, 31);
            txtMSSV.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 71);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 14;
            label2.Text = "MSSV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(201, -5);
            label1.Name = "label1";
            label1.Size = new Size(342, 54);
            label1.TabIndex = 13;
            label1.Text = "Đăng kí môn học";
            // 
            // cboLienKhoa
            // 
            cboLienKhoa.FormattingEnabled = true;
            cboLienKhoa.Location = new Point(163, 168);
            cboLienKhoa.Name = "cboLienKhoa";
            cboLienKhoa.Size = new Size(229, 33);
            cboLienKhoa.TabIndex = 25;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(431, 473);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(112, 34);
            btnKetThuc.TabIndex = 20;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 119);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 26;
            label3.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(163, 119);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(445, 31);
            txtHoTen.TabIndex = 27;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(163, 216);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(229, 33);
            cboLop.TabIndex = 28;
            // 
            // radI
            // 
            radI.AutoSize = true;
            radI.Location = new Point(164, 266);
            radI.Name = "radI";
            radI.Size = new Size(42, 29);
            radI.TabIndex = 29;
            radI.TabStop = true;
            radI.Text = "I";
            radI.UseVisualStyleBackColor = true;
            // 
            // radII
            // 
            radII.AutoSize = true;
            radII.Location = new Point(245, 266);
            radII.Name = "radII";
            radII.Size = new Size(47, 29);
            radII.TabIndex = 30;
            radII.TabStop = true;
            radII.Text = "II";
            radII.UseVisualStyleBackColor = true;
            // 
            // radIII
            // 
            radIII.AutoSize = true;
            radIII.Location = new Point(340, 266);
            radIII.Name = "radIII";
            radIII.Size = new Size(52, 29);
            radIII.TabIndex = 31;
            radIII.TabStop = true;
            radIII.Text = "III";
            radIII.UseVisualStyleBackColor = true;
            // 
            // radIV
            // 
            radIV.AutoSize = true;
            radIV.Location = new Point(436, 266);
            radIV.Name = "radIV";
            radIV.Size = new Size(53, 29);
            radIV.TabIndex = 32;
            radIV.TabStop = true;
            radIV.Text = "IV";
            radIV.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(163, 311);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(326, 144);
            checkedListBox1.TabIndex = 33;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(129, 473);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(112, 34);
            btnDangKy.TabIndex = 34;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(280, 473);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 171);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 36;
            label4.Text = "Niên khóa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 219);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 37;
            label5.Text = "Lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 266);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 38;
            label6.Text = "Học kỳ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 311);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 39;
            label7.Text = "Môn học";
            // 
            // bai10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 561);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(checkedListBox1);
            Controls.Add(radIV);
            Controls.Add(radIII);
            Controls.Add(radII);
            Controls.Add(radI);
            Controls.Add(cboLop);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(txtMSSV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboLienKhoa);
            Controls.Add(btnKetThuc);
            Name = "bai10";
            Text = "bai10";
            Load += bai10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMSSV;
        private Label label2;
        private Label label1;
        private ComboBox cboLienKhoa;
        private Button btnKetThuc;
        private Label label3;
        private TextBox txtHoTen;
        private ComboBox cboLop;
        private RadioButton radI;
        private RadioButton radII;
        private RadioButton radIII;
        private RadioButton radIV;
        private CheckedListBox checkedListBox1;
        private Button btnDangKy;
        private Button btnHuy;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}