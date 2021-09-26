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
    public partial class Formclavemaestra : Form
    {
        public Formclavemaestra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
           string contrasena;
           contrasena = textBox1.Text;
            var formcambiosclave = new FormCambiosClave();
           
            if (contrasena == "1")
            {
                this.Close();
              
                formcambiosclave.Show();
               
              
            }
            else
            {
                MessageBox.Show("contrasena incorrecta");
   
            }
      
        }

        private void Formclavemaestra_Load(object sender, EventArgs e)
        {

        }
    }
}
