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

namespace DiyetTakip_UI
{
    public partial class KodKontrol : Form
    {
        string kod, email, isim;
        public static bool kontrol = false;
        KullaniciBLL _kullaniciBLL = new KullaniciBLL(new KullaniciManager(new Context()));
        private int remainingTime;
        private bool linkLabelActive;
        public KodKontrol(string _kod, string _email, string _isim)
        {
            InitializeComponent();
            kod = _kod;
            email = _email;
            isim = _isim;

            timer1.Interval = 1000; // 1 saniye
            timer1.Tick += Timer_Tick;
            timer1.Enabled = false; // Timer'ı başlangıçta durdurun

            // LinkLabel ayarlarını yapın
            linkLabel1.Text = "Mail Gelmediyse. Maili Tekrar Gönder.";
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Blue;
            linkLabelActive = true;

            // Label ayarlarını yapın
            label1.Text = "";

            // Geriye kalan süreyi belirleyin (saniye cinsinden)
            remainingTime = 60;

            // Timer'ı başlatmadan önce LinkLabel'ın LinkClicked olayını tanımlayın
            linkLabel1.LinkClicked += linkLabel_LinkClicked;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            // Geriye kalan süreyi label'a yazın
            label1.Text = $"Kalan süre: {remainingTime} saniye";

            if (remainingTime == 0)
            {
                // Süre bittiğinde LinkLabel'ı tıklanabilir hale getirin
                timer1.Stop();
                label1.Text = "";
                linkLabel1.Text = "Tıklanabilir değil";
                linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
                linkLabel1.LinkColor = Color.Gray;
                linkLabelActive = false;
            }
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelActive)
            {
                // LinkLabel'a tıklandığında yapılacak işlemleri burada tanımlayabilirsiniz
                MessageBox.Show("Tekrar Mail Gönderildi!");

                // Timer'ı yeniden başlatın
                remainingTime = 60;
                timer1.Start();
            }
        }

       
        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (kod == txtKod.Text)
            {
                kontrol = true;
                MessageBox.Show("Kodu Doğru Girdiniz.");
                this.Close();
            }
            else
            {
                kontrol = false;
                MessageBox.Show("kod yanlis");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _kullaniciBLL.EmailKodGonder(email, kod, isim);
        }
    }
}
