namespace DiyetTakip_UI
{
    partial class KodKontrol
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
            this.txtKod = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnOnay = new ReaLTaiizor.Controls.CyberButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKod.Location = new System.Drawing.Point(158, 126);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(420, 55);
            this.txtKod.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(158, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(259, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mail Gelmediyse. Maili Tekrar Gönder.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnOnay
            // 
            this.btnOnay.Alpha = 20;
            this.btnOnay.BackColor = System.Drawing.Color.Transparent;
            this.btnOnay.Background = true;
            this.btnOnay.Background_WidthPen = 4F;
            this.btnOnay.BackgroundPen = true;
            this.btnOnay.ColorBackground = System.Drawing.Color.Green;
            this.btnOnay.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnOnay.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnOnay.ColorBackground_Pen = System.Drawing.Color.Transparent;
            this.btnOnay.ColorLighting = System.Drawing.Color.Black;
            this.btnOnay.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnOnay.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnOnay.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnOnay.Effect_1 = true;
            this.btnOnay.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnOnay.Effect_1_Transparency = 25;
            this.btnOnay.Effect_2 = true;
            this.btnOnay.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnOnay.Effect_2_Transparency = 20;
            this.btnOnay.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnOnay.Lighting = false;
            this.btnOnay.LinearGradient_Background = false;
            this.btnOnay.LinearGradientPen = false;
            this.btnOnay.Location = new System.Drawing.Point(423, 215);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.PenWidth = 15;
            this.btnOnay.Rounding = true;
            this.btnOnay.RoundingInt = 70;
            this.btnOnay.Size = new System.Drawing.Size(155, 55);
            this.btnOnay.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnOnay.TabIndex = 11;
            this.btnOnay.Tag = "Cyber";
            this.btnOnay.TextButton = "Onayla";
            this.btnOnay.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnOnay.Timer_Effect_1 = 5;
            this.btnOnay.Timer_RGB = 300;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // KodKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtKod);
            this.Name = "KodKontrol";
            this.Text = "KodKontrol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtKod;
        private LinkLabel linkLabel1;
        private ReaLTaiizor.Controls.CyberButton btnOnay;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}