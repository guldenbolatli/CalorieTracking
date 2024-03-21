using DiyetTakip_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Configurations
{
    public class OgunCFG : IEntityTypeConfiguration<Ogun>
    {
        public void Configure(EntityTypeBuilder<Ogun> builder)
        {
            builder.Property(x => x.Ad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(x => x.AktifMİ).IsRequired().HasColumnType("bit").HasDefaultValue(true);
        }
    }
}
