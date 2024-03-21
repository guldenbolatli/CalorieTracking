using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class TarifBLL : ICRUD<Tarif>
    {
        private readonly TarifManager _tarifManager;
        public TarifBLL(TarifManager tarifManager)
        {
            _tarifManager = tarifManager;
        }

        public Tarif Ara(int id)
        {
            return _tarifManager.Ara(id);
        }

        public void Ekle(Tarif entity)
        {
            if (VeriVarMı(entity))
            {
                entity.AktifMİ = true;
                _tarifManager.Ekle(entity);
            }
            else
                throw new Exception("Hazırlanma süresini boş giremezseniz.");
        }

        public void Guncelle(Tarif entity)
        {
            if (VeriVarMı(entity))
            {
                entity.AktifMİ = true;
                _tarifManager.Ekle(entity);
            }
            else
                throw new Exception("Hazırlanma süresini boş giremezseniz.");
        }

        public List<Tarif> Listele()
        {
            return _tarifManager.Listele(); 
        }

        public void Sil(Tarif entity)
        {
            _tarifManager.Sil(entity);
        }

        public bool VeriVarMı(Tarif entity)
        {
            if (entity.HazirlamaSuresi != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
