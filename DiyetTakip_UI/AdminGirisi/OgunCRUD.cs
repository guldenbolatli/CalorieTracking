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

namespace DiyetTakip_UI.AdminGirisi
{
    public partial class OgunCRUD : Form
    {
        OgunBLL ogunBll = new OgunBLL(new OgunManager(new Context()));
        public OgunCRUD()
        {
            InitializeComponent();
            txtOgunID.Enabled= false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogun ogun = new Ogun();
            ogun.Ad = txtOgunAd.Text;
            ogunBll.Ekle(ogun);
            DataGridViewDoldur();
            Temizle();

        }
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            DataGridViewDoldur();
            Temizle();
            //Ogundekullanicilarin yedigi kolon kapatilacak
        }

        public void Temizle()
        {
            if (dgvOgunListe.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvOgunListe.SelectedRows[0].Index;
                dgvOgunListe.Rows[selectedIndex].Selected = false;
            }
            txtOgunID.Text = string.Empty;
            txtOgunAd.Text = string.Empty;

        }

        public void DataGridViewDoldur()
        {
            dgvOgunListe.DataSource = null;
            dgvOgunListe.DataSource = ogunBll.Listele();
            dgvOgunListe.AutoGenerateColumns = true;
            dgvOgunListe.Columns["AktifMİ"].Visible = false;
            dgvOgunListe.Columns["OgundeKullancilarinYedigiYiyecekler"].Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ogun guncellenecekOgun = ogunBll.Ara(int.Parse(txtOgunID.Text));
            guncellenecekOgun.OgunId = Convert.ToInt32(txtOgunID.Text);
            guncellenecekOgun.Ad = txtOgunAd.Text;
            ogunBll.Guncelle(guncellenecekOgun);
            DataGridViewDoldur();
            Temizle();
        }

        private void dgvOgunListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOgunListe.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOgunListe.CurrentRow;
                int OgunID = Convert.ToInt32(selectedRow.Cells["OgunId"].Value);
                string OgunAdi = Convert.ToString(selectedRow.Cells["Ad"].Value);
                txtOgunID.Text = OgunID.ToString();
                txtOgunAd.Text = OgunAdi;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Ogun silenecekOgun = ogunBll.Ara(int.Parse(txtOgunID.Text));
            ogunBll.Sil(silenecekOgun);
            DataGridViewDoldur();
            Temizle();
            MessageBox.Show(silenecekOgun.Ad + " Adli Ogun Silinmiştir.");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
