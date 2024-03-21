using DiyetTakip_BLL;
using DiyetTakip_DAL.Manager;
using DiyetTakip_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiyetTakip_Entities;

namespace DiyetTakip_UI.AdminGirisi
{
    public partial class KategoriCRUD : Form
    {
        string hedefDosyaAdi = null;
        KategoriBLL _kategoriBLL = new KategoriBLL(new KategoriManager(new Context()));
        Kategori kategori;
        public KategoriCRUD()
        {
            InitializeComponent();
            txtKategoriID.Enabled = false;
            dgvKategoriListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnFotografSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog.FileName;

                hedefDosyaAdi = Path.Combine(Path.GetFileName(secilenDosyaYolu));
                hedefDosyaAdi = $"diyet/{hedefDosyaAdi}";
                pbFotograf.Image = Image.FromFile(hedefDosyaAdi);


            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kategori = new Kategori
            {
                Ad = txtKategoriAdi.Text,
                Fotograf = hedefDosyaAdi
            };

            _kategoriBLL.Ekle(kategori);
            MessageBox.Show(txtKategoriAdi.Text + " Adlı Kategori Başarı ile Eklendi.");
            Temizle();
            DataGridViewDoldur();
            chbTemizle.Checked = false;


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kategori silenecekKategori = _kategoriBLL.Ara(int.Parse(txtKategoriID.Text));
            _kategoriBLL.Sil(silenecekKategori);
            DataGridViewDoldur();
            Temizle();
            MessageBox.Show(silenecekKategori.Ad + " Adli Kategori Silinmiştir.");

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataGridViewDoldur();
            Temizle();
        }



        private void dgvKategoriListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKategoriListe.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvKategoriListe.CurrentRow;
                int KategoriID = Convert.ToInt32(selectedRow.Cells["KategoriID"].Value);
                string kategoriAdi = Convert.ToString(selectedRow.Cells["Ad"].Value);
                txtKategoriID.Text = KategoriID.ToString();
                txtKategoriAdi.Text = kategoriAdi;
                if (hedefDosyaAdi != null)
                    pbFotograf.Image = Image.FromFile(hedefDosyaAdi);
            }
        }
        public void Temizle()
        {
            if (dgvKategoriListe.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvKategoriListe.SelectedRows[0].Index;
                dgvKategoriListe.Rows[selectedIndex].Selected = false;
            }
            txtKategoriID.Text = string.Empty;
            txtKategoriAdi.Text = string.Empty;
            pbFotograf.Image = null;

            //txtKategoriAdi.Clear();  Clear() metodu yeni bir dize nesnesi oluşturduğu için kullanılan hafıza mikharı biraz daha fazladır.(string.Epmty'e göre)

        }
        public void DataGridViewDoldur()
        {
            dgvKategoriListe.DataSource = null;
            dgvKategoriListe.DataSource = _kategoriBLL.Listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kategori guncellenecekKategori = _kategoriBLL.Ara(int.Parse(txtKategoriID.Text));
            guncellenecekKategori.Ad = txtKategoriAdi.Text;
            guncellenecekKategori.Fotograf = hedefDosyaAdi;
            _kategoriBLL.Guncelle(guncellenecekKategori);
            DataGridViewDoldur();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            Kategori bulunanKategori = _kategoriBLL.Listele()
    .FirstOrDefault(x => x.Ad.Equals(txtKategoriAdi.Text));

            if (bulunanKategori != null)
            {
                txtKategoriAdi.Text = bulunanKategori.Ad;
                txtKategoriID.Text = bulunanKategori.KategoriID.ToString();
                hedefDosyaAdi = bulunanKategori.Fotograf;
                dgvKategoriListe.DataSource = new List<Kategori> { bulunanKategori };
            }
            else
            {
                dgvKategoriListe.DataSource = null;
            }
        }

        private void chbTemizle_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
