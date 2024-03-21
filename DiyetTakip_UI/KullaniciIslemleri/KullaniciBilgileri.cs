using DiyetTakip_BLL;
using DiyetTakip_DAL.Manager;
using DiyetTakip_DAL;
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

namespace DiyetTakip_UI.KullaniciIslemleri
{
    public partial class KullaniciBilgileri : Form
    {
        Kullanici kullanici;
        KullaniciBLL _kullaniciBLL = new KullaniciBLL(new KullaniciManager(new Context()));

        public KullaniciBilgileri(Kullanici girisYapanKullanici)
        {
            InitializeComponent();
            cmbBeslenmeTarzi.DataSource = AcilisEkrani.beslenmeTercihleri;
            cmbDiyetZorlukSeviyesi.DataSource = AcilisEkrani.diyetZorlukSeviyeleri;
            cmbHareketSeviyesi.DataSource = AcilisEkrani.hareketSeviyeleri;
            kullanici = girisYapanKullanici;
            txtAd.Text = girisYapanKullanici.Ad;
            txtBoy.Text = girisYapanKullanici.Boy.ToString();
            txtEmail.Text = girisYapanKullanici.Email;
            txtKilo.Text = girisYapanKullanici.Kilo.ToString();
            txtSifre.Text = girisYapanKullanici.Sifre;
            txtSoyad.Text = girisYapanKullanici.Soyad;
            cmbHareketSeviyesi.SelectedItem = girisYapanKullanici.HareketSeviyesi;
            cmbDiyetZorlukSeviyesi.SelectedItem = girisYapanKullanici.DiyetZorlukSeviyesi;
            cmbBeslenmeTarzi.SelectedItem = girisYapanKullanici.BeslenmeTercihi;
            dtpDogumTarihi.Value = girisYapanKullanici.DogumTarihi;
            rdbErkek.Checked = !girisYapanKullanici.Cinsiyet;
        }

        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kullanici.Ad = txtAd.Text;
            kullanici.Boy = int.Parse(txtBoy.Text);
            kullanici.Sifre=txtSifre.Text;
            kullanici.Email=txtEmail.Text;
            kullanici.BeslenmeTercihi = cmbBeslenmeTarzi.SelectedItem.ToString();
            kullanici.Cinsiyet=rdbKadın.Checked;
            kullanici.DiyetZorlukSeviyesi=cmbDiyetZorlukSeviyesi.SelectedItem.ToString();
            kullanici.DogumTarihi = dtpDogumTarihi.Value;
            kullanici.HareketSeviyesi = cmbHareketSeviyesi.SelectedItem.ToString();
            kullanici.Kilo=float.Parse(txtKilo.Text);
            kullanici.Soyad = txtSoyad.Text;
            kullanici.BazalMetobalizma = _kullaniciBLL.BazalMetabolizmaHesaplama(kullanici);
            kullanici.VucutKitleEndeksi = _kullaniciBLL.VucutKitleEndeksiHesaplama(kullanici);
            kullanici.GunlukKaloriIhtiyaci = _kullaniciBLL.HarcanmasiGerekenGunlukKalori(kullanici);
            _kullaniciBLL.Guncelle(kullanici);
            MessageBox.Show("Basarili");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            KullaniciGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
