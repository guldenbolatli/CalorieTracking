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
using ReaLTaiizor.Controls;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;

namespace DiyetTakip_UI.KullaniciIslemleri
{
    public partial class Raporlar : Form
    {
        OgunTakibiBLL _ogunTakibiBLL = new OgunTakibiBLL(new OgunTakibiManager(new Context()));
        OgunTakibi ogunTakibi = new OgunTakibi();
        Kategori kategori= new Kategori();
        List<Yiyecek> yiyecekListesi = new YiyecekManager(new Context()).Listele();
        Ogun ogun = new Ogun() { OgunId = 1 };
        Yiyecek yiyecek= new Yiyecek() { YiyecekID=7 };
        int x, y;
        string periyot;
        Kullanici kullanici;
        List<string> kaloriHaftalikRaporList;
        List<string> kullaniciGunSonuRaporu;
        Context _ctx=new Context();
        public Raporlar(Kullanici _kullanici)
        {
            InitializeComponent();
            cmbPeriyot.SelectedIndex = 0;
            lblRapor.Visible= false;
            kullanici= _kullanici;
        }

        //belirlenen periyotta hangi öğünde toplam kaç kalori harcanmış
        private void btnOgunBazliKiyasRaporu_Click(object sender, EventArgs e)
        {
          

            periyot = cmbPeriyot.SelectedItem.ToString().ToLower();
            lstOgunBazliKiyasRaporu.DataSource = _ogunTakibiBLL.OgunBazliKiyasRaporu(periyot);

            lstOgunBazliKiyasRaporu.Visible = true;

            lstOgunBazliKiyasRaporu.Height = 379;
            lstOgunBazliKiyasRaporu.Width = 400;


            lstOgunBazliKiyasRaporu.Location = new System.Drawing.Point(120, 180);
            lblRapor.Location = new System.Drawing.Point(120, 160);
            lblRapor.Text=$"{cmbPeriyot.SelectedItem.ToString()} raporu";
            foreach (Control control in Controls)
            {
                if (control is CyberButton button)
                {
                    button.Visible = false;
                }
            }
            lblBaslik.Text = "Öğün Bazlı Kıyas Raporu";
            moonLabel2.Visible = false;
            moonLabel3.Visible = false;
            dateTimePicker1.Visible = false;
            cmbPeriyot.Visible = false;
            lblRapor.Visible = true;
            btnGeri.Visible = true;

            chart1.Visible = true;
            chart1.Location = new System.Drawing.Point(lstOgunBazliKiyasRaporu.Width + 150, 180);


            kaloriHaftalikRaporList = _ogunTakibiBLL.OgunBazliKiyasRaporu(periyot);
            chart1.Series.Clear();

            //chart1.Update();
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            foreach (string rapor in kaloriHaftalikRaporList)
            {
                string[] raporBilgileri = rapor.Split(' ');
                string ogunAdi = (raporBilgileri[0].Split('.')[0]);

                float kalori;
                if (float.TryParse(raporBilgileri[1], out kalori))
                {
                    series.Points.AddXY($"{ogunAdi} Öğünü ", kalori);
                }
            }

            // Seriyi chart kontrolüne ekle
            chart1.Series.Add(series);
            chart1.Series[0].Label = "#VALY";
            chart1.Series[0].LegendText = "#AXISLABEL";
            chart1.Series[0].Font = new Font("Arial", 8, FontStyle.Bold);
            chart1.Series[0].LabelForeColor = Color.Black;

            chart1.Update();
           

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is CyberButton button)
                {
                    button.Visible = true; ;
                }
                if (control is ListBox listBox)
                {
                    listBox.Visible = false;
                }

            }
            lblBaslik.Text = "RAPORLAR";
            moonLabel2.Visible = true;
            moonLabel3.Visible = true;
            dateTimePicker1.Visible = true;
            cmbPeriyot.Visible = true;
            lblRapor.Visible = false;
            chrtGunlukKalori.Visible = false;
            chart1.Visible = false;
        }


        //Hangi yemeklerin hangi öğünlerde ne kadar yendiğinin sayısı
        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            lstYemekCesidiRaporu.DataSource = _ogunTakibiBLL.YemekCesidiRaporu();
            lstYemekCesidiRaporu.Visible = true;


            lstYemekCesidiRaporu.Location = new System.Drawing.Point(120, 180);
            lstYemekCesidiRaporu.Height = 379;
            lstYemekCesidiRaporu.Width = 800;
            lblRapor.Location = new System.Drawing.Point(120, 160);

            foreach (Control control in Controls)
            {
                if (control is CyberButton button)
                {
                    button.Visible = false;
                }

            }
            lblBaslik.Text = "Yemek Çeşidi Raporu";
            moonLabel2.Visible = false;
            moonLabel3.Visible = false;
            dateTimePicker1.Visible = false;
            cmbPeriyot.Visible = false;
            lblRapor.Visible = false;
            btnGeri.Visible = true;
        }


        //Gün sonunda kullanıcı günlük kaç kalori harcadı
        private void btnGunSonuRaporu_Click(object sender, EventArgs e)
        {
            lstGunSonuRaporu.DataSource = _ogunTakibiBLL.GunSonuRaporu(kullanici, dateTimePicker1.Value.Date);
            lstGunSonuRaporu.Visible = true;


            lstGunSonuRaporu.Location = new System.Drawing.Point(120, 180);
            lblRapor.Location = new System.Drawing.Point(120, 160);
            lstGunSonuRaporu.Width = 400;
            lstGunSonuRaporu.Height = 379;
            lblRapor.Text = $"{dateTimePicker1.Value.Day}.{dateTimePicker1.Value.Month}.{dateTimePicker1.Value.Year} - {dateTimePicker1.Value.ToString("dddd",new CultureInfo("tr-TR"))} Günü Raporu";
            foreach (Control control in Controls)
            {
                if (control is CyberButton button)
                {
                    button.Visible = false;
                }
            }
            lblBaslik.Text = "Gün Sonu Raporu";
            moonLabel2.Visible = false;
            moonLabel3.Visible = false;
            dateTimePicker1.Visible = false;
            cmbPeriyot.Visible = false;
            chart1.Visible = false;
            lblRapor.Visible = true;
            btnGeri.Visible = true;
            chrtGunlukKalori.Visible = true;
            chrtGunlukKalori.Location= new System.Drawing.Point(lstGunSonuRaporu.Width + 150, 180);

            kullaniciGunSonuRaporu = _ogunTakibiBLL.GunSonuRaporu(kullanici);
            string gunlukToplamKalori = kullaniciGunSonuRaporu[0].Substring(kullaniciGunSonuRaporu[0].IndexOf(":") + 2);
            chrtGunlukKalori.Series.Clear();

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Günlük Toplam Kalori";
            series.Points.AddXY("Kcal", gunlukToplamKalori);
            chrtGunlukKalori.Series.Add(series);
            chrtGunlukKalori.Update();
        }


        //belirtilen periyotta hangi kategoriden öğünlük toplam kalorisi
        private void btnKategoriBazliKiyasRaporu_Click(object sender, EventArgs e)
        {
            periyot = cmbPeriyot.SelectedItem.ToString().ToLower();
            lstKategoriBazliKiyasRaporu.DataSource = _ogunTakibiBLL.KategoriBazliKiyasRaporu(periyot);
            lstKategoriBazliKiyasRaporu.Visible = true;


            lstKategoriBazliKiyasRaporu.Location = new System.Drawing.Point(120, 180);
            lstKategoriBazliKiyasRaporu.Height = 379;
            lstKategoriBazliKiyasRaporu.Width = 400;
            lblRapor.Location = new System.Drawing.Point(120, 160);
            lblRapor.Text = $"{cmbPeriyot.SelectedItem.ToString()} raporu";
            foreach (Control control in Controls)
            {
                if (control is CyberButton button)
                {
                    button.Visible = false;
                }
            }
            lblBaslik.Text = "Kategori Bazlı Kıyas Raporu";
            moonLabel2.Visible = false;
            moonLabel3.Visible = false;
            dateTimePicker1.Visible = false;
            cmbPeriyot.Visible = false;
            lblRapor.Visible = true;
            btnGeri.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            KullaniciGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is ListBox listBox)
                {
                    listBox.Visible = false;
                }
                
            }
            chrtGunlukKalori.Visible = false;
            chart1.Visible = false;
        }
    }
}
