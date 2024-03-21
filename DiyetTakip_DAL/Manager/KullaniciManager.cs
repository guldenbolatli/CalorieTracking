using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public class KullaniciManager : ICRUD<Kullanici>
    {
        private readonly Context _dbCtx;
        public KullaniciManager(Context dbCtx)
        {
            _dbCtx = dbCtx;
        }
        public Kullanici Ara(int id)
        {
            var arananKullanici= _dbCtx.Kullanicilar.FirstOrDefault(x => x.KullaniciID.Equals(id));
            if(arananKullanici!=null)
            {
                return arananKullanici;
            }
            else
                throw new NotImplementedException("Aranan Kullanıcı Bulunamadı.");
        }
        public void Ekle(Kullanici entity)
        {
            _dbCtx.Kullanicilar.Add(entity);
            _dbCtx.Entry<Kullanici>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbCtx.SaveChanges();
        }
        public void Guncelle(Kullanici entity)
        {
            Kullanici kullanici = Ara(entity.KullaniciID);
            _dbCtx.Entry<Kullanici>(kullanici).State = Microsoft.EntityFrameworkCore.EntityState.Modified;//Ekleme Hızını arttırır
            kullanici.Ad = entity.Ad;
            kullanici.Soyad = entity.Soyad;
            kullanici.Boy = entity.Boy;
            kullanici.Kilo = entity.Kilo;
            kullanici.BeslenmeTercihi = entity.BeslenmeTercihi;
            kullanici.DogumTarihi = entity.DogumTarihi;
            kullanici.DiyetZorlukSeviyesi = entity.DiyetZorlukSeviyesi;
            kullanici.HareketSeviyesi=entity.HareketSeviyesi;
            kullanici.Email = entity.Email;
            kullanici.Sifre = entity.Sifre;
            kullanici.Cinsiyet = entity.Cinsiyet;
            kullanici.BazalMetobalizma = entity.BazalMetobalizma;
            kullanici.GunlukKaloriIhtiyaci = entity.GunlukKaloriIhtiyaci;
            kullanici.VucutKitleEndeksi = entity.VucutKitleEndeksi;
            _dbCtx.SaveChanges();
        }

        public List<Kullanici> Listele()
        {
            return _dbCtx.Kullanicilar.ToList();
        }

        public void Sil(Kullanici entity)
        {
            Kullanici kullanici = Ara(entity.KullaniciID);
            _dbCtx.Remove(kullanici);
            _dbCtx.Entry<Kullanici>(kullanici).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _dbCtx.SaveChanges();
        }
    }
}
