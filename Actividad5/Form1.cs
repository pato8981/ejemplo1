using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        bool validar = true;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            //validar que los campos tengan contenido
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                validar = false;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                validar = false;
            }
                
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                validar = false;
            }
                
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                validar = false;
            }
            //guardar todo en Resultado
            if (validar == true)
            {
                string a1 = "Apellido y nombre: " + txtApellido.Text + " " + txtNombre.Text;
                string e1 = "Edad: " + txtEdad.Text;
                string d1 = "Dirección: " + txtDireccion.Text;
                txtResultado.Text = a1 + Environment.NewLine +e1 +Environment.NewLine + d1;
                
            }
        }

        
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
