using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public class KategoriManager : ICRUD<Kategori>
    {

        private readonly Context _dbCtx;
        public KategoriManager(Context dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public Kategori Ara(int id)
        {
            var arananKategori= _dbCtx.Kategoriler.FirstOrDefault(x => x.KategoriID.Equals(id) && x.AktifMİ == true);
            if(arananKategori != null ) 
            {
                return arananKategori;
               
            }
            else
                throw new NotImplementedException("Aranan Kategori Bulanamadı.");
        }

        public void Ekle(Kategori entity)
        {
            _dbCtx.Kategoriler.Add(entity);
            _dbCtx.Entry<Kategori>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbCtx.SaveChanges();
        }

        public void Guncelle(Kategori entity)
        {
            Kategori kategori=Ara(entity.KategoriID);
            _dbCtx.Entry<Kategori>(kategori).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            kategori.Ad=entity.Ad;
            kategori.Fotograf = entity.Fotograf;
            _dbCtx.SaveChanges();
        }

        public List<Kategori> Listele()
        {

            return _dbCtx.Kategoriler.Where(x=>x.AktifMİ==true).ToList();
        }

        public void Sil(Kategori entity)
        {
            Kategori kategori = Ara(entity.KategoriID);
            kategori.AktifMİ = false;
            _dbCtx.SaveChanges();
        }
    }
}
