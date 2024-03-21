namespace DiyetTakip_UI.KullaniciIslemleri
{
    partial class KacKalori
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
            this.txtYiyecekAdi = new System.Windows.Forms.TextBox();
            this.lstYiyecekler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new ReaLTaiizor.Controls.CyberButton();
            this.SuspendLayout();
            // 
            // txtYiyecekAdi
            // 
            this.txtYiyecekAdi.Location = new System.Drawing.Point(70, 101);
            this.txtYiyecekAdi.Name = "txtYiyecekAdi";
            this.txtYiyecekAdi.Size = new System.Drawing.Size(345, 27);
            this.txtYiyecekAdi.TabIndex = 0;
            // 
            // lstYiyecekler
            // 
            this.lstYiyecekler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstYiyecekler.FormattingEnabled = true;
            this.lstYiyecekler.ItemHeight = 25;
            this.lstYiyecekler.Location = new System.Drawing.Point(70, 150);
            this.lstYiyecekler.Name = "lstYiyecekler";
            this.lstYiyecekler.Size = new System.Drawing.Size(345, 254);
            this.lstYiyecekler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "KAÇ KALORİ ?";
            // 
            // btnHome
            // 
            this.btnHome.Alpha = 20;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Background = true;
            this.btnHome.Background_WidthPen = 4F;
            this.btnHome.BackgroundImage = global::DiyetTakip_UI.Properties.Resources.cabk;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BackgroundPen = true;
            this.btnHome.ColorBackground = System.Drawing.Color.Transparent;
            this.btnHome.ColorBackground_1 = System.Drawing.Color.Transparent;
            this.btnHome.ColorBackground_2 = System.Drawing.Color.Transparent;
            this.btnHome.ColorBackground_Pen = System.Drawing.Color.Transparent;
            this.btnHome.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnHome.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnHome.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnHome.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnHome.Effect_1 = true;
            this.btnHome.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnHome.Effect_1_Transparency = 25;
            this.btnHome.Effect_2 = true;
            this.btnHome.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnHome.Effect_2_Transparency = 20;
            this.btnHome.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnHome.Lighting = false;
            this.btnHome.LinearGradient_Background = false;
            this.btnHome.LinearGradientPen = false;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.PenWidth = 15;
            this.btnHome.Rounding = true;
            this.btnHome.RoundingInt = 70;
            this.btnHome.Size = new System.Drawing.Size(49, 37);
            this.btnHome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnHome.TabIndex = 16;
            this.btnHome.Tag = "Cyber";
            this.btnHome.TextButton = "";
            this.btnHome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnHome.Timer_Effect_1 = 5;
            this.btnHome.Timer_RGB = 300;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // KacKalori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 688);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYiyecekler);
            this.Controls.Add(this.txtYiyecekAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KacKalori";
            this.Text = "KacKalori";
            this.Load += new System.EventHandler(this.KacKalori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtYiyecekAdi;
        private ListBox lstYiyecekler;
        private Label label1;
        private ReaLTaiizor.Controls.CyberButton btnHome;
    }
}