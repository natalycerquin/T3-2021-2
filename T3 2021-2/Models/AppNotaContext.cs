using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T3_2021_2.Models.MAP;

namespace T3_2021_2.Models
{
    public class AppNotaContext : DbContext
    {
        public virtual DbSet<Nota> Notas { get; set; }

        public AppNotaContext(DbContextOptions<AppNotaContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new NotaMap());
         
        }
    }
}
