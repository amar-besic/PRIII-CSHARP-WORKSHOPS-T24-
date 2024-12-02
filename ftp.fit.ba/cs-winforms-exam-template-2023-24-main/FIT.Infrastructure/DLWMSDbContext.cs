using FIT.Data;
using FIT.Data.IspitIB210178;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<DrzaveIB210178> DrzaveIB210178 { get; set; }
        public DbSet<GradoviIB210178> GradoviIB210178 { get; set; }
        public DbSet<PolozeniPredmetiIB210178> PolozeniPredmeti { get; set; }
        public DbSet<PredmetiIB210178> Predmeti { get; set; }
        public DbSet<SemestriIB210178> Semestri { get; set; }
        public DbSet<Student> Studenti { get; set; }

    }
}