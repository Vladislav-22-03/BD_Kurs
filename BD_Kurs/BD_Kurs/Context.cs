using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BD_Kurs
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Det> Details { get; set; }
        public DbSet<Sborka> Sborki { get; set; }
        public DbSet<Itog> Itogi { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Убедитесь, что правильно настроены связи:
            modelBuilder.Entity<Sborka>()
                .HasOne(s => s.Det)
                .WithMany()
                .HasForeignKey(s => s.DetId);

            modelBuilder.Entity<Itog>()
                .HasOne(i => i.Det)
                .WithMany()
                .HasForeignKey(i => i.DetId);
        }
        public Context() : base(new DbContextOptionsBuilder<Context>()
            .UseSqlServer("Server=.;Database=BD_Kurs;Integrated Security=true; TrustServerCertificate=True")
            .Options)
        {
        }
    }
}
