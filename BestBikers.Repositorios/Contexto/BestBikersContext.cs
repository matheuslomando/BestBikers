using BestBikers.Entidades.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBikers.Repositorios.Contexto
{
     public class BestBikersContext : DbContext
    {

        public BestBikersContext() : base("defaultConnection")
        {
        }

        public BestBikersContext(string connectionstring) : base(connectionstring)
        {

        }





        public DbSet<Moto> Motos { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
