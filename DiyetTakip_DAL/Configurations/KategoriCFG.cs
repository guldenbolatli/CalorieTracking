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
    public class KategoriCFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.Property(x => x.Ad).IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.Fotograf).IsRequired(false).HasColumnType("nvarchar");
            builder.Property(x => x.AktifMİ).IsRequired().HasColumnType("bit").HasDefaultValue(true);
        }
    }
}
