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
    public class OgunTakibiCFG : IEntityTypeConfiguration<OgunTakibi>
    {
        public void Configure(EntityTypeBuilder<OgunTakibi> builder)
        {
            builder.Property(x => x.Miktar).HasColumnType("int").IsRequired();
            builder.Property(x => x.OlusturmaTarihi).HasColumnType("smalldatetime").IsRequired().HasColumnName("OgunTarihi");
            builder.Property(x => x.UrunToplamKalori).HasColumnType("float");
            

            builder.HasOne(x=>x.Kullanici).WithMany(x=>x.KullanicininOgundeYedigiYiyecekler).HasForeignKey(x=>x.KullaniciID).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x=>x.Ogun).WithMany(x=>x.OgundeKullancilarinYedigiYiyecekler).HasForeignKey(x=>x.OgunID).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x=>x.Yiyecek).WithMany(x=>x.YiyeceginYendigiKullaniciOgunleri).HasForeignKey(x=>x.YiyecekID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
