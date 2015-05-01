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

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rolCod = Convert.ToInt32(dgvRoles.Rows[e.RowIndex].Cells["Rol_Cod"].Value);
            string rolNombre = dgvRoles.Rows[e.RowIndex].Cells["Rol_Nombre"].Value.ToString();
            bool rolHabilitado = Convert.ToBoolean(dgvRoles.Rows[e.RowIndex].Cells["Rol_Habilitado"].Value);

            switch (e.ColumnIndex)
            {
                case 4:
                    if (!rolHabilitado)
                    { MessageBox.Show("El Rol seleccionado ya se encontraba inhabilitado", "Baja lógica de Rol", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                    GestorDeSistema.habODeshabRol(rolCod, 0);
                    MessageBox.Show("Se ha dado de baja el Rol seleccionado", "Baja lógica de Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarRolesButton.PerformClick();

                    break;

                case 3:
                    {
                        ModificarRol formularioModificacion = new ModificarRol(rolCod, rolNombre, rolHabilitado);
                        formularioModificacion.ShowDialog(this);
                        BuscarRolesButton.PerformClick();

                    }
                    break;
            }
        }
    }
}
