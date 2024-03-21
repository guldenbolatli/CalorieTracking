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

namespace DiyetTakip_UI.AdminGirisi
{
    public partial class KullaniciOzellikCRUD : Form
    {
       
        
    
        public KullaniciOzellikCRUD()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminGiris.GorunurlukAyarla(this.MdiParent);
            this.MdiParent.Show();
        }
    }
}
