namespace BaiTapWinForm
{
    partial class Bai8
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
            btnEnd8 = new Button();
            grpOps8 = new GroupBox();
            btnSelectOdd8 = new Button();
            btnSelectEven8 = new Button();
            btnSquare8 = new Button();
            btnIncr2_8 = new Button();
            btnDelSelected8 = new Button();
            btnDelFirstLast8 = new Button();
            btnSum8 = new Button();
            lstNumbers8 = new ListBox();
            btnInsert8 = new Button();
            txtInput8 = new TextBox();
            lblInput8 = new Label();
            lblTitle8 = new Label();
            grpOps8.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnd8
            // 
            btnEnd8.Location = new Point(119, 499);
            btnEnd8.Name = "btnEnd8";
            btnEnd8.Size = new Size(562, 33);
            btnEnd8.TabIndex = 0;
            btnEnd8.Text = "Ket Thuc";
            btnEnd8.Click += btnEnd8_Click;
            // 
            // grpOps8
            // 
            grpOps8.Controls.Add(btnSelectOdd8);
            grpOps8.Controls.Add(btnSelectEven8);
            grpOps8.Controls.Add(btnSquare8);
            grpOps8.Controls.Add(btnIncr2_8);
            grpOps8.Controls.Add(btnDelSelected8);
            grpOps8.Controls.Add(btnDelFirstLast8);
            grpOps8.Controls.Add(btnSum8);
            grpOps8.Location = new Point(343, 92);
            grpOps8.Margin = new Padding(4);
            grpOps8.Name = "grpOps8";
            grpOps8.Padding = new Padding(4);
            grpOps8.Size = new Size(338, 380);
            grpOps8.TabIndex = 8;
            grpOps8.TabStop = false;
            grpOps8.Text = "Xử lý Listbox";
            // 
            // btnSelectOdd8
            // 
            btnSelectOdd8.Location = new Point(25, 338);
            btnSelectOdd8.Margin = new Padding(4);
            btnSelectOdd8.Name = "btnSelectOdd8";
            btnSelectOdd8.Size = new Size(288, 36);
            btnSelectOdd8.TabIndex = 0;
            btnSelectOdd8.Text = "Chọn số lẻ";
            // 
            // btnSelectEven8
            // 
            btnSelectEven8.Location = new Point(25, 288);
            btnSelectEven8.Margin = new Padding(4);
            btnSelectEven8.Name = "btnSelectEven8";
            btnSelectEven8.Size = new Size(288, 36);
            btnSelectEven8.TabIndex = 1;
            btnSelectEven8.Text = "Chọn số chẵn";
            // 
            // btnSquare8
            // 
            btnSquare8.Location = new Point(25, 238);
            btnSquare8.Margin = new Padding(4);
            btnSquare8.Name = "btnSquare8";
            btnSquare8.Size = new Size(288, 36);
            btnSquare8.TabIndex = 2;
            btnSquare8.Text = "Thay bằng bình phương";
            // 
            // btnIncr2_8
            // 
            btnIncr2_8.Location = new Point(25, 188);
            btnIncr2_8.Margin = new Padding(4);
            btnIncr2_8.Name = "btnIncr2_8";
            btnIncr2_8.Size = new Size(288, 36);
            btnIncr2_8.TabIndex = 3;
            btnIncr2_8.Text = "Tăng mỗi phần tử lên 2";
            // 
            // btnDelSelected8
            // 
            btnDelSelected8.Location = new Point(25, 138);
            btnDelSelected8.Margin = new Padding(4);
            btnDelSelected8.Name = "btnDelSelected8";
            btnDelSelected8.Size = new Size(288, 36);
            btnDelSelected8.TabIndex = 4;
            btnDelSelected8.Text = "Xóa Phần tử đang chọn";
            // 
            // btnDelFirstLast8
            // 
            btnDelFirstLast8.Location = new Point(25, 88);
            btnDelFirstLast8.Margin = new Padding(4);
            btnDelFirstLast8.Name = "btnDelFirstLast8";
            btnDelFirstLast8.Size = new Size(288, 36);
            btnDelFirstLast8.TabIndex = 5;
            btnDelFirstLast8.Text = "Xóa Phần tử đầu và cuối";
            // 
            // btnSum8
            // 
            btnSum8.Location = new Point(25, 38);
            btnSum8.Margin = new Padding(4);
            btnSum8.Name = "btnSum8";
            btnSum8.Size = new Size(288, 36);
            btnSum8.TabIndex = 6;
            btnSum8.Text = "Tổng các phần tử trong List";
            // 
            // lstNumbers8
            // 
            lstNumbers8.ItemHeight = 25;
            lstNumbers8.Location = new Point(119, 217);
            lstNumbers8.Margin = new Padding(4);
            lstNumbers8.Name = "lstNumbers8";
            lstNumbers8.SelectionMode = SelectionMode.MultiExtended;
            lstNumbers8.Size = new Size(186, 254);
            lstNumbers8.TabIndex = 9;
            // 
            // btnInsert8
            // 
            btnInsert8.Location = new Point(119, 167);
            btnInsert8.Margin = new Padding(4);
            btnInsert8.Name = "btnInsert8";
            btnInsert8.Size = new Size(188, 42);
            btnInsert8.TabIndex = 10;
            btnInsert8.Text = "Nhập";
            // 
            // txtInput8
            // 
            txtInput8.Location = new Point(119, 123);
            txtInput8.Margin = new Padding(4);
            txtInput8.Name = "txtInput8";
            txtInput8.Size = new Size(186, 31);
            txtInput8.TabIndex = 11;
            // 
            // lblInput8
            // 
            lblInput8.Location = new Point(119, 92);
            lblInput8.Margin = new Padding(4, 0, 4, 0);
            lblInput8.Name = "lblInput8";
            lblInput8.Size = new Size(125, 29);
            lblInput8.TabIndex = 12;
            lblInput8.Text = "Listbox";
            // 
            // lblTitle8
            // 
            lblTitle8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle8.ForeColor = Color.FromArgb(255, 128, 0);
            lblTitle8.Location = new Point(306, 29);
            lblTitle8.Margin = new Padding(4, 0, 4, 0);
            lblTitle8.Name = "lblTitle8";
            lblTitle8.Size = new Size(226, 59);
            lblTitle8.TabIndex = 13;
            lblTitle8.Text = "LISTBOX";
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(btnEnd8);
            Controls.Add(grpOps8);
            Controls.Add(lstNumbers8);
            Controls.Add(btnInsert8);
            Controls.Add(txtInput8);
            Controls.Add(lblInput8);
            Controls.Add(lblTitle8);
            Name = "Bai8";
            Text = "Bai8";
            Load += Bai8_Load;
            grpOps8.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnd8;
        private GroupBox grpOps8;
        private Button btnSelectOdd8;
        private Button btnSelectEven8;
        private Button btnSquare8;
        private Button btnIncr2_8;
        private Button btnDelSelected8;
        private Button btnDelFirstLast8;
        private Button btnSum8;
        private ListBox lstNumbers8;
        private Button btnInsert8;
        private TextBox txtInput8;
        private Label lblInput8;
        private Label lblTitle8;
    }
}