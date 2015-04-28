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
            string usuarioAbuscar = txtBuscarUsuaio.Text;
            DataTable usuariosEncontrados = GestorDeSistema.obtenerDatosUsuario(usuarioAbuscar);
            if (usuariosEncontrados.Rows.Count > 0)
            {
                foreach (DataRow usuarioEncontrado in usuariosEncontrados.Rows)
                {
                   /* System.Windows.Forms.MessageBox.Show(usuarioEncontrado.ItemArray[4].ToString());
                    System.Windows.Forms.MessageBox.Show(usuarioEncontrado.ItemArray[5].ToString());
                    System.Windows.Forms.MessageBox.Show(usuarioEncontrado.ItemArray[6].ToString());
                    System.Windows.Forms.MessageBox.Show(usuarioEncontrado.ItemArray[7].ToString());
                 */
                      dgvUsuario.Rows.Add(usuarioEncontrado.ItemArray[0],          
                                         usuarioEncontrado.ItemArray[1],
                                         usuarioEncontrado.ItemArray[2].ToString(),
                                         usuarioEncontrado.ItemArray[3].ToString(),
                                         "Modificar",
                                         "Borrar",
                                         usuarioEncontrado.ItemArray[6]);
                }
                dgvUsuario.Update();
            }
            else
            { 
                System.Windows.Forms.MessageBox.Show("No se encontraron usuarios con los datos proporcionados");
            }
        }
    }
}
