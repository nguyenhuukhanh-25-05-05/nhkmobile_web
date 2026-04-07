namespace LTUD_C.Thiện
{
    partial class Bai9C2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai9C2));
            treeView1 = new TreeView();
            lvSV = new ListView();
            label1 = new Label();
            txtTim = new TextBox();
            btnTim = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 48);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(253, 390);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // lvSV
            // 
            lvSV.Location = new Point(284, 48);
            lvSV.Name = "lvSV";
            lvSV.Size = new Size(504, 390);
            lvSV.TabIndex = 1;
            lvSV.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(349, 9);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(299, 31);
            txtTim.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(676, 7);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 34);
            btnTim.TabIndex = 4;
            btnTim.Text = "button1";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "43546_normal_folder_icon.png");
            imageList1.Images.SetKeyName(1, "32722_folder_icon.png");
            imageList1.Images.SetKeyName(2, "4619670_avatar_human_people_profile_user_icon.png");
            // 
            // Bai9C2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnTim);
            Controls.Add(txtTim);
            Controls.Add(label1);
            Controls.Add(lvSV);
            Controls.Add(treeView1);
            Name = "Bai9C2";
            Text = "Bai9C2";
            Load += Bai9C2_Load;
            Click += Bai9C2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView lvSV;
        private Label label1;
        private TextBox txtTim;
        private Button btnTim;
        private ImageList imageList1;
    }
}