using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GAP
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Clientes> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Clientes>();
           
        }
        public BindingList<Clientes> ObtenerClientes()
        {
            _contexto.clientes.Load();
            ListaClientes = _contexto.clientes.Local.ToBindingList();
          
            return ListaClientes;
        }

        public Resultado guardarclientes(Clientes clientes)
        {
            var resultado = validar(clientes);
            if (resultado.existoso==false)
            {
                return resultado;
            }
            if (clientes.codigo == 0)
            {
                clientes.codigo = ListaClientes.Max(item => item.codigo) + 1;
            }
            resultado.existoso=true;
            return resultado;
        }

        public void agregarclientes()
        {
            var nuevocliente = new Clientes();
            ListaClientes.Add(nuevocliente);

        }
        public bool eliminarclientes(int codigo)
        {
        foreach (var cliente in ListaClientes)
	{
                if (cliente.codigo==codigo)
                {
                    ListaClientes.Remove(cliente);
                    return true;
                }
	}
        return false;
        }
         private Resultado validar(Clientes cliente)
        {
            var resultado = new Resultado();
            resultado.existoso = true;
            

            if (cliente.Nombredelnino== "")
            {
                resultado.Mensaje = "Ingrese un datos en nombre del nino(a)";
                resultado.existoso = false;
            }
            if (cliente.direccionM=="")
            {
                resultado.Mensaje = "llene el campo";
                resultado.existoso = false;
            }
            return resultado;
        }

    }
    public class Clientes
    {
        public int codigo { get; set; }
        public string Nombredelnino { get; set; }
        public string Nombredelpadre { get; set; }
        public long identidadP { get; set; }
        public int telefonoP { get; set; }
        public string ocupacionP { get; set; }
        public string direccionP { get; set; }
        public string Nombredelamadre { get; set; }
        public long identidadM { get; set; }
        public int telefonoM { get; set; }
        public string ocupacionM { get; set; }
        public string direccionM { get; set; }
        public bool activo { get; set; }

    }
    public class Resultado
        {
        public bool existoso { get; set; }
        public string Mensaje { get; set; }
       
    }

}
