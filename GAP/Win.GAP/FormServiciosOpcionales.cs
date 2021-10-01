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
    public partial class FormServiciosOpcionales : Form
    {
        ServicioopcionalBL _Servicioopcional;
        ClientesBL _clientes;
        public FormServiciosOpcionales()
        {
            InitializeComponent();
            _Servicioopcional = new ServicioopcionalBL();
           servicioopcionalBindingSource.DataSource = _Servicioopcional.Obtenerservicioopcinal();

            _clientes = new ClientesBL();
           listaClientesBindingSource.DataSource = _clientes.ObtenerClientes();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormServiciosOpcionales_Load(object sender, EventArgs e)
        {

        }
    }
}
