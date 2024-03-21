namespace DiyetTakip_UI.AdminGirisi
{
    partial class TarifCRUD
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
            this.chkSecimiKaldir = new System.Windows.Forms.CheckBox();
            this.dgvTarifList = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblHazirlanmaSuresi = new System.Windows.Forms.Label();
            this.lblYiyecekAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHazirlanmaSuresi = new System.Windows.Forms.TextBox();
            this.lblTarifID = new System.Windows.Forms.Label();
            this.txtTarifDetayi = new System.Windows.Forms.TextBox();
            this.txtTarifID = new System.Windows.Forms.TextBox();
            this.cmbYiyecekListesi = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHome = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifList)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSecimiKaldir
            // 
            this.chkSecimiKaldir.AutoSize = true;
            this.chkSecimiKaldir.Location = new System.Drawing.Point(407, 272);
            this.chkSecimiKaldir.Name = "chkSecimiKaldir";
            this.chkSecimiKaldir.Size = new System.Drawing.Size(118, 24);
            this.chkSecimiKaldir.TabIndex = 36;
            this.chkSecimiKaldir.Text = "Seçimi Kaldır";
            this.chkSecimiKaldir.UseVisualStyleBackColor = true;
            this.chkSecimiKaldir.CheckedChanged += new System.EventHandler(this.chkSecimiKaldir_CheckedChanged);
            // 
            // dgvTarifList
            // 
            this.dgvTarifList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifList.Location = new System.Drawing.Point(49, 308);
            this.dgvTarifList.Name = "dgvTarifList";
            this.dgvTarifList.RowHeadersWidth = 51;
            this.dgvTarifList.RowTemplate.Height = 29;
            this.dgvTarifList.Size = new System.Drawing.Size(687, 200);
            this.dgvTarifList.TabIndex = 35;
            this.dgvTarifList.SelectionChanged += new System.EventHandler(this.dgvTarifList_SelectionChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(395, 178);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(130, 38);
            this.btnAra.TabIndex = 30;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(395, 134);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 38);
            this.btnGuncelle.TabIndex = 31;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(606, 264);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(130, 38);
            this.btnListele.TabIndex = 32;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(395, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 38);
            this.btnEkle.TabIndex = 34;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblHazirlanmaSuresi
            // 
            this.lblHazirlanmaSuresi.AutoSize = true;
            this.lblHazirlanmaSuresi.Location = new System.Drawing.Point(49, 151);
            this.lblHazirlanmaSuresi.Name = "lblHazirlanmaSuresi";
            this.lblHazirlanmaSuresi.Size = new System.Drawing.Size(135, 20);
            this.lblHazirlanmaSuresi.TabIndex = 26;
            this.lblHazirlanmaSuresi.Text = "Hazırlanma Süresi :";
            // 
            // lblYiyecekAdi
            // 
            this.lblYiyecekAdi.AutoSize = true;
            this.lblYiyecekAdi.Location = new System.Drawing.Point(49, 199);
            this.lblYiyecekAdi.Name = "lblYiyecekAdi";
            this.lblYiyecekAdi.Size = new System.Drawing.Size(92, 20);
            this.lblYiyecekAdi.TabIndex = 27;
            this.lblYiyecekAdi.Text = "Yiyecek Adi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tarif Detayı :";
            // 
            // txtHazirlanmaSuresi
            // 
            this.txtHazirlanmaSuresi.Location = new System.Drawing.Point(192, 148);
            this.txtHazirlanmaSuresi.Name = "txtHazirlanmaSuresi";
            this.txtHazirlanmaSuresi.Size = new System.Drawing.Size(151, 27);
            this.txtHazirlanmaSuresi.TabIndex = 21;
            // 
            // lblTarifID
            // 
            this.lblTarifID.AutoSize = true;
            this.lblTarifID.Location = new System.Drawing.Point(49, 49);
            this.lblTarifID.Name = "lblTarifID";
            this.lblTarifID.Size = new System.Drawing.Size(63, 20);
            this.lblTarifID.TabIndex = 29;
            this.lblTarifID.Text = "Tarif ID :";
            // 
            // txtTarifDetayi
            // 
            this.txtTarifDetayi.Location = new System.Drawing.Point(192, 96);
            this.txtTarifDetayi.Name = "txtTarifDetayi";
            this.txtTarifDetayi.Size = new System.Drawing.Size(151, 27);
            this.txtTarifDetayi.TabIndex = 24;
            // 
            // txtTarifID
            // 
            this.txtTarifID.Location = new System.Drawing.Point(192, 46);
            this.txtTarifID.Name = "txtTarifID";
            this.txtTarifID.Size = new System.Drawing.Size(151, 27);
            this.txtTarifID.TabIndex = 23;
            // 
            // cmbYiyecekListesi
            // 
            this.cmbYiyecekListesi.FormattingEnabled = true;
            this.cmbYiyecekListesi.Location = new System.Drawing.Point(192, 196);
            this.cmbYiyecekListesi.Name = "cmbYiyecekListesi";
            this.cmbYiyecekListesi.Size = new System.Drawing.Size(151, 28);
            this.cmbYiyecekListesi.TabIndex = 37;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(395, 90);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 38);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnHome.TabIndex = 38;
            this.btnHome.Tag = "Cyber";
            this.btnHome.TextButton = "";
            this.btnHome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnHome.Timer_Effect_1 = 5;
            this.btnHome.Timer_RGB = 300;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // TarifCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 657);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.cmbYiyecekListesi);
            this.Controls.Add(this.chkSecimiKaldir);
            this.Controls.Add(this.dgvTarifList);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblHazirlanmaSuresi);
            this.Controls.Add(this.lblYiyecekAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHazirlanmaSuresi);
            this.Controls.Add(this.lblTarifID);
            this.Controls.Add(this.txtTarifDetayi);
            this.Controls.Add(this.txtTarifID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TarifCRUD";
            this.Text = "TarifCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkSecimiKaldir;
        private DataGridView dgvTarifList;
        private Button btnAra;
        private Button btnGuncelle;
        private Button btnListele;
        private Button btnEkle;
        private Label lblHazirlanmaSuresi;
        private Label lblYiyecekAdi;
        private Label label1;
        private TextBox txtHazirlanmaSuresi;
        private Label lblTarifID;
        private TextBox txtTarifDetayi;
        private TextBox txtTarifID;
        private ComboBox cmbYiyecekListesi;
        private Button btnSil;
        private ReaLTaiizor.Controls.CyberButton btnHome;
    }
}