namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAPATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENKGETİRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRİYÖNTEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRTALAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kANALSIRALAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lUMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇIKLIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.iŞLEMLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAPATToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // kAPATToolStripMenuItem
            // 
            this.kAPATToolStripMenuItem.Name = "kAPATToolStripMenuItem";
            this.kAPATToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kAPATToolStripMenuItem.Text = "KAPAT";
            this.kAPATToolStripMenuItem.Click += new System.EventHandler(this.kAPATToolStripMenuItem_Click);
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            this.iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rENKGETİRToolStripMenuItem,
            this.gRİYÖNTEMLERİToolStripMenuItem});
            this.iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            this.iŞLEMLERToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // rENKGETİRToolStripMenuItem
            // 
            this.rENKGETİRToolStripMenuItem.Name = "rENKGETİRToolStripMenuItem";
            this.rENKGETİRToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rENKGETİRToolStripMenuItem.Text = "RENK GETİR";
            this.rENKGETİRToolStripMenuItem.Click += new System.EventHandler(this.rENKGETİRToolStripMenuItem_Click);
            // 
            // gRİYÖNTEMLERİToolStripMenuItem
            // 
            this.gRİYÖNTEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bT709ToolStripMenuItem,
            this.oRTALAMAToolStripMenuItem,
            this.kANALSIRALAMAToolStripMenuItem,
            this.lUMAToolStripMenuItem,
            this.aÇIKLIKToolStripMenuItem});
            this.gRİYÖNTEMLERİToolStripMenuItem.Name = "gRİYÖNTEMLERİToolStripMenuItem";
            this.gRİYÖNTEMLERİToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gRİYÖNTEMLERİToolStripMenuItem.Text = "GRİ YÖNTEMLERİ";
            // 
            // bT709ToolStripMenuItem
            // 
            this.bT709ToolStripMenuItem.Name = "bT709ToolStripMenuItem";
            this.bT709ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bT709ToolStripMenuItem.Text = "BT-709";
            this.bT709ToolStripMenuItem.Click += new System.EventHandler(this.bT709ToolStripMenuItem_Click);
            // 
            // oRTALAMAToolStripMenuItem
            // 
            this.oRTALAMAToolStripMenuItem.Name = "oRTALAMAToolStripMenuItem";
            this.oRTALAMAToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.oRTALAMAToolStripMenuItem.Text = "ORTALAMA";
            this.oRTALAMAToolStripMenuItem.Click += new System.EventHandler(this.oRTALAMAToolStripMenuItem_Click);
            // 
            // kANALSIRALAMAToolStripMenuItem
            // 
            this.kANALSIRALAMAToolStripMenuItem.Name = "kANALSIRALAMAToolStripMenuItem";
            this.kANALSIRALAMAToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kANALSIRALAMAToolStripMenuItem.Text = "KANAL SIRALAMA";
            this.kANALSIRALAMAToolStripMenuItem.Click += new System.EventHandler(this.kANALSIRALAMAToolStripMenuItem_Click);
            // 
            // lUMAToolStripMenuItem
            // 
            this.lUMAToolStripMenuItem.Name = "lUMAToolStripMenuItem";
            this.lUMAToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lUMAToolStripMenuItem.Text = "LUMA";
            this.lUMAToolStripMenuItem.Click += new System.EventHandler(this.lUMAToolStripMenuItem_Click);
            // 
            // aÇIKLIKToolStripMenuItem
            // 
            this.aÇIKLIKToolStripMenuItem.Name = "aÇIKLIKToolStripMenuItem";
            this.aÇIKLIKToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aÇIKLIKToolStripMenuItem.Text = "AÇIKLIK";
            this.aÇIKLIKToolStripMenuItem.Click += new System.EventHandler(this.aÇIKLIKToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAPATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENKGETİRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRİYÖNTEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRTALAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kANALSIRALAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lUMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aÇIKLIKToolStripMenuItem;
    }
}

