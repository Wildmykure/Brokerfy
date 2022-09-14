using Brokerfy.Shared.Models.Aseguradoras;
using Brokerfy.Shared.Models.Brokers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brokerfy.Shared.Data
{
   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            //Para evitar problemas con zona horaria//
            System.AppContext.SetSwitch("npsql.EnableLegacyTimesBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Brokers> Brokers { get; set; }

        public DbSet<Aseguradoras> Aseguradoras { get; set; }
    }
}
