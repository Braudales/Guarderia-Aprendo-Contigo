using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GAP
{
       public class Contexto:DbContext
    {
        public Contexto(): base("Guarderia Aprendo Contigo")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet <Clientes>clientes { get; set; }

    }
}
