using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABMs.ABM_de_Usuario
{
    public partial class ModificacionUsuario : Form
    {
        public ModificacionUsuario( int usuarioID)
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRolActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPregunta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPregunta.Checked == true)
            {
                lblPregSecreta.Enabled = true;
                lblRespSecretanueva.Enabled = true;
                txtPregSec.Enabled = true;
                txtRespSec.Enabled = true;
            }
            else
            {
                lblPregSecreta.Enabled = false;
                lblRespSecretanueva.Enabled = false;
                txtPregSec.Enabled = false;
                txtRespSec.Enabled = false;
            }

        }

        private void checkBoxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseña.Checked == true)
            {
                lblNuevaContraseña.Enabled = true;
                lblVerifContraseña.Enabled = true;
                txtContraseña.Enabled = true;
                txtVerificarContraseña.Enabled = true;
                btnVerificarContraseña.Enabled = true;
            }
            else
            {
                lblNuevaContraseña.Enabled = false;
                lblVerifContraseña.Enabled = false;
                txtContraseña.Enabled = false;
                txtVerificarContraseña.Enabled = false;
                btnVerificarContraseña.Enabled = false;
            }

        }

        private void checkBoxCambioRol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCambioRol.Checked == true)
            {
                lblRolActual.Enabled = true;
                txtRolActual.Enabled = true;
                lblCambioRol.Enabled = true;
                cmbCambioRol.Enabled = true;
                rbModificarRol.Enabled = true;
                rbAgregarRol.Enabled = true;
            }
            else
            {
                lblRolActual.Enabled = false;
                txtRolActual.Enabled = false;
                lblCambioRol.Enabled = false;
                cmbCambioRol.Enabled = false;
                rbModificarRol.Enabled = false;
                rbAgregarRol.Enabled = false;
            }
        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstado.Checked == true)
            {
                cmbEstado.Enabled = true;
            }
            else 
            {
                cmbEstado.Enabled = false;
            }
        }
    }
}
