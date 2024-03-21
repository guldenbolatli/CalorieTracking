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
using DiyetTakip_BLL;

namespace DiyetTakip_UI.KullaniciIslemleri
{
    public partial class KaloriTakipcisi : Form
    {
        Context _ctx = new Context();
        Yiyecek yiyecek = new Yiyecek();
        Kullanici islemYapanKullanici;
        List<Ogun> ogunler = new OgunManager(new Context()).Listele();
        OgunTakibiBLL _ogunTakibiBLL = new OgunTakibiBLL(new OgunTakibiManager(new Context()));
        YiyecekBLL _yiyecekBLL = new YiyecekBLL(new YiyecekManager(new Context()));
        List<Yiyecek> yiyecekListesi = new YiyecekManager(new Context()).Listele();
        int arananOgunTakipID;

        public KaloriTakipcisi(Kullanici kullanici)
        {
            InitializeComponent();
            cmbYiyecekListesi.DataSource = null;
            cmbYiyecekListesi.DataSource = yiyecekListesi;
            cmbYiyecekListesi.DisplayMember = "Ad";
            cmbYiyecekListesi.ValueMember = "YiyecekID";
            islemYapanKullanici = kullanici;
            cmbOgunler.DataSource = ogunler;
            cmbOgunler.DisplayMember = "Ad";
            cmbOgunler.ValueMember = "OgunId";
            dgvOgunTakipList.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmbYiyecekListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYiyecekListesi.SelectedItem != null)
            {
                Yiyecek seciliYiyecek = (Yiyecek)cmbYiyecekListesi.SelectedItem;
                lblMiktarTuru.Text = seciliYiyecek.MiktarTuru.ToString();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgunTakibi ogunTakibi = new OgunTakibi() { KullaniciID = islemYapanKullanici.KullaniciID, YiyecekID = (int)cmbYiyecekListesi.SelectedValue, Miktar = (int)nudMiktar.Value, OgunID = (int)cmbOgunler.SelectedValue, OlusturmaTarihi = dateTimePicker1.Value };

            _ogunTakibiBLL.Ekle(ogunTakibi);
            Temizle();
            DGVDoldur();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DGVDoldur();
        }
        public void DGVDoldur()
        {
            DateTime pickerDate = dateTimePicker1.Value.Date;

            var filteredList = _ogunTakibiBLL.Listele()
                .Where(x => x.KullaniciID == islemYapanKullanici.KullaniciID &&
                            x.OlusturmaTarihi.Date.Year == pickerDate.Year &&
                            x.OlusturmaTarihi.Date.Month == pickerDate.Month &&
                            x.OlusturmaTarihi.Date.Day == pickerDate.Day)
                .ToList();

            var yiyecekOgunList = filteredList.Join(
              _ctx.Yiyecekler,
               ot => ot.YiyecekID,
               y => y.YiyecekID,
               (ot, y) => new
               {
                   ot.OgunTakibiID,
                   ot.OgunID,
                   YiyecekAdi = y.Ad,
                   Ogun = ot.Ogun,
                   ot.Kullanici,
                   ot.KullaniciID,
                   ot.Miktar,
                   ot.UrunToplamKalori,
                   ot.OlusturmaTarihi,
                   ot.Yiyecek,
                   y.MiktarTuru
               }).Join(_ctx.Ogunler, oty=>oty.OgunID, o=>o.OgunId, (oty,o)=>new {
                   oty.OgunTakibiID,
                   oty.OgunID,
                   OgunAdi=o.Ad,
                   oty.YiyecekAdi,
                   Miktar = $"{oty.Miktar} {oty.MiktarTuru}",
                   oty.UrunToplamKalori,
                   oty.OlusturmaTarihi,
               })
                .OrderBy(x => x.OgunID).
               ToList();

            dgvOgunTakipList.DataSource = null;
            dgvOgunTakipList.DataSource = yiyecekOgunList;

            dgvOgunTakipList.AutoGenerateColumns = true;
            dgvOgunTakipList.Columns["OgunID"].Visible = false;
            //dgvOgunTakipList.Columns["OgunTakibiID"].Visible = false;

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            OgunTakibi silenecekOgunTakip = _ogunTakibiBLL.Ara(arananOgunTakipID);
            _ogunTakibiBLL.Sil(silenecekOgunTakip);
            DGVDoldur();
            Temizle();
            MessageBox.Show("Silindi");
        }
        public void Temizle()
        {
            if (dgvOgunTakipList.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvOgunTakipList.SelectedRows[0].Index;
                dgvOgunTakipList.Rows[selectedIndex].Selected = false;
            }
            cmbOgunler.SelectedItem = null;
            cmbYiyecekListesi.SelectedItem = null;
            lblMiktarTuru.Text = string.Empty;
            dateTimePicker1.Value= DateTime.Now;
            nudMiktar.Value= 0;
            
        }
        private void dgvOgunTakipList_SelectionChanged(object sender, EventArgs e)
        {
            
            if(dgvOgunTakipList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOgunTakipList.CurrentRow;
                arananOgunTakipID = Convert.ToInt32(selectedRow.Cells["OgunTakibiID"].Value);
                OgunTakibi seciliOgunTakip = _ogunTakibiBLL.Ara(arananOgunTakipID);
                cmbOgunler.SelectedValue = seciliOgunTakip.OgunID;
                cmbYiyecekListesi.SelectedValue = seciliOgunTakip.YiyecekID;
                nudMiktar.Value = seciliOgunTakip.Miktar;
                dateTimePicker1.Value = seciliOgunTakip.OlusturmaTarihi;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            KullaniciGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
