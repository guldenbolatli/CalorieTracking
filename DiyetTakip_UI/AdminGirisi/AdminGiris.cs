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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new KategoriCRUD());
        }
        void ChildForm(Form childForm)
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }
        public static void GorunurlukAyarla(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is GroupBox && item.Visible == true)
                {
                    ((GroupBox)item).Visible = false;
                }
                else if (item is GroupBox && item.Visible == false)
                {
                    ((GroupBox)item).Visible = true;
                }
            }
        }

      

        private void yiyecekEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new YiyecekCRUD());
        }

        private void tarifEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new TarifCRUD());
        }

        private void kullanıcıÖzellikleriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new KullaniciOzellikCRUD());
        }

        private void ögünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new OgunCRUD());
        }

        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new KategoriCRUD());
        }

        private void btnTarifDuzenle_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new TarifCRUD());
        }

       

        private void btnOgunDuzenle_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new OgunCRUD());
        }

        private void btnYıyecekDuzenle_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new YiyecekCRUD());
        }

        private void btnKullaniciVeriDuzenle_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new KullaniciOzellikCRUD());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
