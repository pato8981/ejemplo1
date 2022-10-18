using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a C#");
        }
        private void Formulario1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Chau... chau...");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento Click","Atención");
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el botón derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el botón del medio", "Atención");
        }

        private void lblDatosPersonales_MouseMove(object sender, MouseEventArgs e)
        {
            lblDatosPersonales.BackColor = Color.Cyan;
            lblDatosPersonales.Cursor = Cursors.Hand;
        }

        private void lblDatosPersonales_MouseLeave(object sender, EventArgs e)
        {
            lblDatosPersonales.BackColor = System.Drawing.SystemColors.Control;
            lblDatosPersonales.Cursor = Cursors.Arrow;
        }

        private void btnColorText_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtDireccion.Text.Length + " caracteres.");
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
