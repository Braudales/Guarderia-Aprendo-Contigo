using BL.GAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.GAP
{
    public partial class FormClientes : Form
    {
        ClientesBL _clientes;

        public FormClientes()
        {
            InitializeComponent();
            _clientes = new ClientesBL();
            clientesBindingSource.DataSource = _clientes.ObtenerClientes();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void direccionPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void identidadPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombredelpadreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ocupacionPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            var clientes = (Clientes)clientesBindingSource.Current;
            var resultado = _clientes.guardarclientes(clientes);
            if (resultado.existoso == true)
            {
                clientesBindingSource.ResetBindings(false);
                deshabilitarHabilitarbotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var clientes = (Clientes)clientesBindingSource.Current;
            var resultado = _clientes.guardarclientes(clientes);
            if (resultado.existoso == true)
            {
                clientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("ocrurrio un error al guardar");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.agregarclientes();
            clientesBindingSource.MoveLast();
            deshabilitarHabilitarbotones(false);

        }

        private void deshabilitarHabilitarbotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
           


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            if (Id.Text != "")
            {
                    var resultado = MessageBox.Show("Desea eliminar este registro ", "Eliminar", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(Id.Text);
                    Eliminar(id);
                }
               

            }

        }
  

        private void Eliminar(int Id)
        {
           
            var resultado = _clientes.eliminarclientes(Id);
            if (resultado)
            {
                clientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error Elimando Cliente");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            deshabilitarHabilitarbotones(true);
            Eliminar(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _clientes.agregarclientes();
            clientesBindingSource.MoveLast();
            deshabilitarHabilitarbotones(false);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Id.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro ", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(Id.Text);
                    Eliminar(id);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            var clientes = (Clientes)clientesBindingSource.Current;
            var resultado = _clientes.guardarclientes(clientes);
            if (resultado.existoso == true)
            {
                clientesBindingSource.ResetBindings(false);
                deshabilitarHabilitarbotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            var clientes = (Clientes)clientesBindingSource.Current;
            var resultado = _clientes.guardarclientes(clientes);
            if (resultado.existoso == true)
            {
                clientesBindingSource.ResetBindings(false);
                deshabilitarHabilitarbotones(true);
                MessageBox.Show("Archivo modificado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }
    }
}
