namespace BaiTapWinForm
{
    partial class Bai5
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
            btnExit5 = new Button();
            grpFonts5 = new GroupBox();
            radCourier5 = new RadioButton();
            radTahoma5 = new RadioButton();
            radArial5 = new RadioButton();
            radTimes5 = new RadioButton();
            txtDisplay5 = new TextBox();
            lblInput5 = new Label();
            grpFonts5.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit5
            // 
            btnExit5.Location = new Point(207, 356);
            btnExit5.Margin = new Padding(4);
            btnExit5.Name = "btnExit5";
            btnExit5.Size = new Size(94, 50);
            btnExit5.TabIndex = 4;
            btnExit5.Text = "Thoát";
            btnExit5.Click += btnExit5_Click;
            // 
            // grpFonts5
            // 
            grpFonts5.Controls.Add(radCourier5);
            grpFonts5.Controls.Add(radTahoma5);
            grpFonts5.Controls.Add(radArial5);
            grpFonts5.Controls.Add(radTimes5);
            grpFonts5.Location = new Point(432, 81);
            grpFonts5.Margin = new Padding(4);
            grpFonts5.Name = "grpFonts5";
            grpFonts5.Padding = new Padding(4);
            grpFonts5.Size = new Size(225, 250);
            grpFonts5.TabIndex = 5;
            grpFonts5.TabStop = false;
            grpFonts5.Text = "Fonts";
            // 
            // radCourier5
            // 
            radCourier5.Location = new Point(25, 200);
            radCourier5.Margin = new Padding(4);
            radCourier5.Name = "radCourier5";
            radCourier5.Size = new Size(130, 30);
            radCourier5.TabIndex = 0;
            radCourier5.Text = "Courier New";
            radCourier5.Click += radCourierNew_CheckedChanged;
            // 
            // radTahoma5
            // 
            radTahoma5.Location = new Point(25, 150);
            radTahoma5.Margin = new Padding(4);
            radTahoma5.Name = "radTahoma5";
            radTahoma5.Size = new Size(130, 30);
            radTahoma5.TabIndex = 1;
            radTahoma5.Text = "Tahoma";
            radTahoma5.Click += radTahoma_CheckedChanged;
            // 
            // radArial5
            // 
            radArial5.Location = new Point(25, 100);
            radArial5.Margin = new Padding(4);
            radArial5.Name = "radArial5";
            radArial5.Size = new Size(130, 30);
            radArial5.TabIndex = 2;
            radArial5.Text = "Arial";
            radArial5.Click += radArial_CheckedChanged;
            // 
            // radTimes5
            // 
            radTimes5.Location = new Point(25, 50);
            radTimes5.Margin = new Padding(4);
            radTimes5.Name = "radTimes5";
            radTimes5.Size = new Size(130, 30);
            radTimes5.TabIndex = 3;
            radTimes5.Text = "Times New Roman";
            radTimes5.Click += radTimesNewRoman_CheckedChanged;
            // 
            // txtDisplay5
            // 
            txtDisplay5.Location = new Point(144, 81);
            txtDisplay5.Margin = new Padding(4);
            txtDisplay5.Multiline = true;
            txtDisplay5.Name = "txtDisplay5";
            txtDisplay5.Size = new Size(249, 249);
            txtDisplay5.TabIndex = 6;
            txtDisplay5.Text = "WHAT FONT IS THIS?";
            // 
            // lblInput5
            // 
            lblInput5.Location = new Point(144, 44);
            lblInput5.Margin = new Padding(4, 0, 4, 0);
            lblInput5.Name = "lblInput5";
            lblInput5.Size = new Size(250, 34);
            lblInput5.TabIndex = 7;
            lblInput5.Text = "Nhập văn bản:";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit5);
            Controls.Add(grpFonts5);
            Controls.Add(txtDisplay5);
            Controls.Add(lblInput5);
            Name = "Bai5";
            Text = "Bai5";
            Load += Bai5_Load;
            Click += Bai5_Load;
            grpFonts5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit5;
        private GroupBox grpFonts5;
        private RadioButton radCourier5;
        private RadioButton radTahoma5;
        private RadioButton radArial5;
        private RadioButton radTimes5;
        private TextBox txtDisplay5;
        private Label lblInput5;
    }
}