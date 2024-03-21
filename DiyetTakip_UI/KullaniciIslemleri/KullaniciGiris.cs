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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DiyetTakip_UI.KullaniciIslemleri
{
    public partial class KullaniciGiris : Form
    {
        KullaniciBLL _kullaniciBLL = new KullaniciBLL(new KullaniciManager(new Context()));
        Kullanici girisYapanKullanici;
       
        public KullaniciGiris(string email)
        {
            InitializeComponent();
            int girisYapanKullaniciID = _kullaniciBLL.Listele()
                   .Where(x => x.Email == email)
                   .Select(x => x.KullaniciID)
                   .FirstOrDefault();
            girisYapanKullanici = _kullaniciBLL.Ara(girisYapanKullaniciID);
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


        private void kullaniciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new KullaniciBilgileri(girisYapanKullanici));
        }

        private void ozetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new Ozet(girisYapanKullanici));
        }

        private void kaloriTakipçisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new KaloriTakipcisi(girisYapanKullanici));
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new Raporlar(girisYapanKullanici));
        }

        private void kaçKaloriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new KacKalori());
        }

        
    }
}
