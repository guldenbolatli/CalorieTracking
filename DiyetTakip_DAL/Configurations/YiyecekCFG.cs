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
    public class YiyecekCFG : IEntityTypeConfiguration<Yiyecek>
    {
        public void Configure(EntityTypeBuilder<Yiyecek> builder)
        {
            builder.Property(x => x.Ad).HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(x => x.MiktarTuru).HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            builder.Property(x => x.YagMiktari).HasColumnType("float").IsRequired();
            builder.Property(x => x.ProteinMiktari).HasColumnType("float").IsRequired();
            builder.Property(x => x.KarbonhidratMiktari).HasColumnType("float").IsRequired();
            builder.Property(x => x.Kalori).HasColumnType("float").IsRequired();
            builder.Property(x => x.Fotograf).IsRequired(false).HasColumnType("nvarchar");


            builder.HasOne(x=>x.Kategori).WithMany(x=>x.Yiyecekler).HasForeignKey(x=>x.KategoriID).OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.AktifMİ).IsRequired().HasColumnType("bit").HasDefaultValue(true);
        }
    }
}
