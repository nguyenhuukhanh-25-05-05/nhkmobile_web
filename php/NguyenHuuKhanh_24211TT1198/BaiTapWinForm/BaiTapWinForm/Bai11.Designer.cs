namespace LTUD_C.Thiện
{
    partial class Bai11
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
            tbR = new TrackBar();
            tbG = new TrackBar();
            tbB = new TrackBar();
            pnlMau = new Panel();
            lblR = new Label();
            lblG = new Label();
            lblB = new Label();
            ((System.ComponentModel.ISupportInitialize)tbR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbB).BeginInit();
            SuspendLayout();
            // 
            // tbR
            // 
            tbR.Location = new Point(22, 12);
            tbR.Name = "tbR";
            tbR.Size = new Size(156, 69);
            tbR.TabIndex = 0;
            tbR.Scroll += tbR_Scroll;
            // 
            // tbG
            // 
            tbG.Location = new Point(22, 87);
            tbG.Name = "tbG";
            tbG.Size = new Size(156, 69);
            tbG.TabIndex = 1;
            tbG.Scroll += tbG_Scroll;
            // 
            // tbB
            // 
            tbB.Location = new Point(22, 162);
            tbB.Name = "tbB";
            tbB.Size = new Size(156, 69);
            tbB.TabIndex = 2;
            tbB.Scroll += tbB_Scroll;
            // 
            // pnlMau
            // 
            pnlMau.Location = new Point(488, 12);
            pnlMau.Name = "pnlMau";
            pnlMau.Size = new Size(300, 219);
            pnlMau.TabIndex = 3;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Location = new Point(258, 12);
            lblR.Name = "lblR";
            lblR.Size = new Size(59, 25);
            lblR.TabIndex = 4;
            lblR.Text = "label1";
            // 
            // lblG
            // 
            lblG.AutoSize = true;
            lblG.Location = new Point(258, 87);
            lblG.Name = "lblG";
            lblG.Size = new Size(59, 25);
            lblG.TabIndex = 5;
            lblG.Text = "label2";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(258, 162);
            lblB.Name = "lblB";
            lblB.Size = new Size(59, 25);
            lblB.TabIndex = 6;
            lblB.Text = "label3";
            // 
            // Bai11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 278);
            Controls.Add(lblB);
            Controls.Add(lblG);
            Controls.Add(lblR);
            Controls.Add(pnlMau);
            Controls.Add(tbB);
            Controls.Add(tbG);
            Controls.Add(tbR);
            Name = "Bai11";
            Text = "Bai11";
            Load += Bai11_Load;
            ((System.ComponentModel.ISupportInitialize)tbR).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbG).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbR;
        private TrackBar tbG;
        private TrackBar tbB;
        private Panel pnlMau;
        private Label lblR;
        private Label lblG;
        private Label lblB;
    }
}