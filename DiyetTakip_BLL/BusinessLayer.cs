using DiyetTakip_DAL;
using DiyetTakip_DAL.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class BusinessLayer
    {
        public static Context _dalCtx;
        public BusinessLayer()
        {
            _dalCtx= new Context();
            Kategoriler=new KategoriBLL(new KategoriManager(_dalCtx));
            Kullanicilar=new KullaniciBLL(new KullaniciManager(_dalCtx));
            KullaniciYiyecekAlerjiler=new KullaniciYiyecekAlerjiBLL(new KullaniciYiyecekAlerjiManager(_dalCtx));
            Ogunler=new OgunBLL(new OgunManager(_dalCtx));
            OgunTakipleri=new OgunTakibiBLL(new OgunTakibiManager(_dalCtx));
            Tarifler=new TarifBLL(new TarifManager(_dalCtx));
            Yiyecekler=new YiyecekBLL(new YiyecekManager(_dalCtx));

        }
        public KategoriBLL Kategoriler { get; set; }
        public KullaniciBLL Kullanicilar { get; set; }
        public KullaniciYiyecekAlerjiBLL KullaniciYiyecekAlerjiler { get; set; }
        public OgunBLL Ogunler { get; set; }
        public OgunTakibiBLL OgunTakipleri { get; set; }
        public TarifBLL Tarifler { get; set; }
        public YiyecekBLL Yiyecekler { get; set; }
    }
}
