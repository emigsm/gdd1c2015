using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;
using PagoElectronico.Utilidades.Cifrado;

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

            DataTable roles = GestorDeSistema.obtenerRoles();
            cmbCambioRol.DisplayMember = "Rol_Nombre";
            cmbCambioRol.ValueMember = "Rol_Cod";
            cmbCambioRol.DataSource = roles;

            DataTable rolesUsuario = GestorDeSistema.obtenerRolesParaUsuario(usuarioID);
            cmbRolActual.DisplayMember = "Rol_Nombre";
            cmbRolActual.ValueMember = "Rol_Cod";
            cmbRolActual.DataSource = rolesUsuario;
        
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
                cmbRolActual.Enabled = true;
                lblCambioRol.Enabled = true;
                cmbCambioRol.Enabled = true;
                rbModificarRol.Enabled = true;
                rbAgregarRol.Enabled = true;
                btnCambiarRol.Enabled = true;
                rbEliminarRol.Enabled = true;
            }
            else
            {
                lblRolActual.Enabled = false;
                cmbRolActual.Enabled = false;
                lblCambioRol.Enabled = false;
                cmbCambioRol.Enabled = false;
                rbModificarRol.Enabled = false;
                rbAgregarRol.Enabled = false;
                btnCambiarRol.Enabled = false;
                rbEliminarRol.Enabled = false;
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
                /*CAMBIO DE CONTRASEÑA*/
                GestorDeSistema.cambiarContraseña(usuarioID, Cifrador.Cifrar(txtContraseña.Text));
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
            GestorDeSistema.cambiarPreguntaSecreta(usuarioID, txtPregSec.Text, txtRespSec.Text);
            System.Windows.Forms.MessageBox.Show("Pregunta secreta cambiada correctamente");
        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            if (rbAgregarRol.Checked == true)
            {
                /*FALTA VERIFICAR QUE NO AGREGUE ROLES QUE YA POSEE*/
                GestorDeSistema.agregarRolAUsuario(usuarioID, Convert.ToInt32(cmbCambioRol.SelectedValue));
                System.Windows.Forms.MessageBox.Show("Rol agregado correctamente");
            }
            else if(rbModificarRol.Checked == true)
            {
                /*FALTA VERIFICAR QUE NO SE PUEDA CAMBIAR UN ROL AL MISMO Y COSAS ASI*/
                GestorDeSistema.modificarRolAUsuario(usuarioID, Convert.ToInt32(cmbCambioRol.SelectedValue), Convert.ToInt32(cmbRolActual.SelectedValue));
                System.Windows.Forms.MessageBox.Show("Rol cambiado correctamente");
            }
            else if (rbEliminarRol.Checked == true)
            {
                /*VERIFICAR QUE NO SE QUEDE SIN ROLES*/
                if (cmbRolActual.Items.Count > 1)
                {
                    GestorDeSistema.eliminarRolAUsuario(usuarioID, Convert.ToInt32(cmbRolActual.SelectedValue));
                    System.Windows.Forms.MessageBox.Show("Rol eliminado correctamente");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No se puede eliminar un rol único", "Error");
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Debe elegir una accion para realizar sobre el Rol", "Error");
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
