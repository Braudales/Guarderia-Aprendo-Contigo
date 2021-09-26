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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Clavegerencial()
        {
            var formclavemaestra = new Formclavemaestra();
            formclavemaestra.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formclientes = new FormClientes();
            formclientes.MdiParent = this;
            formclientes.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var formFacturacion = new FormFacturacion();
            formFacturacion.MdiParent = this;
            formFacturacion.Show();
        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var formserviciosopcionales = new FormServiciosOpcionales();
            formserviciosopcionales.MdiParent = this;
            formserviciosopcionales.Show();
        }

        private void agregarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var formrecargo = new FormRecargos();
            formrecargo.MdiParent = this;
            formrecargo.Show();
        }

        private void agregarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var formcuentasporcobrar = new FormCuentasporcobrar();
            formcuentasporcobrar.MdiParent = this;
            formcuentasporcobrar.Show();
        }

        private void agregarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var formcuentasporpagar = new FormCuentasporpagar();
            formcuentasporpagar.MdiParent = this;
            formcuentasporpagar.Show();
        }

        private void agregarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            var formgastosfijos = new FormGastosfijos();
            formgastosfijos.MdiParent = this;
            formgastosfijos.Show();
        }

        private void agregarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            var formgastosvariables = new FormGastosvariables();
            formgastosvariables.MdiParent = this;
            formgastosvariables.Show();
        }

        private void agregarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            var formcotizaciones = new FormCotizaciones();
            formcotizaciones.MdiParent = this;
            formcotizaciones.Show();
        }

        private void agregarToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            var formdevoluciones = new FormDevoluciones();
            formdevoluciones.MdiParent = this;
            formdevoluciones.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Clavegerencial();
           
         
        }
    }
}
