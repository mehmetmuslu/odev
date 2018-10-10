namespace WindowsFormsApp2
{
    partial class Form8
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAYDETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRİYÖNTEMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LUMA = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBBRGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.gRİYÖNTEMİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.kAYDETToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aÇToolStripMenuItem.Text = "AÇ";
            this.aÇToolStripMenuItem.Click += new System.EventHandler(this.aÇToolStripMenuItem_Click);
            // 
            // kAYDETToolStripMenuItem
            // 
            this.kAYDETToolStripMenuItem.Name = "kAYDETToolStripMenuItem";
            this.kAYDETToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kAYDETToolStripMenuItem.Text = "KAYDET";
            this.kAYDETToolStripMenuItem.Click += new System.EventHandler(this.kAYDETToolStripMenuItem_Click);
            // 
            // gRİYÖNTEMİToolStripMenuItem
            // 
            this.gRİYÖNTEMİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LUMA});
            this.gRİYÖNTEMİToolStripMenuItem.Name = "gRİYÖNTEMİToolStripMenuItem";
            this.gRİYÖNTEMİToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.gRİYÖNTEMİToolStripMenuItem.Text = "GRİ YÖNTEMİ";
            // 
            // LUMA
            // 
            this.LUMA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBBRGToolStripMenuItem});
            this.LUMA.Name = "LUMA";
            this.LUMA.Size = new System.Drawing.Size(216, 26);
            this.LUMA.Text = "LUMA";
            this.LUMA.Click += new System.EventHandler(this.LUMA_Click);
            // 
            // rGBBRGToolStripMenuItem
            // 
            this.rGBBRGToolStripMenuItem.Name = "rGBBRGToolStripMenuItem";
            this.rGBBRGToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rGBBRGToolStripMenuItem.Text = "RGB>BRG";
            this.rGBBRGToolStripMenuItem.Click += new System.EventHandler(this.rGBBRGToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(426, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAYDETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRİYÖNTEMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LUMA;
        private System.Windows.Forms.ToolStripMenuItem rGBBRGToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}