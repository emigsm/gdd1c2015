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
            cargarCmbsEstado();
            cargarCmbsRol();
        }

        public ModificacionUsuario(int usuarioIDP)
        {
            InitializeComponent();
            usuarioID = usuarioIDP;
            groupBoxRol.Enabled = false;
            groupBoxEstado.Enabled = false;
            cargarCmbsEstado();
            cargarCmbsRol();
        }

        private void cargarCmbsRol()
        {
            DataTable roles = GestorDeSistema.obtenerRoles();
            cmbCambioRol.DisplayMember = "Rol_Nombre";
            cmbCambioRol.ValueMember = "Rol_Cod";
            cmbCambioRol.DataSource = roles;
            
            DataTable rolesUsuario = GestorDeSistema.obtenerRolesParaUsuario(usuarioID);
            cmbRolActual.DisplayMember = "Rol_Nombre";
            cmbRolActual.ValueMember = "Rol_Cod";
            cmbRolActual.DataSource = rolesUsuario;      
        }

        private void cargarCmbsEstado()
        {
            DataTable dtcmbEstado = new DataTable();
            dtcmbEstado.Columns.Add("DisplayMember");
            dtcmbEstado.Columns.Add("ValueMember");

            dtcmbEstado.Rows.Add("Habilitado", true);
            dtcmbEstado.Rows.Add("Deshabilitado", false);

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
                cmbRolActual.Enabled = true;
                lblCambioRol.Enabled = true;
                cmbCambioRol.Enabled = true;
                rbModificarRol.Enabled = true;
                rbAgregarRol.Enabled = true;
                rbAgregarRol.Checked = true;
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
            if ((txtContraseña.Text == txtVerificarContraseña.Text) && (txtContraseña.Text != ""))
            {
                /*CAMBIO DE CONTRASEÑA*/
                GestorDeSistema.cambiarContraseña(usuarioID, Cifrador.Cifrar(txtContraseña.Text));
                System.Windows.Forms.MessageBox.Show("Contraseña cambiada correctamente");

            }
            else
            {
                /*CAMPOS NO COINCIDEN*/
                System.Windows.Forms.MessageBox.Show("Los campos no coinciden o estan vacíos. Por favor verifique las inconsistencias.", "Error");
            }
        }

        private void btnCambiarPregunta_Click(object sender, EventArgs e)
        {
            if (txtPregSec.Text != "" && txtRespSec.Text != "")
            {
                GestorDeSistema.cambiarPreguntaSecreta(usuarioID, txtPregSec.Text, txtRespSec.Text);
                System.Windows.Forms.MessageBox.Show("Pregunta secreta cambiada correctamente");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No puede dejar campos vacíos. Por favor verifique las inconsistencias.", "Error");
            }

        }

        private void btnCambiarRol_Click(object sender, EventArgs e) // ACTUALIZA UNA VEZ HECHA LA ACION
        {
            List<int> rolesActuales = new List<int>();
            int indexAnterior = cmbRolActual.SelectedIndex;
            for (int i = 0; i < cmbRolActual.Items.Count; i++)
            {
                cmbRolActual.SelectedIndex = i;
                rolesActuales.Add(Convert.ToInt32(cmbRolActual.SelectedValue));
            }
            cmbRolActual.SelectedIndex = indexAnterior;

            
            if (rbAgregarRol.Checked == true)
                            
            {
                if (rolesActuales.Contains(Convert.ToInt32(cmbCambioRol.SelectedValue)))
                {
                    MessageBox.Show("Ya posee el rol que intenta agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    GestorDeSistema.agregarRolAUsuario(usuarioID, Convert.ToInt32(cmbCambioRol.SelectedValue));
                    System.Windows.Forms.MessageBox.Show("Rol agregado correctamente");
                    cargarCmbsRol();                
                }


            }
            else if(rbModificarRol.Checked == true)
            {

                if (rolesActuales.Contains(Convert.ToInt32(cmbCambioRol.SelectedValue)))
                {
                    MessageBox.Show("Ya posee el rol que intenta modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    GestorDeSistema.modificarRolAUsuario(usuarioID, Convert.ToInt32(cmbCambioRol.SelectedValue), Convert.ToInt32(cmbRolActual.SelectedValue));
                    System.Windows.Forms.MessageBox.Show("Rol cambiado correctamente");
                    cargarCmbsRol();
                }

            }
            else if (rbEliminarRol.Checked == true)
            {
                if (cmbRolActual.Items.Count > 1)
                {
                    int rolAEliminar = Convert.ToInt32(cmbRolActual.SelectedValue);
                    GestorDeSistema.eliminarRolAUsuario(usuarioID, rolAEliminar);
                    System.Windows.Forms.MessageBox.Show("Rol eliminado correctamente");
                    cargarCmbsRol();
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
            cargarCmbsEstado();
        }

        private void rbAgregarRol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAgregarRol.Checked == true)
            {
                lblCambioRol.Text = "Agregar:";
            }
            else
            {
                lblCambioRol.Text = "Cambiar a:";
            }
        }

        private void rbEliminarRol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEliminarRol.Checked == true)
            {
                lblCambioRol.Enabled = false;
                cmbCambioRol.Enabled = false;
            }
            else
            {
                lblCambioRol.Enabled = true;
                cmbCambioRol.Enabled = true;
            }
        }


    }
}
