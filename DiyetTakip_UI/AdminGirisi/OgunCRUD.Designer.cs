namespace DiyetTakip_UI.AdminGirisi
{
    partial class OgunCRUD
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
            this.dgvOgunListe = new System.Windows.Forms.DataGridView();
            this.txtOgunID = new System.Windows.Forms.TextBox();
            this.txtOgunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHome = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgunListe
            // 
            this.dgvOgunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunListe.Location = new System.Drawing.Point(30, 225);
            this.dgvOgunListe.Name = "dgvOgunListe";
            this.dgvOgunListe.RowHeadersWidth = 51;
            this.dgvOgunListe.RowTemplate.Height = 29;
            this.dgvOgunListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgunListe.Size = new System.Drawing.Size(744, 202);
            this.dgvOgunListe.TabIndex = 0;
            this.dgvOgunListe.SelectionChanged += new System.EventHandler(this.dgvOgunListe_SelectionChanged);
            // 
            // txtOgunID
            // 
            this.txtOgunID.Location = new System.Drawing.Point(190, 38);
            this.txtOgunID.Name = "txtOgunID";
            this.txtOgunID.Size = new System.Drawing.Size(125, 27);
            this.txtOgunID.TabIndex = 1;
            // 
            // txtOgunAd
            // 
            this.txtOgunAd.Location = new System.Drawing.Point(190, 95);
            this.txtOgunAd.Name = "txtOgunAd";
            this.txtOgunAd.Size = new System.Drawing.Size(125, 27);
            this.txtOgunAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ogun ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ogun Ad:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(55, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(190, 159);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 29);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(487, 159);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(125, 29);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(629, 159);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(125, 29);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(338, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 29);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
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
            this.btnHome.TabIndex = 16;
            this.btnHome.Tag = "Cyber";
            this.btnHome.TextButton = "";
            this.btnHome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnHome.Timer_Effect_1 = 5;
            this.btnHome.Timer_RGB = 300;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // OgunCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgunAd);
            this.Controls.Add(this.txtOgunID);
            this.Controls.Add(this.dgvOgunListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgunCRUD";
            this.Text = "OgunCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOgunListe;
        private TextBox txtOgunID;
        private TextBox txtOgunAd;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private ReaLTaiizor.Controls.CyberButton btnHome;
    }
}