using DiyetTakip_DAL;
using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class OgunTakibiBLL : ICRUD<OgunTakibi>
    {
        private readonly OgunTakibiManager _ogunTakibi;
        Context _ctx = new Context();
        public OgunTakibiBLL(OgunTakibiManager ogunTakibi)
        {
            _ogunTakibi = ogunTakibi;
        }

        public OgunTakibi Ara(int id)
        {
            return _ogunTakibi.Ara(id);
        }

        public void Ekle(OgunTakibi entity)
        {
            if (VeriVarMı(entity))
            {
                entity.UrunToplamKalori = ToplamKaloriHesabı(entity);
                _ogunTakibi.Ekle(entity);
            }
            else
                throw new Exception("Öğün Takibi için istenen veriler eksik.");
        }

        public void Guncelle(OgunTakibi entity)
        {
            if (VeriVarMı(entity))
            {
                entity.UrunToplamKalori = ToplamKaloriHesabı(entity);
                _ogunTakibi.Guncelle(entity);
            }
            else
                throw new Exception("Öğün Takibi için istenen veriler eksik.");
        }

        public List<OgunTakibi> Listele()
        {
            return _ogunTakibi.Listele();
        }

        public void Sil(OgunTakibi entity)
        {
            _ogunTakibi.Sil(entity);
        }

        public bool VeriVarMı(OgunTakibi entity)
        {
            if (entity.Miktar != null && entity.KullaniciID != null && entity.OgunID != null && entity.YiyecekID != null && entity.OlusturmaTarihi != DateTime.MinValue)
            {
                return true;
            }
            else
                return false;
        }
        public float ToplamKaloriHesabı(OgunTakibi entity)
        {
            var result = _ctx.OgunTakipleri.Join(_ctx.Yiyecekler, ot => ot.YiyecekID, y => y.YiyecekID, (ot, y) => new { y.Kalori }).Select(x => x.Kalori).FirstOrDefault();
            return entity.Miktar * result;
        }

        #region Raporlar
        public List<string> GunSonuRaporu(Kullanici kullanici,DateTime tarih)
        {
            List<string> list = new List<string>();
            List<OgunTakibi> kullaniciListesi = _ogunTakibi.Listele().Where(x => x.KullaniciID == kullanici.KullaniciID && x.OlusturmaTarihi.Date == tarih.Date).ToList();

            float gunlukToplamKalori = kullaniciListesi.Sum(x => x.UrunToplamKalori);
            string tümVeri = $"Günlük Alınan Toplam Kalori: {gunlukToplamKalori}";
            list.Add(tümVeri);

            int maxOgunID = _ogunTakibi.Listele().Max(x => x.OgunID);
            for (int i = 1; i <= maxOgunID; i++)
            {
                float ogunlukToplamKalori = kullaniciListesi.Where(x => x.OgunID == i).Sum(x => x.UrunToplamKalori);
                string ekle = $"{i}. Ogun - {ogunlukToplamKalori} Kalori";
                if (ogunlukToplamKalori > 0)
                    list.Add(ekle);
            }
            return list; //Listenin 0.Elemanı Toplam Kalori, 1. Elemanı 1.Öğün kalorisi...
        }
        public List<string> GunSonuRaporu(Kullanici kullanici)
        {
            List<string> list = new List<string>();
            List<OgunTakibi> kullaniciListesi = _ogunTakibi.Listele().Where(x => x.KullaniciID == kullanici.KullaniciID && x.OlusturmaTarihi.Date == DateTime.Now.Date).ToList();

            float gunlukToplamKalori = kullaniciListesi.Sum(x => x.UrunToplamKalori);
            string tümVeri = $"Günlük Alınan Toplam Kalori: {gunlukToplamKalori}";
            list.Add(tümVeri);

            int maxOgunID = _ogunTakibi.Listele().Max(x => x.OgunID);
            for (int i = 1; i <= maxOgunID; i++)
            {
                float ogunlukToplamKalori = kullaniciListesi.Where(x => x.OgunID == i).Sum(x => x.UrunToplamKalori);
                string ekle = $"{i}. Ogun - {ogunlukToplamKalori} Kalori";
                if (ogunlukToplamKalori > 0)
                    list.Add(ekle);
            }
            return list; //Listenin 0.Elemanı Toplam Kalori, 1. Elemanı 1.Öğün kalorisi...
        }
        public List<string> OgunBazliKiyasRaporu(string periyot)
        {
            var result = _ctx.OgunTakipleri.Join(_ctx.Ogunler, ot => ot.OgunID, o => o.OgunId, (ot, o) => new
            {
                ot.OgunID,
                o.Ad,
                ot.UrunToplamKalori,
                ot.OlusturmaTarihi
            }).ToList();

            List<string> list = new List<string>();
            var ogunBazliList = result;

            switch (periyot)
            {
                case "haftalik":
                    ogunBazliList = ogunBazliList.Where(x => x.OlusturmaTarihi >= DateTime.Now.AddDays(-7)).ToList();
                    break;
                case "aylik":
                    ogunBazliList = ogunBazliList.Where(x => x.OlusturmaTarihi >= DateTime.Now.AddDays(-30)).ToList();
                    break;
            }

            int maxOgunID = ogunBazliList.Max(x => x.OgunID);

            for (int i = 1; i <= maxOgunID; i++)
            {
                string ad = ogunBazliList.FirstOrDefault(x => x.OgunID == i)?.Ad;
                float ogunlukToplamKalori = ogunBazliList.Where(x => x.OgunID == i).Sum(x => x.UrunToplamKalori);

                if (ogunlukToplamKalori > 0 && !string.IsNullOrEmpty(ad))
                {
                    string list1 = $"{ad}.Ogun {ogunlukToplamKalori} Kalori";
                    list.Add(list1);
                }
            }

            return list;

        }
        public List<string> KategoriBazliKiyasRaporu(string periyot)
        {
            var result = _ctx.OgunTakipleri.Join(_ctx.Yiyecekler, ot => ot.YiyecekID, y => y.YiyecekID, (ot, y) => new
            {
                ot.YiyecekID,
                ot.Miktar,
                ot.UrunToplamKalori,
                ot.OlusturmaTarihi,
                y.KategoriID
            }).Join(_ctx.Kategoriler, oty => oty.KategoriID, k => k.KategoriID, (oty, k) => new
            {
                oty.KategoriID,
                oty.Miktar,
                oty.UrunToplamKalori,
                oty.OlusturmaTarihi,
                k.Ad
            }).ToList();
            List<string> list = new List<string>();
            var kategoriBazliList = result;
            switch (periyot)
            {
                case "haftalik":
                    kategoriBazliList = kategoriBazliList.Where(x => x.OlusturmaTarihi >= DateTime.Now.AddDays(-7)).ToList();
                    break;
                case "aylik":
                    kategoriBazliList = kategoriBazliList.Where(x => x.OlusturmaTarihi >= DateTime.Now.AddDays(-30)).ToList();
                    break;
            }
            
            int maxKategoriID = kategoriBazliList.Max(x => x.KategoriID);
            for (int i = 1; i <= maxKategoriID; i++)
            {
                float ogunlukToplamKalori = kategoriBazliList.Where(x => x.KategoriID == i).Sum(x => x.UrunToplamKalori);

                string ad = kategoriBazliList.FirstOrDefault(x => x.KategoriID == i)?.Ad;
                string veriler = $"{ad}. Kategori Toplam Kalorisi: {ogunlukToplamKalori}";
                if (ogunlukToplamKalori > 0)
                    list.Add(veriler);
            }
            return list;
        }
        public List<string> YemekCesidiRaporu()
        {
            var result = _ctx.OgunTakipleri.Join(_ctx.Yiyecekler, ot => ot.YiyecekID, y => y.YiyecekID, (ot, y) => new
            {
                ot.YiyecekID,
                ot.Miktar,
                ot.UrunToplamKalori,
                ot.OlusturmaTarihi,
                ot.OgunID,
                y.Ad

            }).Join(_ctx.Ogunler, oty => oty.OgunID, o => o.OgunId, (oty, o) => new
            {
                YiyecekAdi=oty.Ad,
                YiyecekMiktar=oty.Miktar,
                OgunAdi=o.Ad,
                o.OgunId,
                oty.YiyecekID
            });
            List<string> list = new List<string>();
            var yemekListesi = result;
            int maxOgunID = yemekListesi.Max(x => x.OgunId), maxYiyecekID = yemekListesi.Max(x => x.YiyecekID);
            for (int i = 1; i <= maxOgunID; i++)
            {
                for (int j = 1; j <= maxYiyecekID; j++)
                {
                    int toplamMiktar = yemekListesi.Where(x => x.OgunId == i && x.YiyecekID == j).Count();
                    //string miktarBilgisi = yiyecek.MiktarTuru;
                    string ogunAdi = yemekListesi.FirstOrDefault(x => x.OgunId == i)?.OgunAdi;
                    string yiyecekAdi=yemekListesi.FirstOrDefault(x=>x.YiyecekID==j)?.YiyecekAdi;
                    string rapor = ($"{ogunAdi} Öğününde, {yiyecekAdi} Yiyeceğinin Toplam Seçim Adedi: {toplamMiktar}");
                    if (toplamMiktar > 0)
                        list.Add(rapor);
                }
            }
            return list;

        }

        #endregion

    }
}
