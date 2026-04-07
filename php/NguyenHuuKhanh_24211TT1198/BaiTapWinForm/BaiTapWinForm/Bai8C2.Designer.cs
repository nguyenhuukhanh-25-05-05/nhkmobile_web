namespace LTUD_C.Thiện
{
    partial class Bai8C2
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
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtTen2 = new TextBox();
            txtTen = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(228, 435);
            treeView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTen2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(256, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(225, 173);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // txtTen2
            // 
            txtTen2.Location = new Point(6, 135);
            txtTen2.Name = "txtTen2";
            txtTen2.Size = new Size(150, 31);
            txtTen2.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(6, 73);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(150, 31);
            txtTen.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(382, 241);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Bai8C2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(treeView1);
            Name = "Bai8C2";
            Text = "Bai8C2";
            Load += Bai8C2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txtTen2;
        private TextBox txtTen;
        private Button button2;
    }
}