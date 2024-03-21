namespace DiyetTakip_UI
{
    partial class AcilisEkrani
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
            this.components = new System.ComponentModel.Container();
            this.ctxUyeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuItemGirisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuItemUyeOl = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moonLabel1 = new ReaLTaiizor.Controls.MoonLabel();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.btnÜyelik = new ReaLTaiizor.Controls.CyberButton();
            this.ctxUyeMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxUyeMenu
            // 
            this.ctxUyeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxUyeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuItemGirisYap,
            this.ctxMenuItemUyeOl});
            this.ctxUyeMenu.Name = "contextMenuStrip1";
            this.ctxUyeMenu.Size = new System.Drawing.Size(136, 52);
            // 
            // ctxMenuItemGirisYap
            // 
            this.ctxMenuItemGirisYap.Name = "ctxMenuItemGirisYap";
            this.ctxMenuItemGirisYap.Size = new System.Drawing.Size(135, 24);
            this.ctxMenuItemGirisYap.Text = "Giriş Yap";
            this.ctxMenuItemGirisYap.Click += new System.EventHandler(this.ctxMenuItemGirisYap_Click);
            // 
            // ctxMenuItemUyeOl
            // 
            this.ctxMenuItemUyeOl.Name = "ctxMenuItemUyeOl";
            this.ctxMenuItemUyeOl.Size = new System.Drawing.Size(135, 24);
            this.ctxMenuItemUyeOl.Text = "Üye Ol";
            this.ctxMenuItemUyeOl.Click += new System.EventHandler(this.ctxMenuItemUyeOl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::DiyetTakip_UI.Properties.Resources.shutterstock_1797267202__1__181020211107;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.moonLabel1);
            this.groupBox1.Controls.Add(this.headerLabel1);
            this.groupBox1.Controls.Add(this.btnÜyelik);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 786);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // moonLabel1
            // 
            this.moonLabel1.AutoSize = true;
            this.moonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.moonLabel1.ForeColor = System.Drawing.Color.Gray;
            this.moonLabel1.Location = new System.Drawing.Point(8, 732);
            this.moonLabel1.Name = "moonLabel1";
            this.moonLabel1.Size = new System.Drawing.Size(92, 20);
            this.moonLabel1.TabIndex = 5;
            this.moonLabel1.Text = "moonLabel1";
            // 
            // headerLabel1
            // 
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel1.ForeColor = System.Drawing.Color.Black;
            this.headerLabel1.Location = new System.Drawing.Point(494, 26);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(318, 75);
            this.headerLabel1.TabIndex = 3;
            this.headerLabel1.Text = "Diyet Takip";
            // 
            // btnÜyelik
            // 
            this.btnÜyelik.Alpha = 20;
            this.btnÜyelik.BackColor = System.Drawing.Color.Transparent;
            this.btnÜyelik.Background = true;
            this.btnÜyelik.Background_WidthPen = 4F;
            this.btnÜyelik.BackgroundImage = global::DiyetTakip_UI.Properties.Resources.anagiris;
            this.btnÜyelik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnÜyelik.BackgroundPen = true;
            this.btnÜyelik.ColorBackground = System.Drawing.Color.Transparent;
            this.btnÜyelik.ColorBackground_1 = System.Drawing.Color.Transparent;
            this.btnÜyelik.ColorBackground_2 = System.Drawing.Color.Transparent;
            this.btnÜyelik.ColorBackground_Pen = System.Drawing.Color.Transparent;
            this.btnÜyelik.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnÜyelik.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnÜyelik.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnÜyelik.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnÜyelik.Effect_1 = true;
            this.btnÜyelik.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnÜyelik.Effect_1_Transparency = 25;
            this.btnÜyelik.Effect_2 = true;
            this.btnÜyelik.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnÜyelik.Effect_2_Transparency = 20;
            this.btnÜyelik.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnÜyelik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnÜyelik.Lighting = false;
            this.btnÜyelik.LinearGradient_Background = false;
            this.btnÜyelik.LinearGradientPen = false;
            this.btnÜyelik.Location = new System.Drawing.Point(1032, 26);
            this.btnÜyelik.Name = "btnÜyelik";
            this.btnÜyelik.PenWidth = 15;
            this.btnÜyelik.Rounding = true;
            this.btnÜyelik.RoundingInt = 70;
            this.btnÜyelik.Size = new System.Drawing.Size(111, 106);
            this.btnÜyelik.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnÜyelik.TabIndex = 1;
            this.btnÜyelik.Tag = "Cyber";
            this.btnÜyelik.TextButton = "";
            this.btnÜyelik.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnÜyelik.Timer_Effect_1 = 5;
            this.btnÜyelik.Timer_RGB = 300;
            this.btnÜyelik.Click += new System.EventHandler(this.btnÜyelik_Click);
            // 
            // AcilisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 781);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "AcilisEkrani";
            this.Text = "AcilisEkrani";
            this.Load += new System.EventHandler(this.AcilisEkrani_Load);
            this.ctxUyeMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip ctxUyeMenu;
        private ToolStripMenuItem ctxMenuItemGirisYap;
        private ToolStripMenuItem ctxMenuItemUyeOl;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.CyberButton btnÜyelik;
        private ReaLTaiizor.Controls.MoonLabel moonLabel1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
    }
}