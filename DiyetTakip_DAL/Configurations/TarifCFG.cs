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
    public class TarifCFG : IEntityTypeConfiguration<Tarif>
    {
        public void Configure(EntityTypeBuilder<Tarif> builder)
        {
            builder.Property(x => x.TarifDetayi).IsRequired(false).HasColumnType("nvarchar");
            builder.Property(x => x.HazirlamaSuresi).IsRequired().HasColumnType("int");

            builder.HasOne(y => y.Yiyecek).WithOne(t => t.Tarif).HasForeignKey<Tarif>(x => x.YiyecekID);
            builder.Property(x => x.AktifMİ).IsRequired().HasColumnType("bit").HasDefaultValue(true);
        }
    }
}
