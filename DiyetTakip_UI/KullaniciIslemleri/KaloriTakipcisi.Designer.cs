namespace DiyetTakip_UI.KullaniciIslemleri
{
    partial class KaloriTakipcisi
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
            this.cmbYiyecekListesi = new System.Windows.Forms.ComboBox();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblMiktarTuru = new System.Windows.Forms.Label();
            this.cmbOgunler = new System.Windows.Forms.ComboBox();
            this.dgvOgunTakipList = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHome = new ReaLTaiizor.Controls.CyberButton();
            this.btnListele = new ReaLTaiizor.Controls.CyberButton();
            this.btnSil = new ReaLTaiizor.Controls.CyberButton();
            this.btnEkle = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunTakipList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYiyecekListesi
            // 
            this.cmbYiyecekListesi.FormattingEnabled = true;
            this.cmbYiyecekListesi.Location = new System.Drawing.Point(192, 122);
            this.cmbYiyecekListesi.Name = "cmbYiyecekListesi";
            this.cmbYiyecekListesi.Size = new System.Drawing.Size(151, 28);
            this.cmbYiyecekListesi.TabIndex = 1;
            this.cmbYiyecekListesi.SelectedIndexChanged += new System.EventHandler(this.cmbYiyecekListesi_SelectedIndexChanged);
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(349, 123);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(150, 27);
            this.nudMiktar.TabIndex = 6;
            // 
            // lblMiktarTuru
            // 
            this.lblMiktarTuru.AutoSize = true;
            this.lblMiktarTuru.Location = new System.Drawing.Point(505, 127);
            this.lblMiktarTuru.Name = "lblMiktarTuru";
            this.lblMiktarTuru.Size = new System.Drawing.Size(50, 20);
            this.lblMiktarTuru.TabIndex = 9;
            this.lblMiktarTuru.Text = "label2";
            // 
            // cmbOgunler
            // 
            this.cmbOgunler.FormattingEnabled = true;
            this.cmbOgunler.Location = new System.Drawing.Point(35, 122);
            this.cmbOgunler.Name = "cmbOgunler";
            this.cmbOgunler.Size = new System.Drawing.Size(151, 28);
            this.cmbOgunler.TabIndex = 10;
            // 
            // dgvOgunTakipList
            // 
            this.dgvOgunTakipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunTakipList.Location = new System.Drawing.Point(12, 276);
            this.dgvOgunTakipList.Name = "dgvOgunTakipList";
            this.dgvOgunTakipList.RowHeadersWidth = 51;
            this.dgvOgunTakipList.RowTemplate.Height = 29;
            this.dgvOgunTakipList.Size = new System.Drawing.Size(991, 290);
            this.dgvOgunTakipList.TabIndex = 11;
            this.dgvOgunTakipList.SelectionChanged += new System.EventHandler(this.dgvOgunTakipList_SelectionChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnHome
            // 
            this.btnHome.Alpha = 20;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Background = true;
            this.btnHome.Background_WidthPen = 4F;
            this.btnHome.BackgroundImage = global::DiyetTakip_UI.Properties.Resources.cabk;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.btnHome.Size = new System.Drawing.Size(53, 45);
            this.btnHome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnHome.TabIndex = 16;
            this.btnHome.Tag = "Cyber";
            this.btnHome.TextButton = "";
            this.btnHome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnHome.Timer_Effect_1 = 5;
            this.btnHome.Timer_RGB = 300;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnListele
            // 
            this.btnListele.Alpha = 20;
            this.btnListele.BackColor = System.Drawing.Color.Transparent;
            this.btnListele.Background = true;
            this.btnListele.Background_WidthPen = 4F;
            this.btnListele.BackgroundPen = true;
            this.btnListele.ColorBackground = System.Drawing.Color.Green;
            this.btnListele.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnListele.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnListele.ColorBackground_Pen = System.Drawing.Color.Transparent;
            this.btnListele.ColorLighting = System.Drawing.Color.Black;
            this.btnListele.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnListele.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnListele.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnListele.Effect_1 = true;
            this.btnListele.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnListele.Effect_1_Transparency = 25;
            this.btnListele.Effect_2 = true;
            this.btnListele.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnListele.Effect_2_Transparency = 20;
            this.btnListele.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnListele.Lighting = false;
            this.btnListele.LinearGradient_Background = false;
            this.btnListele.LinearGradientPen = false;
            this.btnListele.Location = new System.Drawing.Point(848, 215);
            this.btnListele.Name = "btnListele";
            this.btnListele.PenWidth = 15;
            this.btnListele.Rounding = true;
            this.btnListele.RoundingInt = 70;
            this.btnListele.Size = new System.Drawing.Size(155, 55);
            this.btnListele.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnListele.TabIndex = 17;
            this.btnListele.Tag = "Cyber";
            this.btnListele.TextButton = "Listele";
            this.btnListele.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnListele.Timer_Effect_1 = 5;
            this.btnListele.Timer_RGB = 300;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Alpha = 20;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.Background = true;
            this.btnSil.Background_WidthPen = 4F;
            this.btnSil.BackgroundPen = true;
            this.btnSil.ColorBackground = System.Drawing.Color.Green;
            this.btnSil.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnSil.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnSil.ColorBackground_Pen = System.Drawing.Color.Transparent;
            this.btnSil.ColorLighting = System.Drawing.Color.Black;
            this.btnSil.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnSil.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnSil.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnSil.Effect_1 = true;
            this.btnSil.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnSil.Effect_1_Transparency = 25;
            this.btnSil.Effect_2 = true;
            this.btnSil.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnSil.Effect_2_Transparency = 20;
            this.btnSil.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnSil.Lighting = false;
            this.btnSil.LinearGradient_Background = false;
            this.btnSil.LinearGradientPen = false;
            this.btnSil.Location = new System.Drawing.Point(577, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.PenWidth = 15;
            this.btnSil.Rounding = true;
            this.btnSil.RoundingInt = 70;
            this.btnSil.Size = new System.Drawing.Size(155, 55);
            this.btnSil.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSil.TabIndex = 18;
            this.btnSil.Tag = "Cyber";
            this.btnSil.TextButton = "Sil";
            this.btnSil.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSil.Timer_Effect_1 = 5;
            this.btnSil.Timer_RGB = 300;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Alpha = 20;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.Background = true;
            this.btnEkle.Background_WidthPen = 4F;
            this.btnEkle.BackgroundPen = true;
            this.btnEkle.ColorBackground = System.Drawing.Color.Green;
            this.btnEkle.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnEkle.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnEkle.ColorBackground_Pen = System.Drawing.Color.Transparent;
            this.btnEkle.ColorLighting = System.Drawing.Color.Black;
            this.btnEkle.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnEkle.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnEkle.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnEkle.Effect_1 = true;
            this.btnEkle.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnEkle.Effect_1_Transparency = 25;
            this.btnEkle.Effect_2 = true;
            this.btnEkle.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnEkle.Effect_2_Transparency = 20;
            this.btnEkle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnEkle.Lighting = false;
            this.btnEkle.LinearGradient_Background = false;
            this.btnEkle.LinearGradientPen = false;
            this.btnEkle.Location = new System.Drawing.Point(577, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PenWidth = 15;
            this.btnEkle.Rounding = true;
            this.btnEkle.RoundingInt = 70;
            this.btnEkle.Size = new System.Drawing.Size(155, 55);
            this.btnEkle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Tag = "Cyber";
            this.btnEkle.TextButton = "Ekle";
            this.btnEkle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEkle.Timer_Effect_1 = 5;
            this.btnEkle.Timer_RGB = 300;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // KaloriTakipcisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 691);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvOgunTakipList);
            this.Controls.Add(this.cmbYiyecekListesi);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.cmbOgunler);
            this.Controls.Add(this.lblMiktarTuru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KaloriTakipcisi";
            this.Text = "KaloriTakipcisi";
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunTakipList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbYiyecekListesi;
        private NumericUpDown nudMiktar;
        private Label lblMiktarTuru;
        private ComboBox cmbOgunler;
        private DataGridView dgvOgunTakipList;
        private DateTimePicker dateTimePicker1;
        private ReaLTaiizor.Controls.CyberButton btnHome;
        private ReaLTaiizor.Controls.CyberButton btnListele;
        private ReaLTaiizor.Controls.CyberButton btnSil;
        private ReaLTaiizor.Controls.CyberButton btnEkle;
    }
}