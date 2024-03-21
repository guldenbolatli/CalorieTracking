using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public class KullaniciYiyecekAlerjiManager : ICRUD<KullaniciYiyecekAlerji>
    {
        private readonly Context _dbCtx;
        public KullaniciYiyecekAlerjiManager(Context dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public KullaniciYiyecekAlerji Ara(int id)
        {
            var arananKullaniciYiyecekAlerji= _dbCtx.KullaniciYiyecekAlerjiler.FirstOrDefault(x => x.KullaniciYiyecekAlerjiID.Equals(id));
            if(arananKullaniciYiyecekAlerji!=null)
            {
                return arananKullaniciYiyecekAlerji;
            }
            else
                throw new NotImplementedException("Aranan Alerji Bulunamadı.");
        }

        public void Ekle(KullaniciYiyecekAlerji entity)
        {
            _dbCtx.KullaniciYiyecekAlerjiler.Add(entity);
            _dbCtx.Entry<KullaniciYiyecekAlerji>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbCtx.SaveChanges();
        }

        public void Guncelle(KullaniciYiyecekAlerji entity)
        {
            throw new NotImplementedException("Bu tabloda Güncellebilecek bir veri yoktur.");
        }

        public List<KullaniciYiyecekAlerji> Listele()
        {
            return _dbCtx.KullaniciYiyecekAlerjiler.ToList();
        }

        public void Sil(KullaniciYiyecekAlerji entity)
        {
            KullaniciYiyecekAlerji kullaniciYiyecekAlerji = Ara(entity.KullaniciYiyecekAlerjiID);
            _dbCtx.KullaniciYiyecekAlerjiler.Remove(entity);
            _dbCtx.Entry<KullaniciYiyecekAlerji>(kullaniciYiyecekAlerji).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _dbCtx.SaveChanges();
        }
    }
}
