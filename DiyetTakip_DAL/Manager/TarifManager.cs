using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public class TarifManager : ICRUD<Tarif>
    {
        private readonly Context _dbCtx;
        public TarifManager(Context dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public Tarif Ara(int id)
        {
            var arananTarif = _dbCtx.Tarifler.FirstOrDefault(x => x.TarifID.Equals(id) && x.AktifMİ == true);
            if (arananTarif != null)
            {
                return arananTarif;
            }
            else
                throw new NotImplementedException("Aranan Tarif Bulunamadı.");
        }

        public void Ekle(Tarif entity)
        {
            _dbCtx.Tarifler.Add(entity);
            _dbCtx.Entry<Tarif>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbCtx.SaveChanges();
        }

        public void Guncelle(Tarif entity)
        {
            Tarif tarif = Ara(entity.TarifID);
            _dbCtx.Entry<Tarif>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            tarif.TarifDetayi=entity.TarifDetayi;
            tarif.HazirlamaSuresi=entity.HazirlamaSuresi;
            _dbCtx.SaveChanges();
        }

        public List<Tarif> Listele()
        {
            return _dbCtx.Tarifler.Where(x=>x.AktifMİ==true).ToList();

        }

        public void Sil(Tarif entity)
        {
            Tarif tarif = Ara(entity.TarifID);
            tarif.AktifMİ = false;
            _dbCtx.SaveChanges();
        }
    }
}
