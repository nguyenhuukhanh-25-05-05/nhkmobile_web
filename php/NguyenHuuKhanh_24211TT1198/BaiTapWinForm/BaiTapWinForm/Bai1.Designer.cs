namespace BaiTapWinForm
{
    partial class Bai1
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
            btnExit1 = new Button();
            btnClear1 = new Button();
            btnShow1 = new Button();
            txtYear1 = new TextBox();
            txtYourName1 = new TextBox();
            lblYear1 = new Label();
            lblName1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnExit1
            // 
            btnExit1.Location = new Point(508, 269);
            btnExit1.Margin = new Padding(4);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(94, 54);
            btnExit1.TabIndex = 7;
            btnExit1.Text = "Exit";
            btnExit1.Click += btnExit1_Click;
            // 
            // btnClear1
            // 
            btnClear1.Location = new Point(338, 269);
            btnClear1.Margin = new Padding(4);
            btnClear1.Name = "btnClear1";
            btnClear1.Size = new Size(94, 54);
            btnClear1.TabIndex = 8;
            btnClear1.Text = "Clear";
            btnClear1.Click += btnClear1_Click;
            // 
            // btnShow1
            // 
            btnShow1.Location = new Point(175, 269);
            btnShow1.Margin = new Padding(4);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(94, 54);
            btnShow1.TabIndex = 9;
            btnShow1.Text = "Show";
            btnShow1.Click += btnShow1_Click;
            // 
            // txtYear1
            // 
            txtYear1.Location = new Point(313, 190);
            txtYear1.Margin = new Padding(4);
            txtYear1.Name = "txtYear1";
            txtYear1.Size = new Size(312, 31);
            txtYear1.TabIndex = 10;
            // 
            // txtYourName1
            // 
            txtYourName1.Location = new Point(313, 128);
            txtYourName1.Margin = new Padding(4);
            txtYourName1.Name = "txtYourName1";
            txtYourName1.Size = new Size(312, 31);
            txtYourName1.TabIndex = 11;
            // 
            // lblYear1
            // 
            lblYear1.Location = new Point(175, 194);
            lblYear1.Margin = new Padding(4, 0, 4, 0);
            lblYear1.Name = "lblYear1";
            lblYear1.Size = new Size(125, 29);
            lblYear1.TabIndex = 12;
            lblYear1.Text = "Year of birth";
            // 
            // lblName1
            // 
            lblName1.Location = new Point(175, 131);
            lblName1.Margin = new Padding(4, 0, 4, 0);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(125, 29);
            lblName1.TabIndex = 13;
            lblName1.Text = "Your Name";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit1);
            Controls.Add(btnClear1);
            Controls.Add(btnShow1);
            Controls.Add(txtYear1);
            Controls.Add(txtYourName1);
            Controls.Add(lblYear1);
            Controls.Add(lblName1);
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit1;
        private Button btnClear1;
        private Button btnShow1;
        private TextBox txtYear1;
        private TextBox txtYourName1;
        private Label lblYear1;
        private Label lblName1;
        private ErrorProvider errorProvider1;
    }
}