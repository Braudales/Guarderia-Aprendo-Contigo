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

        public BindingList<Clientes> ObtenerClientes(string buscar)
        {

           var query = _contexto.clientes.Where (Clientes=> Clientes.Nombredelnino.ToLower().Contains(buscar.ToLower())).ToList();
            ListaClientes = new BindingList<Clientes>(query); 

            return ListaClientes;
        }

        public Resultado guardarclientes(Clientes clientes)
        {
            var resultado = validar(clientes);
            if (resultado.existoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.existoso = true;
            return resultado;
        }

        public void agregarclientes()
        {
            var nuevocliente = new Clientes();
            ListaClientes.Add(nuevocliente);

        }
        public bool eliminarclientes(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        private Resultado validar(Clientes cliente)
        {
            var resultado = new Resultado();
            resultado.existoso = true;


            if (string.IsNullOrEmpty(cliente.Nombredelnino) == true)
            {
                resultado.Mensaje = "Ingrese un datos en nombre del nino(a)";
                resultado.existoso = false;
            }
            if (cliente.direccionM == " ")
            {
                resultado.Mensaje = "llene el campo";
                resultado.existoso = false;
            }
            return resultado;
        }

    }
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombredelnino { get; set; }
        public string Nombredelpadre { get; set; }
        public DateTime fechaingreso { get; set; }
        public double identidadP { get; set; }
        public int telefonoP { get; set; }
        public string ocupacionP { get; set; }
        public string direccionP { get; set; }
        public string Nombredelamadre { get; set; }
        public double identidadM { get; set; }
        public int telefonoM { get; set; }
        public string ocupacionM { get; set; }
        public string direccionM { get; set; }
        public byte[] Foto { get; set; }
        public bool activo { get; set; }


    }
    public class Resultado
    {
        public bool existoso { get; set; }
        public string Mensaje { get; set; }

    }

}