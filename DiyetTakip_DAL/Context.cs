using DiyetTakip_DAL.Configurations;
using DiyetTakip_Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL
{
    public class Context:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciYiyecekAlerji> KullaniciYiyecekAlerjiler { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<OgunTakibi> OgunTakipleri { get; set; }
        public DbSet<Tarif> Tarifler { get; set; }

        public DbSet<Yiyecek> Yiyecekler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=MSI;Initial Catalog=DiyetTakip;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Kategori>(new KategoriCFG());
            modelBuilder.ApplyConfiguration<Kullanici>(new KullaniciCFG());
            modelBuilder.ApplyConfiguration<KullaniciYiyecekAlerji>(new KullaniciYiyecekAlerjiCFG());
            modelBuilder.ApplyConfiguration<Ogun>(new OgunCFG());
            modelBuilder.ApplyConfiguration<Tarif>(new TarifCFG());
            modelBuilder.ApplyConfiguration<Yiyecek>(new YiyecekCFG());
        }
    }
}
