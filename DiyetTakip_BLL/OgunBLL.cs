using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class OgunBLL : ICRUD<Ogun>
    {
        
        private readonly OgunManager _ogunManager;
        public OgunBLL(OgunManager ogunManager)
        {
            _ogunManager = ogunManager;
        }

        public Ogun Ara(int id)
        {
            return _ogunManager.Ara(id);
        }

        public void Ekle(Ogun entity)
        {
            if (VeriVarMı(entity))
            {
                entity.AktifMİ = true;
                _ogunManager.Ekle(entity);
            }
            else
                throw new Exception("Öğün Adını boş giremezseniz.");
        }

        public void Guncelle(Ogun entity)
        {
            if (VeriVarMı(entity))
            {
                entity.AktifMİ = true;
                _ogunManager.Guncelle(entity);
            }
            else
                throw new Exception("Öğün Adını boş giremezseniz.");
        }

        public List<Ogun> Listele()
        {
            return _ogunManager.Listele();
        }

        public void Sil(Ogun entity)
        {
            _ogunManager.Sil(entity);
        }

        public bool VeriVarMı(Ogun entity)
        {
            if(entity.Ad != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
