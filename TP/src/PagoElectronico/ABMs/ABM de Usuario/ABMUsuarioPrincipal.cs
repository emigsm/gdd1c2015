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
    public partial class ABMUsuarioPrincipal : Form
    {
        public ABMUsuarioPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuario frmAltaUsuario = new AltaUsuario();
            frmAltaUsuario.Show(this);
            this.Hide();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            dgvUsuario.Rows.Clear();
            string usuarioAbuscar = txtBuscarUsuario.Text;
            DataTable usuariosEncontrados = GestorDeSistema.obtenerDatosUsuario(usuarioAbuscar);
            if (usuariosEncontrados.Rows.Count > 0)
            {
                foreach (DataRow usuarioEncontrado in usuariosEncontrados.Rows)
                {                                  
                    dgvUsuario.Rows.Add(usuarioEncontrado.ItemArray[0],          
                                         usuarioEncontrado.ItemArray[1],
                                         usuarioEncontrado.ItemArray[2].ToString(),
                                         usuarioEncontrado.ItemArray[3].ToString(),
                                         "Modificar",
                                         "Borrar",
                                         usuarioEncontrado.ItemArray[4]);                        
                }
                dgvUsuario.Update();
            }
            else
            { 
                System.Windows.Forms.MessageBox.Show("No se encontraron usuarios con los datos proporcionados");
            }
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            dgvUsuario.Rows.Clear();
        }

        private void txtBuscarUsuaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnBuscarUsuario.PerformClick();
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int usuarioIDAModificar = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells["Usuario_ID"].Value.ToString());
                ModificacionUsuario frmModificacionUsuario = new ModificacionUsuario(usuarioIDAModificar);
                frmModificacionUsuario.Show(this);
                this.Hide();
            }
            else if (e.ColumnIndex == 5)
            {
                string usernameAEliminar = dgvUsuario.Rows[e.RowIndex].Cells["Usuario_Username"].Value.ToString();
                DialogResult res = MessageBox.Show("Se eliminará el usuario: " + usernameAEliminar + "\n¿Está seguro?", "Atención", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    /*BORRADO LOGICO DE USUARIO*/
                    int usuarioIDAEliminar = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells["Usuario_ID"].Value.ToString());
                    GestorDeSistema.bajaLogicaUsuario(usuarioIDAEliminar);
                    System.Windows.Forms.MessageBox.Show("Usuario eliminado correctamente");                    
                }
            }

        }
    }
}
