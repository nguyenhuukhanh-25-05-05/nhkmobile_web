namespace BaiTapWinForm
{
    partial class Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6));
            picFlag = new PictureBox();
            groupBox1 = new GroupBox();
            radItaly = new RadioButton();
            radPhilippine = new RadioButton();
            radUSA = new RadioButton();
            radVN = new RadioButton();
            imageList1 = new ImageList(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picFlag).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // picFlag
            // 
            picFlag.Location = new Point(448, 100);
            picFlag.Name = "picFlag";
            picFlag.Size = new Size(288, 198);
            picFlag.SizeMode = PictureBoxSizeMode.Zoom;
            picFlag.TabIndex = 0;
            picFlag.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radItaly);
            groupBox1.Controls.Add(radPhilippine);
            groupBox1.Controls.Add(radUSA);
            groupBox1.Controls.Add(radVN);
            groupBox1.Location = new Point(80, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 210);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "COUNTRY FLAGS";
            // 
            // radItaly
            // 
            radItaly.AutoSize = true;
            radItaly.Location = new Point(6, 135);
            radItaly.Name = "radItaly";
            radItaly.Size = new Size(70, 29);
            radItaly.TabIndex = 5;
            radItaly.TabStop = true;
            radItaly.Text = "Italy";
            radItaly.UseVisualStyleBackColor = true;
            radItaly.CheckedChanged += radItaly_CheckedChanged;
            // 
            // radPhilippine
            // 
            radPhilippine.AutoSize = true;
            radPhilippine.Location = new Point(6, 100);
            radPhilippine.Name = "radPhilippine";
            radPhilippine.Size = new Size(122, 29);
            radPhilippine.TabIndex = 4;
            radPhilippine.TabStop = true;
            radPhilippine.Text = "Philippines";
            radPhilippine.UseVisualStyleBackColor = true;
            radPhilippine.CheckedChanged += radPhilippine_CheckedChanged;
            // 
            // radUSA
            // 
            radUSA.AutoSize = true;
            radUSA.Location = new Point(6, 65);
            radUSA.Name = "radUSA";
            radUSA.Size = new Size(71, 29);
            radUSA.TabIndex = 3;
            radUSA.TabStop = true;
            radUSA.Text = "USA";
            radUSA.UseVisualStyleBackColor = true;
            radUSA.CheckedChanged += radUSA_CheckedChanged;
            // 
            // radVN
            // 
            radVN.AutoSize = true;
            radVN.Location = new Point(6, 30);
            radVN.Name = "radVN";
            radVN.Size = new Size(110, 29);
            radVN.TabIndex = 2;
            radVN.TabStop = true;
            radVN.Text = "Việt Nam";
            radVN.UseVisualStyleBackColor = true;
            radVN.CheckedChanged += radVN_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "flag_vn.png");
            imageList1.Images.SetKeyName(1, "flag_usa.png");
            imageList1.Images.SetKeyName(2, "flag_philippines.png");
            imageList1.Images.SetKeyName(3, "flag_italy.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 48);
            label1.TabIndex = 2;
            label1.Text = "COUNTRY FLAGS";
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(picFlag);
            Name = "Bai6";
            Text = "Bai6";
            Load += Bai6_Load;
            ((System.ComponentModel.ISupportInitialize)picFlag).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFlag;
        private GroupBox groupBox1;
        private RadioButton radItaly;
        private RadioButton radPhilippine;
        private RadioButton radUSA;
        private RadioButton radVN;
        private ImageList imageList1;
        public Label label1;
    }
}