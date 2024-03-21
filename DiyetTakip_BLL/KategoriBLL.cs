using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class KategoriBLL : ICRUD<Kategori>
    {
        private readonly KategoriManager _kategoriManager;
        public KategoriBLL(KategoriManager kategoriManager)
        {
            _kategoriManager = kategoriManager;
        }

        public Kategori Ara(int id)
        {
            return _kategoriManager.Ara(id);
        }

 

        public void Ekle(Kategori entity)
        {
            if(VeriVarMı(entity))
            {
                entity.AktifMİ = true;
                _kategoriManager.Ekle(entity);
            }
            else
                throw new Exception("Kategori Adını boş giremezseniz.");
        }

        public void Guncelle(Kategori entity)
        {
            if (VeriVarMı(entity))
            {
                _kategoriManager.Guncelle(entity);
            }
            else
                throw new Exception("Kategori Adını boş giremezseniz.");
        }

        public List<Kategori> Listele()
        {
            return _kategoriManager.Listele();
        }

        public void Sil(Kategori entity)
        {
           _kategoriManager.Sil(entity);
        }

        public bool VeriVarMı(Kategori entity)
        {
            if (entity.Ad != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
