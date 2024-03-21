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
    public partial class AcilisEkrani : Form
    {
        public static List<string> diyetZorlukSeviyeleri = new List<string>() { "Kolay","Orta","Zor"};
        public static List<string> hareketSeviyeleri = new List<string>() { "Hareketsiz","Az Hareketli", "Hareketli", "Cok Hareketli" };
        public static List<string> beslenmeTercihleri = new List<string>() { "Normal","Vegan","Vejetaryen"};
        public static List<string> miktarTuru = new List<string>() { "gram", "miliLitre","adet" };

        public AcilisEkrani()
        {
            InitializeComponent();

            CustomizeButton();
        }
        private void CustomizeButton()
        {

            btnÜyelik.BackgroundImage = Image.FromFile(@"diyet/anagiris.jpg");
           
        }

        private void btnÜyelik_Click(object sender, EventArgs e)
        {
            Point position = new Point(btnÜyelik.Left, btnÜyelik.Bottom + 1);
            position = btnÜyelik.Parent.PointToScreen(position);
            ctxUyeMenu.Show(position);
        }

        private void ctxMenuItemGirisYap_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new ÜyeGirisEkranı());
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

        private void ctxMenuItemUyeOl_Click(object sender, EventArgs e)
        {
            GorunurlukAyarla(this);
            ChildForm(new ÜyeKayitEkrani());
        }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            
        }
    }
}







