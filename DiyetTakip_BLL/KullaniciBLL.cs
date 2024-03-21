using DiyetTakip_DAL.Manager;
using DiyetTakip_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_BLL
{
    public class KullaniciBLL : ICRUD<Kullanici>
    {
        private readonly KullaniciManager _kullaniciManager;
        float bazalMetabolizmaKatsayisi;
        public KullaniciBLL(KullaniciManager kullaniciManager)
        {
            _kullaniciManager = kullaniciManager;
        }

        public Kullanici Ara(int id)
        {
            return _kullaniciManager.Ara(id);
        }

        public void Ekle(Kullanici entity)
        {
            if (VeriVarMı(entity))
            {
                if (entity.Boy > 251 || entity.Boy <= 0)
                {
                    throw new Exception("Boy değeri 251 ile 0 arasında olmalıdır.");
                }

                if (entity.Kilo > 500 || entity.Kilo <= 0)
                {
                    throw new Exception("Kilo değeri 300 ile 0 arasında olmalıdır.");
                }
                if (entity.DogumTarihi >= DateTime.Now)
                {
                    throw new Exception("Doğum tarihi bugünki tarihten büyük olamaz.");
                }
                entity.VucutKitleEndeksi = VucutKitleEndeksiHesaplama(entity);
                entity.BazalMetobalizma = BazalMetabolizmaHesaplama(entity);
                entity.GunlukKaloriIhtiyaci = HarcanmasiGerekenGunlukKalori(entity);
                _kullaniciManager.Ekle(entity);
            }
            else
                throw new Exception("Belirtilen özelliklerin hiçbiri boş olamaz.");
        }

        public void Guncelle(Kullanici entity)
        {
            if (VeriVarMı(entity))
            {
                if (entity.Boy > 251)
                {
                    throw new Exception("Boy en fazla 251 cm olabilir.");
                }
                if (entity.Kilo > 500)
                {
                    throw new Exception("Kilo en fazla 500 kg olabilir.");
                }
                _kullaniciManager.Guncelle(entity);
            }
            else
                throw new Exception("Belirtilen özelliklerin hiçbiri boş olamaz.");
        }

        public List<Kullanici> Listele()
        {
            return _kullaniciManager.Listele();
        }

        public void Sil(Kullanici entity)
        {
            _kullaniciManager.Sil(entity);
        }

        public bool VeriVarMı(Kullanici entity)
        {

            if (entity.Ad != null && entity.Email != null && entity.Cinsiyet != null && entity.HareketSeviyesi != null && entity.Sifre != null && entity.Soyad != null && entity.DiyetZorlukSeviyesi != null && entity.DogumTarihi != DateTime.MinValue)
            {
                return true;
            }
            else
                return false;
        }

        public float VucutKitleEndeksiHesaplama(Kullanici _entity) //kişinin zayıflamak ya da kilo alma durumları için gerekecek.
        {
            float boyMetre = _entity.Boy / 100f;
            float vki = _entity.Kilo / (boyMetre * boyMetre);
            return vki;
        }

        public float BazalMetabolizmaHesaplama(Kullanici _entity) //Kişinin günlük alması gereken toplam kalori miktarı hesaplanırken bu metot kullanılacak.

        //Masa başı ve durağan bir yaşamınız varsa, BMH’nızı 1.2 ile çarpın.Hafif düzeyde hareketliyseniz, BMH’nızı 1.3 ile çarpın.Orta düzeyde hareketli olup çok oturmuyorsanız, BMH’nızı 1.4 ile çarpın.Yüksek düzeyde aktifseniz ve düzenli spor yapıyorsanız, BMH’ınızı 1.5 ile çarpın.
        {
            int yas = (DateTime.Now.Year - _entity.DogumTarihi.Year);
            if (_entity.Cinsiyet)//kadınsa
            {
                return (655.1f) + (9.56f * _entity.Kilo) + (1.85f * _entity.Boy) - (4.67f * yas);
            }
            else //erkekse
            {
                return (66.5f) + (13.75f * _entity.Kilo) + (5 * _entity.Boy) - (6.77f * yas);
            }
        }

        public float HarcanmasiGerekenGunlukKalori(Kullanici _entity)
        {

            switch (_entity.HareketSeviyesi.Replace(" ", "").ToLower())
            {
                case "hareketsiz":

                    bazalMetabolizmaKatsayisi = 1.2f;

                    break;

                case "azhareketli":

                    bazalMetabolizmaKatsayisi = 1.3f;

                    break;

                case "hareketli":

                    bazalMetabolizmaKatsayisi = 1.4f;

                    break;

                case "cokhareketli":

                    bazalMetabolizmaKatsayisi = 1.5f;

                    break;
            }
            return BazalMetabolizmaHesaplama(_entity) * bazalMetabolizmaKatsayisi;
        }
        public void EmailKodGonder(string email, string onayKodu, string isim)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string username = "kd16.diyettakip@gmail.com";
            string password = "ejuwevsyliapbntm";

            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(username, password);
                smtpClient.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("diyetTakip@gmail.com");
                mail.To.Add(new MailAddress(email));
                mail.Subject = "Doğrulama Kodu";
                mail.IsBodyHtml = true;


                string body = $@"
    <div style='border: 1px solid #ccc; padding: 10px; width: 300px; margin: 0 auto;'>
        <p>Merhaba {isim},</p>
        <p>DiyetTakip uygulamasına hoş geldin! Aramıza katılmak istemen bizi çok mutlu etti. Umarım uygulamamızdan verim alır ve istediğin kiloya ulaşırsın.</p>
        <p>İşte doğrulama kodun:</p>
        <h1 style='text-align: center; font-size: 24px;'>{onayKodu}</h1>
        <p>Başarılar dileriz!</p>
        <p>DiyetTakip Ekibi</p>
    </div>";
                mail.Body = body;
                mail.IsBodyHtml = true;

                smtpClient.Send(mail);
            }
        }
        public bool EmailKontrol(string email)
        {
            List<string> emailller = _kullaniciManager.Listele().Select(x => x.Email).ToList();
            bool emailVarMi = emailller.Any(x => x.Equals(email, StringComparison.OrdinalIgnoreCase));
            return !emailVarMi;

        }
        public string RastgeleKodUret()
        {
            Random random = new Random();
            string onayKodu = "";

            for (int i = 0; i < 6; i++)
            {
                onayKodu += random.Next(0, 10).ToString();
            }

            return onayKodu;
        }
        public bool SifreZorlukKontrol(string sifre)
        {
            if (sifre.Length < 8)
            {
                return false;
            }

            bool buyukKarakterVarMi = false;
            bool kucukKarakterVarMi = false;
            bool sayisalKarakterVarMi = false;

            foreach (char c in sifre)
            {
                if (char.IsUpper(c))
                {
                    buyukKarakterVarMi = true;
                }
                else if (char.IsLower(c))
                {
                    kucukKarakterVarMi = true;
                }
                else if (char.IsDigit(c))
                {
                    sayisalKarakterVarMi = true;
                }
            }

            if (!buyukKarakterVarMi || !kucukKarakterVarMi || !sayisalKarakterVarMi)
            {
                return false;
            }

            return true;
        }
        public string KullaniciAdminKontrol(string email, string _sifre)
        {
            List<string> emailller = _kullaniciManager.Listele().Select(x => x.Email).ToList();
            bool emailVarMi = emailller.Any(x => x.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (emailVarMi)
            {
                string sifre = _kullaniciManager.Listele().Where(x => x.Email == email).Select(x => x.Sifre).FirstOrDefault();

                if (sifre != null && sifre == _sifre)
                {
                    if (email.StartsWith("admin"))
                    {
                        return "admin";
                    }
                    else
                    {
                        return "kullanici";
                    }
                }
                else
                {
                    return "HataliGiris";
                }
            }
            else
            {
                return "HataliGiris";
            }
        }
    }
}

