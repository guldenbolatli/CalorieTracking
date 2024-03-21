using DiyetTakip_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Configurations
{
    public class KullaniciCFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.Property(x => x.Ad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.Soyad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Ignore(x => x.AdSoyad);
            builder.Property(x => x.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(254);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Sifre).IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            builder.Property(x => x.Boy).IsRequired().HasColumnType("int");
            builder.Property(x => x.Kilo).IsRequired().HasColumnType("float");
            builder.Property(x => x.BeslenmeTercihi).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.DogumTarihi).HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.BazalMetobalizma).HasColumnType("float");
            builder.Property(x => x.VucutKitleEndeksi).HasColumnType("float");
            builder.Property(x => x.GunlukKaloriIhtiyaci).HasColumnType("float");
            



            //Veri Ekleme Kısmı
            builder.HasData(
                new Kullanici { KullaniciID = 1, Ad = "admin", Soyad = "1", Email = "admin1", Sifre = "123", AdminMi = true, Boy=1,Cinsiyet=true,DogumTarihi=new DateTime(1998,2,2), BeslenmeTercihi="", DiyetZorlukSeviyesi="", HareketSeviyesi="", Kilo=0, VucutKitleEndeksi=0, BazalMetobalizma=0, GunlukKaloriIhtiyaci=0  },
                new Kullanici { KullaniciID = 2, Ad = "admin", Soyad = "2", Email = "admin2", Sifre = "123", AdminMi = true, Boy = 1, Cinsiyet = true, BeslenmeTercihi = "", DiyetZorlukSeviyesi = "", HareketSeviyesi = "",  Kilo = 0, VucutKitleEndeksi = 0, BazalMetobalizma = 0, GunlukKaloriIhtiyaci =0, DogumTarihi = new DateTime(1998, 2, 2) },
                new Kullanici { KullaniciID = 3, Ad = "admin", Soyad = "3", Email = "admin3", Sifre = "123", AdminMi = true, Boy = 1, Cinsiyet = true, BeslenmeTercihi = "", DiyetZorlukSeviyesi = "", HareketSeviyesi = "",  Kilo = 0, VucutKitleEndeksi = 0, BazalMetobalizma = 0, GunlukKaloriIhtiyaci = 0, DogumTarihi = new DateTime(1998, 2, 2) }
            );
           
        }
    }
}
