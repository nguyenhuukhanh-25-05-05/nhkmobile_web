namespace LTUD_C.Thiện
{
    partial class Bai9
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
            label1 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            groupBox1 = new GroupBox();
            lstA = new ListBox();
            groupBox2 = new GroupBox();
            lstB = new ListBox();
            btnXoa = new Button();
            btnKetThuc = new Button();
            btnA1 = new Button();
            btnA2 = new Button();
            btnB1 = new Button();
            btnB2 = new Button();
            cboLop = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 54);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 83);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(139, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(445, 31);
            txtTen.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(616, 83);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(131, 34);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstA);
            groupBox1.Location = new Point(44, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 291);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstA
            // 
            lstA.FormattingEnabled = true;
            lstA.ItemHeight = 25;
            lstA.Location = new Point(6, 30);
            lstA.Name = "lstA";
            lstA.Size = new Size(288, 254);
            lstA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstB);
            groupBox2.Location = new Point(447, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 291);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstB
            // 
            lstB.FormattingEnabled = true;
            lstB.ItemHeight = 25;
            lstB.Location = new Point(6, 31);
            lstB.Name = "lstB";
            lstB.Size = new Size(288, 254);
            lstB.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(129, 433);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(550, 435);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(112, 34);
            btnKetThuc.TabIndex = 7;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnA1
            // 
            btnA1.Location = new Point(350, 169);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(91, 34);
            btnA1.TabIndex = 8;
            btnA1.Text = ">";
            btnA1.UseVisualStyleBackColor = true;
            btnA1.Click += btnA1_Click;
            // 
            // btnA2
            // 
            btnA2.Location = new Point(350, 209);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(91, 34);
            btnA2.TabIndex = 9;
            btnA2.Text = ">>";
            btnA2.UseVisualStyleBackColor = true;
            btnA2.Click += btnA2_Click;
            // 
            // btnB1
            // 
            btnB1.Location = new Point(350, 249);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(91, 34);
            btnB1.TabIndex = 10;
            btnB1.Text = "<";
            btnB1.UseVisualStyleBackColor = true;
            btnB1.Click += btnB1_Click;
            // 
            // btnB2
            // 
            btnB2.Location = new Point(350, 289);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(91, 34);
            btnB2.TabIndex = 11;
            btnB2.Text = "<<";
            btnB2.UseVisualStyleBackColor = true;
            btnB2.Click += btnB2_Click;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(310, 435);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(182, 33);
            cboLop.TabIndex = 12;
            // 
            // Bai9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(cboLop);
            Controls.Add(btnB2);
            Controls.Add(btnB1);
            Controls.Add(btnA2);
            Controls.Add(btnA1);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai9";
            Text = "Bai9";
            Load += Bai9_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTen;
        private Button btnCapNhat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnKetThuc;
        private Button btnA1;
        private Button btnA2;
        private Button btnB1;
        private Button btnB2;
        private ListBox lstA;
        private ListBox lstB;
        private ComboBox cboLop;
    }
}