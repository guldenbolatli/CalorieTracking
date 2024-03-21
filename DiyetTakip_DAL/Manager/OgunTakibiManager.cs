using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public class OgunTakibiManager : ICRUD<OgunTakibi>
    {
        private readonly Context _dbCtx;
        public OgunTakibiManager(Context dbCtx)
        {
            _dbCtx = dbCtx;
        }
    
        public OgunTakibi Ara(int id)
        {
            var arananOgunTakibi=_dbCtx.OgunTakipleri.FirstOrDefault(x=>x.OgunTakibiID==id);
            if(arananOgunTakibi!=null)
            {
                return arananOgunTakibi;
            }
            else
                throw new NotImplementedException("Aranan Öğün Takip Verisi Bulanamadı.");
        }

        public void Ekle(OgunTakibi entity)
        {
            _dbCtx.OgunTakipleri.Add(entity);
            _dbCtx.Entry<OgunTakibi>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbCtx.SaveChanges();
        }

        public void Guncelle(OgunTakibi entity)
        {
            OgunTakibi ogunTakibi = Ara(entity.OgunTakibiID);
            _dbCtx.Entry<OgunTakibi>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ogunTakibi.Miktar=entity.Miktar;
            _dbCtx.SaveChanges();
        }

        public List<OgunTakibi> Listele()
        {
            return _dbCtx.OgunTakipleri.ToList();
        }

        public void Sil(OgunTakibi entity)
        {
            OgunTakibi ogunTakibi = Ara(entity.OgunTakibiID);
            _dbCtx.OgunTakipleri.Remove(entity);
            _dbCtx.Entry<OgunTakibi>(ogunTakibi).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _dbCtx.SaveChanges();
        }
    }
}
