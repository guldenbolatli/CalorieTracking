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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DiyetTakip_UI.AdminGirisi;

namespace DiyetTakip_UI.KullaniciIslemleri
{
    public partial class KacKalori : Form
    {
        public KacKalori()
        {
            InitializeComponent();
        }

        List<Yiyecek> yiyecekListesi = new YiyecekManager(new Context()).Listele();
        private void KacKalori_Load(object sender, EventArgs e)
        {

            foreach (var item in yiyecekListesi)
            {
                lstYiyecekler.Items.Add(item.Ad + " - (" + item.Kalori + " Kalori)");
                txtYiyecekAdi.TextChanged += TextBox1_TextChanged;
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtYiyecekAdi.Text.ToLower();

            lstYiyecekler.Items.Clear();

            foreach (var item in yiyecekListesi)
            {
                if (item.Ad.ToLower().Contains(searchText))
                {
                    lstYiyecekler.Items.Add(item.Ad + " - (" + item.Kalori + " Kalori)");
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            KullaniciGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
