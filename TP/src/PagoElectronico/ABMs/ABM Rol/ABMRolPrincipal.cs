using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.ABMs.ABM_Rol;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.ABMs.ABM_Rol
{
    public partial class ABMRolPrincipal : Form
    {
        public ABMRolPrincipal()
        {
            InitializeComponent();
        }

        private void ABMRolPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void CrearRolButton_Click(object sender, EventArgs e)
        {
            CrearRol rol = new CrearRol();
            rol.Show(this);
            this.Hide();
        }

        private void BuscarRolesButton_Click(object sender, EventArgs e)
        {
            dgvRoles.Rows.Clear();
            dgvRoles.Update();
            DataTable roles = GestorDeSistema.buscarRoles(Rol_CodTextBox.Text, Rol_NombreTextBox.Text);

            foreach (DataRow rol in roles.Rows)
            {
                dgvRoles.Rows.Add(rol.ItemArray[0], rol.ItemArray[1], rol.ItemArray[2], "Modificar", "Borrar");
            }
            dgvRoles.Update();
        }

        private void LimpiarBusquedaButton_Click(object sender, EventArgs e)
        {
            Rol_CodTextBox.Text = String.Empty;
            Rol_NombreTextBox.Text = String.Empty;
            dgvRoles.Rows.Clear();
            dgvRoles.Update();
        }
    }
}
