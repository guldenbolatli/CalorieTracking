using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public class OgunManager : ICRUD<Ogun>
    {
        private readonly Context _dbCtx;
        public OgunManager(Context dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public Ogun Ara(int id)
        {
           var arananOgun= _dbCtx.Ogunler.FirstOrDefault(x=>x.OgunId.Equals(id) && x.AktifMİ==true);
            if(arananOgun!=null)
            {
                return arananOgun;
            }
            else
                throw new NotImplementedException("Aranan Öğün Bulunamadı.");
        }

        public void Ekle(Ogun entity)
        {
            _dbCtx.Ogunler.Add(entity);
            _dbCtx.Entry<Ogun>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbCtx.SaveChanges();
        }

        public void Guncelle(Ogun entity)
        {
            Ogun ogun = Ara(entity.OgunId);
            _dbCtx.Entry<Ogun>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ogun.Ad = entity.Ad;
            _dbCtx.SaveChanges();
        }

        public List<Ogun> Listele()
        {
            return _dbCtx.Ogunler.Where(x=>x.AktifMİ==true).ToList();
        }

        public void Sil(Ogun entity)
        {
            Ogun ogun=Ara(entity.OgunId);
            ogun.AktifMİ = false;
            _dbCtx.SaveChanges();
        }
    }
}
