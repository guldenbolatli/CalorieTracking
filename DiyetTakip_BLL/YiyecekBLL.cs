using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class YiyecekBLL : ICRUD<Yiyecek>
    {
        private readonly YiyecekManager _yiyecekManager;
        public YiyecekBLL(YiyecekManager yiyecekManager)
        {
            _yiyecekManager= yiyecekManager;
        }
        public Yiyecek Ara(int id)
        {
            return _yiyecekManager.Ara(id);
        }

        public void Ekle(Yiyecek entity)
        {
            if (VeriVarMı(entity))
            {
                if (entity.ProteinMiktari < 0)
                {
                    throw new Exception("Protein miktarı doğal sayı olmalıdır..");
                }
                if(entity.YagMiktari<0) 
                {
                    throw new Exception("Yağ miktarı doğal sayı olmalıdır.");
                }
                if(entity.KarbonhidratMiktari< 0)
                {
                    throw new Exception("Karbonhidrat miktarı doğal sayı olmalıdır.");
                }
                if (entity.Kalori < 0)
                {
                    throw new Exception("Kalori doğal sayı olmalıdır.");
                }
                else
                {
                    entity.AktifMİ = true;
                    _yiyecekManager.Ekle(entity);
                }
            }
            else
                throw new Exception("Ad veya Miktar Türünü boş giremezseniz.");
        }

        public void Guncelle(Yiyecek entity)
        {
            if (VeriVarMı(entity))
            {
                if (entity.ProteinMiktari < 0)
                {
                    throw new Exception("Protein miktarı doğal sayı olmalıdır..");
                }
                if (entity.YagMiktari < 0)
                {
                    throw new Exception("Yağ miktarı doğal sayı olmalıdır.");
                }
                if (entity.KarbonhidratMiktari < 0)
                {
                    throw new Exception("Karbonhidrat miktarı doğal sayı olmalıdır.");
                }
                if (entity.Kalori < 0)
                {
                    throw new Exception("Kalori doğal sayı olmalıdır.");
                }
                else
                {
                    _yiyecekManager.Guncelle(entity);
                }
            }
            else
                throw new Exception("İstenen Verileri boş giremezseniz.");
        }

        public List<Yiyecek> Listele()
        {
            return _yiyecekManager.Listele();
        }

        public void Sil(Yiyecek entity)
        {
            _yiyecekManager.Sil(entity);
        }

        public bool VeriVarMı(Yiyecek entity)
        {
            if (!string.IsNullOrEmpty(entity.Ad) && !string.IsNullOrEmpty(entity.MiktarTuru) && entity.KategoriID != null) 
            {
                return true;
            }
            else
                return false;
        }
    }
}
