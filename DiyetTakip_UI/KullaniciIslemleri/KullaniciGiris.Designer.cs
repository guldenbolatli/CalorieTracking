namespace DiyetTakip_UI.KullaniciIslemleri
{
    partial class KullaniciGiris
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullaniciBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ozetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaloriTakipçisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaçKaloriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciBilgileriToolStripMenuItem,
            this.ozetToolStripMenuItem,
            this.kaloriTakipçisiToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.kaçKaloriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullaniciBilgileriToolStripMenuItem
            // 
            this.kullaniciBilgileriToolStripMenuItem.Name = "kullaniciBilgileriToolStripMenuItem";
            this.kullaniciBilgileriToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.kullaniciBilgileriToolStripMenuItem.Text = "Kullanici Bilgileri";
            this.kullaniciBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullaniciBilgileriToolStripMenuItem_Click);
            // 
            // ozetToolStripMenuItem
            // 
            this.ozetToolStripMenuItem.Name = "ozetToolStripMenuItem";
            this.ozetToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.ozetToolStripMenuItem.Text = "Özet";
            this.ozetToolStripMenuItem.Click += new System.EventHandler(this.ozetToolStripMenuItem_Click);
            // 
            // kaloriTakipçisiToolStripMenuItem
            // 
            this.kaloriTakipçisiToolStripMenuItem.Name = "kaloriTakipçisiToolStripMenuItem";
            this.kaloriTakipçisiToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.kaloriTakipçisiToolStripMenuItem.Text = "Kalori Takipçisi";
            this.kaloriTakipçisiToolStripMenuItem.Click += new System.EventHandler(this.kaloriTakipçisiToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // kaçKaloriToolStripMenuItem
            // 
            this.kaçKaloriToolStripMenuItem.Name = "kaçKaloriToolStripMenuItem";
            this.kaçKaloriToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.kaçKaloriToolStripMenuItem.Text = "Kaç Kalori";
            this.kaçKaloriToolStripMenuItem.Click += new System.EventHandler(this.kaçKaloriToolStripMenuItem_Click);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KullaniciGiris";
            this.Text = "KullaniciGiris";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kullaniciBilgileriToolStripMenuItem;
        private ToolStripMenuItem ozetToolStripMenuItem;
        private ToolStripMenuItem kaloriTakipçisiToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem kaçKaloriToolStripMenuItem;
    }
}