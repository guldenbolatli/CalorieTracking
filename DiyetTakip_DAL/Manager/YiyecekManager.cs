using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public class YiyecekManager : ICRUD<Yiyecek>
    {
        private readonly Context _dbCtx;
        public YiyecekManager(Context dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public Yiyecek Ara(int id)
        {
            var arananYiyecek=_dbCtx.Yiyecekler.FirstOrDefault(x=>x.YiyecekID.Equals(id) && x.AktifMİ==true);
            if(arananYiyecek!=null)
            {
                return arananYiyecek;
            }
            else
                throw new NotImplementedException("Aranan Yiyecek Bulanamadı.");
        }

        public void Ekle(Yiyecek entity)
        {
            _dbCtx.Yiyecekler.Add(entity);
            _dbCtx.Entry<Yiyecek>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbCtx.SaveChanges();
        }

        public void Guncelle(Yiyecek entity)
        {
            Yiyecek yiyecek=Ara(entity.YiyecekID);
            _dbCtx.Entry<Yiyecek>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            yiyecek.Ad=entity.Ad;
            yiyecek.ProteinMiktari=entity.ProteinMiktari;
            yiyecek.YagMiktari=entity.YagMiktari;
            yiyecek.KarbonhidratMiktari = entity.KarbonhidratMiktari;
            yiyecek.Fotograf=entity.Fotograf;
            yiyecek.Kalori = entity.Kalori;
            yiyecek.MiktarTuru=entity.MiktarTuru;
            _dbCtx.SaveChanges();
        }

        public List<Yiyecek> Listele()
        {
            return _dbCtx.Yiyecekler.Where(x => x.AktifMİ == true).ToList();
        }

        public void Sil(Yiyecek entity)
        {
            Yiyecek yiyecek = Ara(entity.YiyecekID);
            yiyecek.AktifMİ = false;
            _dbCtx.SaveChanges();
        }
    }
}
