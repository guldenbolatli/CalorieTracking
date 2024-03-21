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
using System.Windows.Forms.DataVisualization.Charting;

namespace DiyetTakip_UI.KullaniciIslemleri
{
    public partial class Ozet : Form
    {
        OgunTakibiBLL _ogunTakibiBLL = new OgunTakibiBLL(new OgunTakibiManager(new Context()));
        OgunTakibi ogunTakibi = new OgunTakibi();
        Kullanici kullanici1;
        List<string> kullaniciGunSonuRaporu;
        List<OgunTakibi> ogunBazliList1;
        List<string> kaloriHaftalikRaporList;
        public Ozet(Kullanici kullanici)
        {
            kullanici1 = kullanici;
            InitializeComponent();
            kullaniciGunSonuRaporu = _ogunTakibiBLL.GunSonuRaporu(kullanici);

        }

        private void Ozet_Load(object sender, EventArgs e)
        {

            YemekKaloriBilgileriAyarla();
            kaloriHaftalikRaporList = HaftalikKullaniciRaporu(kullanici1);
            KaloriRaporGrafikAyarla();

        }
        public List<string> HaftalikKullaniciRaporu(Kullanici kullanici)
        {
            List<string> raporListesi = new List<string>();

            DateTime startDate = DateTime.Now.Date.AddDays(-6); // Son 7 günün başlangıç tarihi (bugün - 6 gün)
            DateTime endDate = DateTime.Now.Date; // Bugünün tarihi

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                List<OgunTakibi> ogunBazliList = _ogunTakibiBLL.Listele()
                    .Where(x => x.OlusturmaTarihi.Date == currentDate && x.KullaniciID == kullanici.KullaniciID)
                    .ToList();

                float gunlukToplamKalori = ogunBazliList.Sum(x => x.UrunToplamKalori);
                if (gunlukToplamKalori > 0)
                {
                    string rapor = $"{currentDate.ToShortDateString()}: {gunlukToplamKalori} Kalori";
                    raporListesi.Add(rapor);
                }
            }
            return raporListesi;
        }

        private void KaloriRaporGrafikAyarla()
        {
            // Sütun grafiğini temizle
            chrtKaloriRaporu.Series.Clear();

            // Yeni bir sütun serisi oluştur
            var series = new Series
            {
                Name = "Toplam Kalori",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };

            foreach (string rapor in kaloriHaftalikRaporList)
            {
                string[] raporBilgileri = rapor.Split(':');
                string tarih = raporBilgileri[0].Trim();
                float kalori = float.Parse(raporBilgileri[1].Trim().Split(' ')[0]);

                series.Points.AddXY(tarih, kalori);
            }

            // Sütun serisini grafiğe ekle
            chrtKaloriRaporu.Series.Add(series);
     
        }



        #region Günlük yemek kalori bilgileri metodu
        /// <summary>
        /// Grupbox a günlük yemek kalori bilgilerini atar ve yazım ayarlamaları yapar.
        /// </summary>
        private void YemekKaloriBilgileriAyarla()
        {
            string gunlukToplamKalori = kullaniciGunSonuRaporu[0].Substring(kullaniciGunSonuRaporu[0].IndexOf(":") + 2);
            lblAlinanKalori.Text = gunlukToplamKalori;
            int gunlukHarcananToplamKalori = int.Parse(gunlukToplamKalori);
            int gunlukKalanToplamKalori = (int)kullanici1.GunlukKaloriIhtiyaci - gunlukHarcananToplamKalori;
            lblKullaniciKilo.Text = kullanici1.Kilo.ToString();
            //lblHedefKilo.Text = kullanici1.HedefKilo.ToString(); //Migration yaptıktan sonra gelecek.
            lblHedefKalori.Text = ((int)kullanici1.GunlukKaloriIhtiyaci).ToString();
            lblEgzersizKalori.Text = "0";

            // Renk değerlerini hesapla
            int minKalori = 0; // Alt limit
            int maxKalori = (int)kullanici1.GunlukKaloriIhtiyaci; // Üst limit
            int minR = 255; // En düşük kırmızı değeri
            int maxG = 180; // En yüksek yeşil değeri

            int r, g, b;

            if (gunlukKalanToplamKalori < minKalori)
            {
                r = minR;
                g = 0;
                b = 0;
            }
            else if (gunlukKalanToplamKalori > maxKalori)
            {
                r = 0;
                g = maxG;
                b = 0;
            }
            else
            {
                double percent = (double)(gunlukKalanToplamKalori - minKalori) / (maxKalori - minKalori);
                r = (int)((1 - percent) * minR);
                g = (int)(percent * maxG);
                b = 0;
            }
            lblKalanKalori.Text = gunlukKalanToplamKalori.ToString();
            lblKalanKalori.ForeColor = Color.FromArgb(r, g, b);

        }

        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            kullaniciGunSonuRaporu = _ogunTakibiBLL.GunSonuRaporu(kullanici1,dateTimePicker1.Value.Date);
            YemekKaloriBilgileriAyarla();
            kaloriHaftalikRaporList = HaftalikKullaniciRaporu(kullanici1);
            KaloriRaporGrafikAyarla();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            KullaniciGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}

