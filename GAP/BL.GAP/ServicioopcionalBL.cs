using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GAP
{
    public class ServicioopcionalBL
    {
        Contexto _contexto;
        public BindingList<Servicioopcional> Listaservicioopiconal { get; set; }

        public ServicioopcionalBL()
        {
            _contexto = new Contexto();
            Listaservicioopiconal = new BindingList<Servicioopcional>();

        }
        public BindingList<Servicioopcional> Obtenerservicioopcinal()
        {
            _contexto.servicioopcional.Load();
            Listaservicioopiconal = _contexto.servicioopcional.Local.ToBindingList();

            return Listaservicioopiconal;
        }
    }
    public class Servicioopcional
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public int clientesId { get; set; }
        public Clientes Nombredelnino { get; set; }

    }
}
