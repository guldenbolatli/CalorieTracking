using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class KullaniciYiyecekAlerjiBLL : ICRUD<KullaniciYiyecekAlerji>
    {
        private readonly KullaniciYiyecekAlerjiManager _kullaniciYiyecekAlerji;
        public KullaniciYiyecekAlerjiBLL(KullaniciYiyecekAlerjiManager kullaniciYiyecekAlerji)
        {
            _kullaniciYiyecekAlerji = kullaniciYiyecekAlerji;
        }

        public KullaniciYiyecekAlerji Ara(int id)
        {
            return _kullaniciYiyecekAlerji.Ara(id);
        }

        public void Ekle(KullaniciYiyecekAlerji entity)
        {
            if(VeriVarMı(entity))
            {
                _kullaniciYiyecekAlerji.Ekle(entity);
            }
            else
                throw new Exception("Kullanici alerji verisi eksik.");
        }

        public void Guncelle(KullaniciYiyecekAlerji entity)
        {
            _kullaniciYiyecekAlerji.Guncelle(entity);
        }

        public List<KullaniciYiyecekAlerji> Listele()
        {
            return _kullaniciYiyecekAlerji.Listele();
        }

        public void Sil(KullaniciYiyecekAlerji entity)
        {
            _kullaniciYiyecekAlerji.Sil(entity);
        }

        public bool VeriVarMı(KullaniciYiyecekAlerji entity)
        {
            if (entity.Kullanici !=null && entity.Yiyecek !=null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
