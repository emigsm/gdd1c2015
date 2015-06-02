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
            AltaCliente nuevoCliente = new AltaCliente();
            System.Windows.Forms.MessageBox.Show("El usuario sera dado de alta una vez que se registre como Nuevo Cliente.");

            nuevoCliente.altaProvenienteDeUsuario(txtUsuario.Text, Cifrador.Cifrar(txtContraseña.Text), Convert.ToInt32(cmbRol.SelectedValue), txtPreguntaSecreta.Text, txtRespuestaSecreta.Text);
            nuevoCliente.Show(this);
            this.Hide();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            if (GestorDeSistema.usuarioExiste(txtUsuario.Text) == false)
            {
                if (txtContraseña.Text == txtVerificarContraseña.Text)
                {
                    GestorDeSistema.altaUsuario(txtUsuario.Text, Cifrador.Cifrar(txtContraseña.Text), Convert.ToInt32(cmbRol.SelectedValue), txtPreguntaSecreta.Text, txtRespuestaSecreta.Text, clienteID);
                    System.Windows.Forms.MessageBox.Show("El usuario fue dado de Alta correctamente");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Los campos de contraseña no coinciden. Por favor verifique.");
                }
            }
            else 
            {
                System.Windows.Forms.MessageBox.Show("Usuario existente. Por favor elija otro nombre de Usuario.");
            }
        }
    }
    
}
