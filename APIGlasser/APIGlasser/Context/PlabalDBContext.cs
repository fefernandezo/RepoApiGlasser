using APIGlasser.Models.TablasPlabal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APIGlasser.Context
{
    public partial class PlabalDBContext :DbContext
    {
        public PlabalDBContext()
        {

        }
        public PlabalDBContext(DbContextOptions<PlabalDBContext> options)
            :base(options)
        {

        }

        public virtual DbSet<ECOM_PEDIDOS> ECOM_PEDIDOS { get; set; }
        public virtual DbSet<Feriados> Feriados { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer();
            }
        }
        */

        
    }
}
