namespace BaiTapWinForm
{
    partial class Bai3
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
            grpOps3 = new GroupBox();
            radDiv3 = new RadioButton();
            radMul3 = new RadioButton();
            radSub3 = new RadioButton();
            radAdd3 = new RadioButton();
            txtResult3 = new TextBox();
            txtNum3_2 = new TextBox();
            txtNum3_1 = new TextBox();
            lblResult3 = new Label();
            lblNum3_2 = new Label();
            lblNum3_1 = new Label();
            grpOps3.SuspendLayout();
            SuspendLayout();
            // 
            // grpOps3
            // 
            grpOps3.Controls.Add(radDiv3);
            grpOps3.Controls.Add(radMul3);
            grpOps3.Controls.Add(radSub3);
            grpOps3.Controls.Add(radAdd3);
            grpOps3.Location = new Point(150, 188);
            grpOps3.Margin = new Padding(4);
            grpOps3.Name = "grpOps3";
            grpOps3.Padding = new Padding(4);
            grpOps3.Size = new Size(500, 125);
            grpOps3.TabIndex = 7;
            grpOps3.TabStop = false;
            grpOps3.Text = "Phép tính";
            // 
            // radDiv3
            // 
            radDiv3.Location = new Point(350, 50);
            radDiv3.Margin = new Padding(4);
            radDiv3.Name = "radDiv3";
            radDiv3.Size = new Size(130, 30);
            radDiv3.TabIndex = 0;
            radDiv3.Text = "Chia";
            radDiv3.CheckedChanged += radDiv3_CheckedChanged;
            // 
            // radMul3
            // 
            radMul3.Location = new Point(238, 50);
            radMul3.Margin = new Padding(4);
            radMul3.Name = "radMul3";
            radMul3.Size = new Size(130, 30);
            radMul3.TabIndex = 1;
            radMul3.Text = "Nhân";
            radMul3.CheckedChanged += radMul3_CheckedChanged;
            // 
            // radSub3
            // 
            radSub3.Location = new Point(138, 50);
            radSub3.Margin = new Padding(4);
            radSub3.Name = "radSub3";
            radSub3.Size = new Size(130, 30);
            radSub3.TabIndex = 2;
            radSub3.Text = "Trừ";
            radSub3.CheckedChanged += radSub3_CheckedChanged;
            // 
            // radAdd3
            // 
            radAdd3.Location = new Point(25, 50);
            radAdd3.Margin = new Padding(4);
            radAdd3.Name = "radAdd3";
            radAdd3.Size = new Size(130, 30);
            radAdd3.TabIndex = 3;
            radAdd3.Text = "Cộng";
            radAdd3.CheckedChanged += radAdd3_CheckedChanged;
            // 
            // txtResult3
            // 
            txtResult3.Location = new Point(238, 334);
            txtResult3.Margin = new Padding(4);
            txtResult3.Name = "txtResult3";
            txtResult3.ReadOnly = true;
            txtResult3.Size = new Size(412, 31);
            txtResult3.TabIndex = 8;
            // 
            // txtNum3_2
            // 
            txtNum3_2.Location = new Point(238, 134);
            txtNum3_2.Margin = new Padding(4);
            txtNum3_2.Name = "txtNum3_2";
            txtNum3_2.Size = new Size(412, 31);
            txtNum3_2.TabIndex = 9;
            // 
            // txtNum3_1
            // 
            txtNum3_1.Location = new Point(238, 84);
            txtNum3_1.Margin = new Padding(4);
            txtNum3_1.Name = "txtNum3_1";
            txtNum3_1.Size = new Size(412, 31);
            txtNum3_1.TabIndex = 10;
            // 
            // lblResult3
            // 
            lblResult3.Location = new Point(150, 338);
            lblResult3.Margin = new Padding(4, 0, 4, 0);
            lblResult3.Name = "lblResult3";
            lblResult3.Size = new Size(125, 29);
            lblResult3.TabIndex = 11;
            lblResult3.Text = "Kết quả:";
            // 
            // lblNum3_2
            // 
            lblNum3_2.Location = new Point(150, 138);
            lblNum3_2.Margin = new Padding(4, 0, 4, 0);
            lblNum3_2.Name = "lblNum3_2";
            lblNum3_2.Size = new Size(125, 29);
            lblNum3_2.TabIndex = 12;
            lblNum3_2.Text = "Số 2:";
            // 
            // lblNum3_1
            // 
            lblNum3_1.Location = new Point(150, 88);
            lblNum3_1.Margin = new Padding(4, 0, 4, 0);
            lblNum3_1.Name = "lblNum3_1";
            lblNum3_1.Size = new Size(125, 29);
            lblNum3_1.TabIndex = 13;
            lblNum3_1.Text = "Số 1:";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpOps3);
            Controls.Add(txtResult3);
            Controls.Add(txtNum3_2);
            Controls.Add(txtNum3_1);
            Controls.Add(lblResult3);
            Controls.Add(lblNum3_2);
            Controls.Add(lblNum3_1);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            grpOps3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpOps3;
        private RadioButton radDiv3;
        private RadioButton radMul3;
        private RadioButton radSub3;
        private RadioButton radAdd3;
        private TextBox txtResult3;
        private TextBox txtNum3_2;
        private TextBox txtNum3_1;
        private Label lblResult3;
        private Label lblNum3_2;
        private Label lblNum3_1;
    }
}