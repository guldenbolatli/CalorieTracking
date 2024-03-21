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
    public partial class TarifCRUD : Form
    {
        
        TarifBLL _tarifBLL = new TarifBLL(new TarifManager(new Context()));
        Tarif tarif;
        public TarifCRUD()
        {
            InitializeComponent();
            txtTarifID.Enabled = false;
            dgvTarifList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnAra.Visible = false;


            List<Yiyecek> yiyecekListesi = new YiyecekManager(new Context()).Listele().Where(x => x.Tarif == null).ToList();
            cmbYiyecekListesi.DataSource = null;
            cmbYiyecekListesi.DataSource = null;
            cmbYiyecekListesi.DataSource = yiyecekListesi;
            cmbYiyecekListesi.DisplayMember = "Ad";
            cmbYiyecekListesi.ValueMember = "YiyecekID";

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int hazirlanmaSuresi;
            string yiyecekAdi = cmbYiyecekListesi.SelectedValue.ToString();
            //txtYiyecekID.Text = 
            if (int.TryParse(txtHazirlanmaSuresi.Text, out hazirlanmaSuresi))
            {
                tarif = new Tarif()
                {
                    TarifDetayi = txtTarifDetayi.Text,
                    HazirlamaSuresi = hazirlanmaSuresi,
                    YiyecekID = (int)cmbYiyecekListesi.SelectedValue,
                  
                    
                };
             
                _tarifBLL.Ekle(tarif);
                MessageBox.Show("Tarif Başarıyla Eklendi.");
                Temizle();
                DataGridViewDoldur();
                chkSecimiKaldir.Checked = false;


            }
        }

        private void DataGridViewDoldur()
        {
            dgvTarifList.DataSource = null;
            dgvTarifList.DataSource = _tarifBLL.Listele();
        }

        private void Temizle()
        {
            if (dgvTarifList.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTarifList.SelectedRows[0].Index;
                dgvTarifList.Rows[selectedIndex].Selected = false;
            }
            txtTarifID.Text = txtTarifDetayi.Text  = txtHazirlanmaSuresi.Text  = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Tarif silenecektarif = _tarifBLL.Ara(int.Parse(txtTarifID.Text));
            //_tarifBLL.Sil(silenecektarif);
            //DataGridViewDoldur();
            //Temizle();
            //MessageBox.Show(silenecektarif.TarifDetayi + " Adli Tarif Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Tarif guncellenecekTarif = _tarifBLL.Ara(int.Parse(txtTarifID.Text));
            guncellenecekTarif.TarifDetayi = txtTarifDetayi.Text;
            guncellenecekTarif.HazirlamaSuresi = int.Parse(txtHazirlanmaSuresi.Text);
            _tarifBLL.Guncelle(guncellenecekTarif);
            DataGridViewDoldur();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //Tarif bulunantarif = _tarifBLL.Listele()
            //                .FirstOrDefault(x => x.Yiyecek.Ad.Equals(txtYiyecekAdi.Text));

            //if (bulunantarif != null)
            //{
            //    txtTarifDetayi.Text = bulunantarif.TarifDetayi;
            //    txtTarifID.Text = bulunantarif.TarifID.ToString();
            //    txtHazirlanmaSuresi.Text = bulunantarif.HazirlamaSuresi.ToString();
            //    dgvTarifList.DataSource = new List<Tarif> { bulunantarif };
            //}
            //else
            //{
            //    dgvTarifList.DataSource = null;
            //}
        }

        private void chkSecimiKaldir_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataGridViewDoldur();
            Temizle();
        }

        private void dgvTarifList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTarifList.CurrentRow != null)//düzelt
            {
                DataGridViewRow selectedRow = dgvTarifList.CurrentRow;
                int tarifID = Convert.ToInt32(selectedRow.Cells["TarifID"].Value);
                string tarifDetayi = Convert.ToString(selectedRow.Cells["TarifDetayi"].Value);
                string hazirlanmaSuresi = Convert.ToString(selectedRow.Cells["HazirlamaSuresi"].Value);
                txtTarifID.Text = tarifID.ToString();
                txtTarifDetayi.Text = tarifDetayi;
                txtHazirlanmaSuresi.Text = hazirlanmaSuresi;
               // cmbYiyecekListesi.SelectedValue= Convert.ToString(selectedRow.Cells["YiyecekID"].Value);
               //comboBox'da düzelt
          
   

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
