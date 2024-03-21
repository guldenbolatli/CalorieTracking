using DiyetTakip_Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Configurations
{
    public class KullaniciYiyecekAlerjiCFG : IEntityTypeConfiguration<KullaniciYiyecekAlerji>
    {
        public void Configure(EntityTypeBuilder<KullaniciYiyecekAlerji> builder)
        {
            builder.HasOne(x => x.Yiyecek).WithMany(x => x.AlerjisiOlanKullanicilar).HasForeignKey(x => x.YiyecekID).OnDelete(DeleteBehavior.Cascade); // Yiyecek silindiği zaman ilişkili olan verileri siler.

            builder.HasOne(x => x.Kullanici).WithMany(x => x.KullaniciAlerjileri).HasForeignKey(x => x.KullaniciID).OnDelete(DeleteBehavior.Cascade); //Kullanici silindiği zaman ilişkili olan verileri siler
        }
    }
}
