namespace LTUD_C.Thiện
{
    partial class Bai2C2cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2C2cs));
            progressBar1 = new ProgressBar();
            btnOK = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(30, 379);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(534, 34);
            progressBar1.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(452, 339);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // listView1
            // 
            listView1.Location = new Point(212, 148);
            listView1.Name = "listView1";
            listView1.Size = new Size(352, 185);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "images.jpg");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 361);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 12);
            label1.Name = "label1";
            label1.Size = new Size(317, 25);
            label1.TabIndex = 4;
            label1.Text = "Ứng dụng MDIForm để quản lí bài tập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 50);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 5;
            label2.Text = "Ver1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 120);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 6;
            label3.Text = "TT CNTT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 85);
            label4.Name = "label4";
            label4.Size = new Size(228, 25);
            label4.TabIndex = 7;
            label4.Text = "Copyright @ TT CNTT 2026";
            // 
            // Bai2C2cs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Controls.Add(btnOK);
            Controls.Add(progressBar1);
            Name = "Bai2C2cs";
            Text = "FormSplash";
            Load += FormSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btnOK;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}