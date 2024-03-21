namespace DiyetTakip_UI.AdminGirisi
{
    partial class KategoriCRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.btnFotografSec = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pbFotograf = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvKategoriListe = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategoriID = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.chbTemizle = new System.Windows.Forms.CheckBox();
            this.btnHome = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(199, 76);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(125, 27);
            this.txtKategoriAdi.TabIndex = 2;
            // 
            // btnFotografSec
            // 
            this.btnFotografSec.Location = new System.Drawing.Point(107, 120);
            this.btnFotografSec.Name = "btnFotografSec";
            this.btnFotografSec.Size = new System.Drawing.Size(217, 29);
            this.btnFotografSec.TabIndex = 3;
            this.btnFotografSec.Text = "Kategori Fotoğrafı Seç";
            this.btnFotografSec.UseVisualStyleBackColor = true;
            this.btnFotografSec.Click += new System.EventHandler(this.btnFotografSec_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(230, 183);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pbFotograf
            // 
            this.pbFotograf.Location = new System.Drawing.Point(474, 78);
            this.pbFotograf.Name = "pbFotograf";
            this.pbFotograf.Size = new System.Drawing.Size(170, 144);
            this.pbFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotograf.TabIndex = 5;
            this.pbFotograf.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori Fotoğrafı";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(230, 237);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(230, 285);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 29);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvKategoriListe
            // 
            this.dgvKategoriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriListe.Location = new System.Drawing.Point(12, 403);
            this.dgvKategoriListe.Name = "dgvKategoriListe";
            this.dgvKategoriListe.RowHeadersWidth = 51;
            this.dgvKategoriListe.RowTemplate.Height = 29;
            this.dgvKategoriListe.Size = new System.Drawing.Size(973, 253);
            this.dgvKategoriListe.TabIndex = 9;
            this.dgvKategoriListe.SelectionChanged += new System.EventHandler(this.dgvKategoriListe_SelectionChanged);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(729, 325);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(94, 29);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori ID:";
            // 
            // txtKategoriID
            // 
            this.txtKategoriID.Location = new System.Drawing.Point(199, 40);
            this.txtKategoriID.Name = "txtKategoriID";
            this.txtKategoriID.Size = new System.Drawing.Size(125, 27);
            this.txtKategoriID.TabIndex = 12;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(230, 325);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(94, 29);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // chbTemizle
            // 
            this.chbTemizle.AutoSize = true;
            this.chbTemizle.Location = new System.Drawing.Point(87, 183);
            this.chbTemizle.Name = "chbTemizle";
            this.chbTemizle.Size = new System.Drawing.Size(137, 24);
            this.chbTemizle.TabIndex = 14;
            this.chbTemizle.Text = "Seçileni Temizle";
            this.chbTemizle.UseVisualStyleBackColor = true;
            this.chbTemizle.CheckedChanged += new System.EventHandler(this.chbTemizle_CheckedChanged);
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
            this.btnHome.Location = new System.Drawing.Point(12, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.PenWidth = 15;
            this.btnHome.Rounding = true;
            this.btnHome.RoundingInt = 70;
            this.btnHome.Size = new System.Drawing.Size(49, 37);
            this.btnHome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnHome.TabIndex = 15;
            this.btnHome.Tag = "Cyber";
            this.btnHome.TextButton = "";
            this.btnHome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnHome.Timer_Effect_1 = 5;
            this.btnHome.Timer_RGB = 300;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // KategoriCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 777);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.chbTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKategoriID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvKategoriListe);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbFotograf);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnFotografSec);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KategoriCRUD";
            this.Text = "KategoriCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtKategoriAdi;
        private Button btnFotografSec;
        private Button btnEkle;
        private PictureBox pbFotograf;
        private Label label2;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dgvKategoriListe;
        private Button btnListele;
        private Label label3;
        private TextBox txtKategoriID;
        private Button btnAra;
        private CheckBox chbTemizle;
        private ReaLTaiizor.Controls.CyberButton btnHome;
    }
}