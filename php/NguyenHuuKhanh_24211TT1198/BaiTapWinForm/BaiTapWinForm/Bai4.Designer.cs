namespace BaiTapWinForm
{
    partial class Bai4
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
            btnExit4 = new Button();
            lblDisplay4 = new Label();
            grpFont4 = new GroupBox();
            chkUnderline4 = new CheckBox();
            chkItalic4 = new CheckBox();
            chkBold4 = new CheckBox();
            grpColor4 = new GroupBox();
            radBlack4 = new RadioButton();
            radBlue4 = new RadioButton();
            radGreen4 = new RadioButton();
            radRed4 = new RadioButton();
            txtInput4 = new TextBox();
            lblInput4 = new Label();
            grpFont4.SuspendLayout();
            grpColor4.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit4
            // 
            btnExit4.Location = new Point(552, 346);
            btnExit4.Margin = new Padding(4);
            btnExit4.Name = "btnExit4";
            btnExit4.Size = new Size(94, 45);
            btnExit4.TabIndex = 6;
            btnExit4.Text = "Thoát";
            btnExit4.Click += btnExit4_Click;
            // 
            // lblDisplay4
            // 
            lblDisplay4.Location = new Point(132, 351);
            lblDisplay4.Margin = new Padding(4, 0, 4, 0);
            lblDisplay4.Name = "lblDisplay4";
            lblDisplay4.Size = new Size(348, 29);
            lblDisplay4.TabIndex = 7;
            lblDisplay4.Text = "Lập Trình Bởi:";
            // 
            // grpFont4
            // 
            grpFont4.Controls.Add(chkUnderline4);
            grpFont4.Controls.Add(chkItalic4);
            grpFont4.Controls.Add(chkBold4);
            grpFont4.Location = new Point(406, 126);
            grpFont4.Margin = new Padding(4);
            grpFont4.Name = "grpFont4";
            grpFont4.Padding = new Padding(4);
            grpFont4.Size = new Size(262, 188);
            grpFont4.TabIndex = 8;
            grpFont4.TabStop = false;
            grpFont4.Text = "Font";
            // 
            // chkUnderline4
            // 
            chkUnderline4.Location = new Point(25, 112);
            chkUnderline4.Margin = new Padding(4);
            chkUnderline4.Name = "chkUnderline4";
            chkUnderline4.Size = new Size(130, 30);
            chkUnderline4.TabIndex = 0;
            chkUnderline4.Text = "Gạch chân";
            chkUnderline4.Click += chkUnderline4_CheckedChanged;
            // 
            // chkItalic4
            // 
            chkItalic4.Location = new Point(25, 75);
            chkItalic4.Margin = new Padding(4);
            chkItalic4.Name = "chkItalic4";
            chkItalic4.Size = new Size(130, 30);
            chkItalic4.TabIndex = 1;
            chkItalic4.Text = "Nghiêng Italic";
            chkItalic4.Click += chkItalic4_CheckedChanged;
            // 
            // chkBold4
            // 
            chkBold4.Location = new Point(25, 38);
            chkBold4.Margin = new Padding(4);
            chkBold4.Name = "chkBold4";
            chkBold4.Size = new Size(130, 30);
            chkBold4.TabIndex = 2;
            chkBold4.Text = "Đậm Bold";
            chkBold4.Click += chkBold4_CheckedChanged;
            // 
            // grpColor4
            // 
            grpColor4.Controls.Add(radBlack4);
            grpColor4.Controls.Add(radBlue4);
            grpColor4.Controls.Add(radGreen4);
            grpColor4.Controls.Add(radRed4);
            grpColor4.Location = new Point(132, 126);
            grpColor4.Margin = new Padding(4);
            grpColor4.Name = "grpColor4";
            grpColor4.Padding = new Padding(4);
            grpColor4.Size = new Size(225, 188);
            grpColor4.TabIndex = 9;
            grpColor4.TabStop = false;
            grpColor4.Text = "Color";
            // 
            // radBlack4
            // 
            radBlack4.Checked = true;
            radBlack4.Location = new Point(25, 150);
            radBlack4.Margin = new Padding(4);
            radBlack4.Name = "radBlack4";
            radBlack4.Size = new Size(130, 30);
            radBlack4.TabIndex = 0;
            radBlack4.TabStop = true;
            radBlack4.Text = "Black";
            radBlack4.Click += radBlack4_CheckedChanged;
            // 
            // radBlue4
            // 
            radBlue4.ForeColor = Color.Blue;
            radBlue4.Location = new Point(25, 112);
            radBlue4.Margin = new Padding(4);
            radBlue4.Name = "radBlue4";
            radBlue4.Size = new Size(130, 30);
            radBlue4.TabIndex = 1;
            radBlue4.Text = "Blue";
            radBlue4.Click += radBlue4_CheckedChanged;
            // 
            // radGreen4
            // 
            radGreen4.ForeColor = Color.Green;
            radGreen4.Location = new Point(25, 75);
            radGreen4.Margin = new Padding(4);
            radGreen4.Name = "radGreen4";
            radGreen4.Size = new Size(130, 30);
            radGreen4.TabIndex = 2;
            radGreen4.Text = "Green";
            radGreen4.Click += radGreen4_CheckedChanged;
            // 
            // radRed4
            // 
            radRed4.ForeColor = Color.Red;
            radRed4.Location = new Point(25, 38);
            radRed4.Margin = new Padding(4);
            radRed4.Name = "radRed4";
            radRed4.Size = new Size(130, 30);
            radRed4.TabIndex = 3;
            radRed4.Text = "Red";
            radRed4.Click += radRed4_CheckedChanged;
            // 
            // txtInput4
            // 
            txtInput4.Location = new Point(232, 60);
            txtInput4.Margin = new Padding(4);
            txtInput4.Name = "txtInput4";
            txtInput4.Size = new Size(436, 31);
            txtInput4.TabIndex = 10;
            txtInput4.Click += txtInput4_TextChanged;
            // 
            // lblInput4
            // 
            lblInput4.Location = new Point(132, 64);
            lblInput4.Margin = new Padding(4, 0, 4, 0);
            lblInput4.Name = "lblInput4";
            lblInput4.Size = new Size(125, 29);
            lblInput4.TabIndex = 11;
            lblInput4.Text = "Nhập Tên:";
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit4);
            Controls.Add(lblDisplay4);
            Controls.Add(grpFont4);
            Controls.Add(grpColor4);
            Controls.Add(txtInput4);
            Controls.Add(lblInput4);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            Click += Bai4_Load;
            grpFont4.ResumeLayout(false);
            grpColor4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit4;
        private Label lblDisplay4;
        private GroupBox grpFont4;
        private CheckBox chkUnderline4;
        private CheckBox chkItalic4;
        private CheckBox chkBold4;
        private GroupBox grpColor4;
        private RadioButton radBlack4;
        private RadioButton radBlue4;
        private RadioButton radGreen4;
        private RadioButton radRed4;
        private TextBox txtInput4;
        private Label lblInput4;
    }
}