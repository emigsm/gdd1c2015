using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.ABMs.ABM_de_Usuario
{
    public partial class ModificacionUsuario : Form
    {
        int usuarioID;
        bool estadoUsuario;
        
        public ModificacionUsuario(int usuarioIDP, bool estadoUsuarioP)
        {
            InitializeComponent();
            usuarioID = usuarioIDP;
            estadoUsuario = estadoUsuarioP;

            DataTable dtcmbEstado = new DataTable();
            dtcmbEstado.Columns.Add("DisplayMember");
            dtcmbEstado.Columns.Add("ValueMember");

            dtcmbEstado.Rows.Add("Habilitado", true);
            dtcmbEstado.Rows.Add("Deshabilitado", false);

            cmbEstado.Items.Clear();
            cmbEstado.DataSource = dtcmbEstado;
            cmbEstado.DisplayMember = "DisplayMember";
            cmbEstado.ValueMember = "ValueMember";
            cmbEstado.SelectedValue = estadoUsuario;
            cmbEstado.Update();
        
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
                btnCambiarPregunta.Enabled = true;
            }
            else
            {
                lblPregSecreta.Enabled = false;
                lblRespSecretanueva.Enabled = false;
                txtPregSec.Enabled = false;
                txtRespSec.Enabled = false;
                btnCambiarPregunta.Enabled = false;
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
                btnCambiarContraseña.Enabled = true;
            }
            else
            {
                lblNuevaContraseña.Enabled = false;
                lblVerifContraseña.Enabled = false;
                txtContraseña.Enabled = false;
                txtVerificarContraseña.Enabled = false;
                btnCambiarContraseña.Enabled = false;
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
                btnCambiarRol.Enabled = true;
            }
            else
            {
                lblRolActual.Enabled = false;
                txtRolActual.Enabled = false;
                lblCambioRol.Enabled = false;
                cmbCambioRol.Enabled = false;
                rbModificarRol.Enabled = false;
                rbAgregarRol.Enabled = false;
                btnCambiarRol.Enabled = false;

            }
        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstado.Checked == true)
            {
                cmbEstado.Enabled = true;
                btnCambiarEstado.Enabled = true;
                cmbEstado.SelectedValue = estadoUsuario;
                cmbEstado.Update();
                
            }
            else 
            {
                cmbEstado.Enabled = false;
                btnCambiarEstado.Enabled = false;
                cmbEstado.SelectedValue = !estadoUsuario;
                cmbEstado.Update();
            }
        }

        private void btnVerificarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtVerificarContraseña.Text)
            {
                /*STORE MODIFICAR CONTRASEÑA*/
                System.Windows.Forms.MessageBox.Show("Contraseña cambiada correctamente");
            }
            else
            {
                /*CAMPOS NO COINCIDEN*/
                System.Windows.Forms.MessageBox.Show("Los campos no coinciden. Por favor verifique.");
            }
        }

        private void btnCambiarPregunta_Click(object sender, EventArgs e)
        {
            /*STORE MODIFICAR PREGUNTA*/
            System.Windows.Forms.MessageBox.Show("Pregunta secreta cambiada correctamente");
        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            if (rbAgregarRol.Checked == true)
            {
                /*STORE AGREGAR ROL*/
                System.Windows.Forms.MessageBox.Show("Rol agregado correctamente");
            }
            else
            {
                /*STORE MODIFICAR ROL*/
                System.Windows.Forms.MessageBox.Show("Rol cambiado correctamente");
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            /*STORE CAMBIAR HABILITADO*/
            GestorDeSistema.cambiarHabilitacionUsuario(Convert.ToBoolean(cmbEstado.SelectedValue), usuarioID);
            System.Windows.Forms.MessageBox.Show("Habilitacion cambiada correctamente");
        }

    }
}
