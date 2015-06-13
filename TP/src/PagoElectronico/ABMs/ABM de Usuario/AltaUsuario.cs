using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;
using PagoElectronico.ABMs.ABM_Cliente;
using PagoElectronico.Utilidades.Cifrado;

namespace PagoElectronico.ABMs.ABM_de_Usuario
{
    public partial class AltaUsuario : Form
    {

        int clienteID;
        
        public AltaUsuario()
        {
            InitializeComponent();
            DataTable roles = GestorDeSistema.obtenerRoles();
            cmbRol.DisplayMember = "Rol_Nombre";
            cmbRol.ValueMember = "Rol_Cod";
            cmbRol.DataSource = roles;

            clienteID = -1;
        }

        public void altaDeLogin()
        {
            cmbRol.Enabled = false;
            cmbRol.SelectedValue = 2;
        }

        public void altaDesdeCliente(int clienteIDP)
        {
            cmbRol.Enabled = false;
            cmbRol.SelectedValue = 2;

            btnAltaUsuario.Enabled = true;
            btnRegistrarCliente.Enabled = false;

            clienteID = clienteIDP;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbRol.SelectedValue) == 2)
            {
                btnRegistrarCliente.Enabled = true;
                btnAltaUsuario.Enabled = false;
            }
            else
            {
                btnRegistrarCliente.Enabled = false;
                btnAltaUsuario.Enabled = true;
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            bool validacionCorrecta = validaciones();
            if (validacionCorrecta == true)
            {
                if (txtContraseña.Text == txtVerificarContraseña.Text)
                {
                    AltaCliente nuevoCliente = new AltaCliente();
                    System.Windows.Forms.MessageBox.Show("El usuario sera dado de alta una vez que se registre como Nuevo Cliente.");

                    nuevoCliente.altaProvenienteDeUsuario(txtUsuario.Text, Cifrador.Cifrar(txtContraseña.Text), Convert.ToInt32(cmbRol.SelectedValue), txtPreguntaSecreta.Text, txtRespuestaSecreta.Text);
                    nuevoCliente.Show(this);
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Los campos de contraseña no coinciden. Por favor verifique.");

                }

            }

        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            bool validacionCorrecta = validaciones();
            if (validacionCorrecta == true)
            {
                if (txtContraseña.Text == txtVerificarContraseña.Text)
                {
                    GestorDeSistema.altaUsuario(txtUsuario.Text, Cifrador.Cifrar(txtContraseña.Text), Convert.ToInt32(cmbRol.SelectedValue), txtPreguntaSecreta.Text, txtRespuestaSecreta.Text, clienteID);
                    System.Windows.Forms.MessageBox.Show("El usuario fue dado de Alta correctamente");
                    Owner.Show();
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Los campos de contraseña no coinciden. Por favor verifique.");
                }
            }

            
        }

        private bool validaciones()
        {
            string textoUsuario = txtUsuario.Text;
            string textoContraseña = txtContraseña.Text;
            string textoPregSec = txtPreguntaSecreta.Text;
            string textoRespSec = txtRespuestaSecreta.Text;

            if (textoUsuario == "")
            {
                MessageBox.Show("El campo 'Usuario' no puede estar vacío", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (textoContraseña == "")
            {
                MessageBox.Show("El campo 'Contraseña' no puede estar vacío", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (textoPregSec == "")
            {
                MessageBox.Show("El campo 'Pregunta secreta' no puede estar vacío", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (textoRespSec == "")
            {
                MessageBox.Show("El campo 'Respuesta secreta' no puede estar vacío", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (GestorDeSistema.usuarioExiste(txtUsuario.Text) == true)
            {
                MessageBox.Show("Usuario existente. Por favor elija otro nombre de Usuario.", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
    
}
