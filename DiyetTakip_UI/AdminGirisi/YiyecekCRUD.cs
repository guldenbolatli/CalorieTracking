using DiyetTakip_BLL;
using DiyetTakip_DAL;
using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace DiyetTakip_UI.AdminGirisi
{
    public partial class YiyecekCRUD : Form
    {
        YiyecekBLL _yiyecekBLL = new YiyecekBLL(new YiyecekManager(new Context()));
        string hedefDosyaAdi;
        Yiyecek yiyecek;
        public YiyecekCRUD()
        {
            InitializeComponent();
            txtYiyecekID.Enabled= false;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int _kategoriID;
            float kalori, karbonhidratMiktari, yagMiktari, proteinMiktari;
            bool kaloriKontrol=float.TryParse(txtKalori.Text, out kalori);
            bool karbonhidratKontrol = float.TryParse(txtKarbonhidratMiktari.Text, out karbonhidratMiktari);
            bool yagKontrol=float.TryParse(txtYagMiktari.Text, out yagMiktari);
            bool proteinKontrol=float.TryParse(txtProteinMiktari.Text, out proteinMiktari);
            if(yagKontrol && proteinKontrol && karbonhidratKontrol && kaloriKontrol && cmbKategoriID.SelectedValue!=null)
            {
                try
                {
                    yiyecek = new Yiyecek
                    {
                        Ad = txtYiyecekAdi.Text.Trim(),
                        KategoriID = (int)cmbKategoriID.SelectedValue,
                        MiktarTuru = cmbMiktarTürü.SelectedItem.ToString(),
                        Kalori = float.Parse(txtKalori.Text),
                        KarbonhidratMiktari = float.Parse(txtKarbonhidratMiktari.Text),
                        YagMiktari = float.Parse(txtYagMiktari.Text),
                        ProteinMiktari = float.Parse(txtProteinMiktari.Text),
                        Fotograf = hedefDosyaAdi,
                    };
                    _yiyecekBLL.Ekle(yiyecek);
                    MessageBox.Show("Basarili");
                    FormTemizle();
                    dgvLİstele();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if(!yagKontrol)
                MessageBox.Show("Yağ Miktarını Sayısal Değer Giriniz.");
            else if(!proteinKontrol)
                MessageBox.Show("Protein Miktarını Sayısal Değer Giriniz.");
            else if(!karbonhidratKontrol)
                MessageBox.Show("Karbonhidrat Miktarını Sayısal Değer Giriniz.");
            else if(!kaloriKontrol)
                MessageBox.Show("Kalori Miktarını Sayısal Değer Giriniz.");
            else if(cmbKategoriID.SelectedValue == null)
                MessageBox.Show("Kategori Değerini Lütfen Seçiniz.");


        }
        public void FormTemizle()
        {
            if (dgvYiyecekListesi.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvYiyecekListesi.SelectedRows[0].Index;
                dgvYiyecekListesi.Rows[selectedIndex].Selected = false;
            }
            foreach (Control item in this.Controls)
            {
               if(item is System.Windows.Forms.GroupBox groupBox)
                {
                    foreach(Control control in groupBox.Controls)
                    {
                        if (control is TextBox textBox)
                        {
                            textBox.Text = string.Empty;

                        }
                        else if (control is ComboBox comboBox)
                        {
                            comboBox.SelectedIndex = -1;
                        }
                        else if (control is System.Windows.Forms.CheckBox checkBox)
                        {
                            checkBox.Checked = false;
                        }
                        else if (control is PictureBox pictureBox)
                        {
                            pictureBox.Image = null;
                        }
                    }
                }
            }  
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvLİstele();
        }
        public void dgvLİstele()
        {
            dgvYiyecekListesi.DataSource = null;
            dgvYiyecekListesi.DataSource = _yiyecekBLL.Listele();
            dgvYiyecekListesi.AutoGenerateColumns = true;
            dgvYiyecekListesi.Columns["Tarif"].Visible = false;
            dgvYiyecekListesi.Columns["Kategori"].Visible = false;
            dgvYiyecekListesi.Columns["AlerjisiOlanKullanicilar"].Visible = false;
            dgvYiyecekListesi.Columns["YiyeceginYendigiKullaniciOgunleri"].Visible = false;
            dgvYiyecekListesi.Columns["AktifMİ"].Visible = false;

        }

        private void YiyecekCRUD_Load(object sender, EventArgs e)
        {
            cmbMiktarTürü.DataSource = AcilisEkrani.miktarTuru;
            List<Kategori> kategoriListesi = new KategoriManager(new Context()).Listele();
            cmbKategoriID.DataSource = kategoriListesi;
            cmbKategoriID.DisplayMember = "Ad";
            cmbKategoriID.ValueMember = "KategoriID";
            dgvYiyecekListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog.FileName;
                hedefDosyaAdi = Path.Combine(Path.GetFileName(secilenDosyaYolu));
                pbFotograf.Image = Image.FromFile(hedefDosyaAdi);

            }
        }

        private void cmbMiktarTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMiktarTürü.SelectedItem == "adet")
                lblBilgi.Text = "1 adet için gerekli bilgileri giriniz.";
            else if (cmbMiktarTürü.SelectedItem == "gram")
                lblBilgi.Text = "100 gram için gerekli bilgileri giriniz.";
            else if (cmbMiktarTürü.SelectedItem == "miliLitre")
                lblBilgi.Text = "100 ml için gerekli bilgileri giriniz.";
            else
                lblBilgi.Text = "";
        }

        private void chbTemizle_CheckedChanged(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Yiyecek silenecekYiyecek = _yiyecekBLL.Ara(int.Parse(txtYiyecekID.Text));
            _yiyecekBLL.Sil(silenecekYiyecek);
            dgvLİstele();
            FormTemizle();
        }

        private void dgvYiyecekListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvYiyecekListesi.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dgvYiyecekListesi.CurrentRow;
                int yiyecekID = int.Parse(selectedRow.Cells["YiyecekID"].Value.ToString());
                Yiyecek seciliYiyecek = _yiyecekBLL.Ara(yiyecekID);
                txtYiyecekID.Text = yiyecekID.ToString();
                txtYiyecekAdi.Text = seciliYiyecek.Ad;
                txtKalori.Text = seciliYiyecek.Kalori.ToString();
                txtKarbonhidratMiktari.Text=seciliYiyecek.KarbonhidratMiktari.ToString();
                txtProteinMiktari.Text = seciliYiyecek.ProteinMiktari.ToString();
                txtYagMiktari.Text = seciliYiyecek.YagMiktari.ToString();
                cmbKategoriID.SelectedValue = seciliYiyecek.KategoriID;
                cmbMiktarTürü.SelectedItem = seciliYiyecek.MiktarTuru;
                if (seciliYiyecek.Fotograf != null)
                {
                    pbFotograf.Image = Image.FromFile(seciliYiyecek.Fotograf);
                }
               

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
