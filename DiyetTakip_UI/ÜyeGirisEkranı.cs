using DiyetTakip_BLL;
using DiyetTakip_DAL.Manager;
using DiyetTakip_DAL;
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
using DiyetTakip_UI.KullaniciIslemleri;
using ReaLTaiizor.Controls;
using System.Numerics;
using System.Reflection.Metadata;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;


namespace DiyetTakip_UI
{
    public partial class ÜyeGirisEkranı : Form
    {
       
       
        public ÜyeGirisEkranı()
        {
            InitializeComponent();
            

            if (MailKaydet.Default.KaydetsinMi)
            {
                if (!string.IsNullOrEmpty(MailKaydet.Default.SonMail))
                {
                    txtEmail.Text = MailKaydet.Default.SonMail;
                    txtPassword.Text = MailKaydet.Default.SonSifre;
                   
                }
            }
            else
            {
                SetPlaceholderText(txtEmail, "E-posta adresinizi girin");
                SetPlaceholderText(txtPassword, "Şifrenizi girin");
                txtPassword.UseSystemPasswordChar = true;
            }
            txtPassword.UseSystemPasswordChar = true;
        }

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
                    txtPassword.UseSystemPasswordChar = false;
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


        private void btnHome_Click(object sender, EventArgs e)
        {
            AcilisEkrani.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }



        KullaniciBLL _kullaniciBLL = new KullaniciBLL(new KullaniciManager(new Context()));
        Kullanici kullanici;

        
        private  void btnLogin_Click(object sender, EventArgs e)
        {

            string kontrol = _kullaniciBLL.KullaniciAdminKontrol(txtEmail.Text, txtPassword.Text);
            switch (kontrol)
            {
                case "admin":
                    MessageBox.Show("Giriş Başarılı");
                    AdminGiris adminGiris = new AdminGiris();
                    adminGiris.ShowDialog();
                    break;
                case "kullanici":
                    MessageBox.Show("Giriş Başarılı");
                    KullaniciGiris kullaniciGiris = new KullaniciGiris(txtEmail.Text);
                    kullaniciGiris.ShowDialog();
                    break;
                case "HataliGiris":
                    MessageBox.Show("Email veya Şifre Yanlis");
                    break;
            }
            //MailKayıt
            if (chkRememberMe.Checked)
            {
                MailKaydet.Default.KaydetsinMi = true;
                MailKaydet.Default.SonMail = txtEmail.Text;
                MailKaydet.Default.SonSifre = txtPassword.Text;
                MailKaydet.Default.Save();
            }
            else
            {
                MailKaydet.Default.KaydetsinMi = false;
                MailKaydet.Default.SonMail = string.Empty;
                MailKaydet.Default.SonSifre = string.Empty;
                MailKaydet.Default.Save();
            }
        }
       

        private void chkSifreGorunurluk_CheckedChanged(object sender, EventArgs e)
        {

            txtPassword.UseSystemPasswordChar = true; 
            if (chkSifreGorunurluk.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
           
        }

       
    }
}

