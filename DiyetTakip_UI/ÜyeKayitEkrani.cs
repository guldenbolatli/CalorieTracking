using DiyetTakip_BLL;
using DiyetTakip_DAL;
using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using DiyetTakip_UI.AdminGirisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetTakip_UI
{
    public partial class ÜyeKayitEkrani : Form
    {
        KullaniciBLL _kullaniciBLL = new KullaniciBLL(new KullaniciManager(new Context()));
        Kullanici kullanici;
        public ÜyeKayitEkrani()
        {
            InitializeComponent();

            SetPlaceholderText(txtBoy, "örn:162 Cm");
            SetPlaceholderText(txtKilo, "örn:53 Kg");
            SetPlaceholderText(txtEmail, "E-posta adresinizi girin");
            SetPlaceholderText(txtSifre, "Şifrenizi girin");
            txtSifre.UseSystemPasswordChar = true;

        }
        #region textbox düzenlemesi
        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Text = placeholderText;


            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                    txtSifre.UseSystemPasswordChar = false;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = SystemColors.GrayText;
                    textBox.Text = placeholderText;
                }
            };
        }

        #endregion

        private void btnKayıt_Click(object sender, EventArgs e)
        {


            int boy;
            float kilo;
            bool emailVarMi = _kullaniciBLL.EmailKontrol(txtEmail.Text);
            bool boyIntKontrol = int.TryParse(txtBoy.Text, out boy);
            bool kiloFloatKontol = float.TryParse(txtKilo.Text, out kilo);
            bool emailHata = !emailVarMi;
            bool boyHata = !boyIntKontrol;
            bool kiloHata = !kiloFloatKontol;
            bool sifreKontrol = _kullaniciBLL.SifreZorlukKontrol(txtSifre.Text);
            bool checkKontrol=chkKontrol.Checked;
            if (emailVarMi && boyIntKontrol && kiloFloatKontol && sifreKontrol&&checkKontrol)
            {
                if (!boyHata && !kiloHata && !emailHata)
                {
                    try
                    {
                        kullanici = new Kullanici
                        {
                            Ad = txtAd.Text,
                            Soyad = txtSoyad.Text,
                            Kilo = kilo,
                            Boy = boy,
                            Email = txtEmail.Text,
                            Sifre = txtSifre.Text,
                            Cinsiyet = rdbKadın.Checked,
                            DogumTarihi = dtpDogumTarihi.Value,
                            DiyetZorlukSeviyesi = cmbDiyetZorlukSeviyesi.SelectedItem.ToString(),
                            HareketSeviyesi = cmbHareketSeviyesi.SelectedItem.ToString(),
                            BeslenmeTercihi = cmbBeslenmeTarzi.SelectedItem.ToString()
                        };
                        kullanici.GunlukKaloriIhtiyaci = _kullaniciBLL.HarcanmasiGerekenGunlukKalori(kullanici);
                        string kod = _kullaniciBLL.RastgeleKodUret();
                        _kullaniciBLL.EmailKodGonder(kullanici.Email, kod, kullanici.AdSoyad);
                        new KodKontrol(kod, kullanici.Email, kullanici.AdSoyad).ShowDialog();
                        if (KodKontrol.kontrol)
                        {
                            _kullaniciBLL.Ekle(kullanici);
                            MessageBox.Show("Üyelik işleminiz tamamlanmıştır.","" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (!KodKontrol.kontrol)
                            MessageBox.Show("Kodu Yanlis Girdiniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (boyHata)
                MessageBox.Show("Boy bilgisini sayısal bir değer giriniz.");
            
            else if(!checkKontrol)
                errorProvider1.SetError(chkKontrol, "Yasal Uyarıları Kabul Ediniz.");
            else if (kiloHata)
                MessageBox.Show("Kilo bilgisini sayısal bir değer giriniz.");
            else if (emailHata)
                MessageBox.Show("Kullanılan bir email girdiniz.");
            else if (!sifreKontrol)
                MessageBox.Show("Şifre en az 8 karakter, Bir tane büyük harf ve sayısal değer olmak zorunda.");
        }

        private void ÜyeKayitEkrani_Load(object sender, EventArgs e)
        {
            cmbBeslenmeTarzi.DataSource = AcilisEkrani.beslenmeTercihleri;
            cmbDiyetZorlukSeviyesi.DataSource = AcilisEkrani.diyetZorlukSeviyeleri;
            cmbHareketSeviyesi.DataSource = AcilisEkrani.hareketSeviyeleri;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AcilisEkrani.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox5.Location = new System.Drawing.Point(383, 80);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox5.Location = new System.Drawing.Point(289, 549);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            if (chkSifreGizle.Checked == false)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
        }
    }
}

