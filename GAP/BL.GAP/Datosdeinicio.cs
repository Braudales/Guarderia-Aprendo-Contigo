using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GAP
{
    public class Datosdeinicio:CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            base.Seed(contexto);

            var servicioopcional1 = new Servicioopcional();
            servicioopcional1.Descripcion = "Alimentacion";
            contexto.servicioopcional.Add(servicioopcional1);

            var servicioopcional2 = new Servicioopcional();
            servicioopcional2.Descripcion = "transporte";
            contexto.servicioopcional.Add(servicioopcional2);

            base.Seed(contexto);

        }
    }
}
