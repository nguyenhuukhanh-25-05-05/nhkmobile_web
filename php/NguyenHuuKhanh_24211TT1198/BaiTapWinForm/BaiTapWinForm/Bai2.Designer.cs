namespace BaiTapWinForm
{
    partial class Bai2
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
            components = new System.ComponentModel.Container();
            btnExit2 = new Button();
            btnClear2 = new Button();
            btnSolve2 = new Button();
            txtResult2 = new TextBox();
            txtB2 = new TextBox();
            txtA2 = new TextBox();
            lblResult2 = new Label();
            lblB2 = new Label();
            lblA2 = new Label();
            lblTitle2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnExit2
            // 
            btnExit2.Location = new Point(461, 338);
            btnExit2.Margin = new Padding(4);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(94, 50);
            btnExit2.TabIndex = 10;
            btnExit2.Text = "Thoát";
            btnExit2.Click += btnExit2_Click;
            // 
            // btnClear2
            // 
            btnClear2.Location = new Point(298, 338);
            btnClear2.Margin = new Padding(4);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(94, 50);
            btnClear2.TabIndex = 11;
            btnClear2.Text = "Xóa";
            btnClear2.Click += btnClear2_Click;
            // 
            // btnSolve2
            // 
            btnSolve2.Location = new Point(136, 338);
            btnSolve2.Margin = new Padding(4);
            btnSolve2.Name = "btnSolve2";
            btnSolve2.Size = new Size(94, 50);
            btnSolve2.TabIndex = 12;
            btnSolve2.Text = "Giải";
            btnSolve2.Click += btnSolve2_Click;
            // 
            // txtResult2
            // 
            txtResult2.Location = new Point(286, 259);
            txtResult2.Margin = new Padding(4);
            txtResult2.Name = "txtResult2";
            txtResult2.ReadOnly = true;
            txtResult2.Size = new Size(312, 31);
            txtResult2.TabIndex = 13;
            // 
            // txtB2
            // 
            txtB2.Location = new Point(286, 197);
            txtB2.Margin = new Padding(4);
            txtB2.Name = "txtB2";
            txtB2.Size = new Size(312, 31);
            txtB2.TabIndex = 14;
            // 
            // txtA2
            // 
            txtA2.Location = new Point(286, 134);
            txtA2.Margin = new Padding(4);
            txtA2.Name = "txtA2";
            txtA2.Size = new Size(312, 31);
            txtA2.TabIndex = 15;
            // 
            // lblResult2
            // 
            lblResult2.Location = new Point(98, 263);
            lblResult2.Margin = new Padding(4, 0, 4, 0);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(125, 29);
            lblResult2.TabIndex = 16;
            lblResult2.Text = "Nghiệm phương trình";
            // 
            // lblB2
            // 
            lblB2.Location = new Point(98, 200);
            lblB2.Margin = new Padding(4, 0, 4, 0);
            lblB2.Name = "lblB2";
            lblB2.Size = new Size(125, 29);
            lblB2.TabIndex = 17;
            lblB2.Text = "Nhập B";
            // 
            // lblA2
            // 
            lblA2.Location = new Point(98, 138);
            lblA2.Margin = new Padding(4, 0, 4, 0);
            lblA2.Name = "lblA2";
            lblA2.Size = new Size(125, 29);
            lblA2.TabIndex = 18;
            lblA2.Text = "Nhập A";
            // 
            // lblTitle2
            // 
            lblTitle2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle2.ForeColor = Color.Blue;
            lblTitle2.Location = new Point(111, 63);
            lblTitle2.Margin = new Padding(4, 0, 4, 0);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(592, 54);
            lblTitle2.TabIndex = 19;
            lblTitle2.Text = "GIẢI PHƯƠNG TRÌNH AX + B = 0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit2);
            Controls.Add(btnClear2);
            Controls.Add(btnSolve2);
            Controls.Add(txtResult2);
            Controls.Add(txtB2);
            Controls.Add(txtA2);
            Controls.Add(lblResult2);
            Controls.Add(lblB2);
            Controls.Add(lblA2);
            Controls.Add(lblTitle2);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit2;
        private Button btnClear2;
        private Button btnSolve2;
        private TextBox txtResult2;
        private TextBox txtB2;
        private TextBox txtA2;
        private Label lblResult2;
        private Label lblB2;
        private Label lblA2;
        private Label lblTitle2;
        private ErrorProvider errorProvider1;
    }
}