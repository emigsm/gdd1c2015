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
            if (Convert.ToInt32(Rol_CodTextBox.Text)>2147483647)
            {
                MessageBox.Show("El número ingresado en Codigo de Rol es demasiado grande ", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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

                    GestorDeSistema.habilitarODeshabilitarRol(rolCod, 0);
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

        //Validaciones

        private void Rol_CodTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo 'Código del Rol' sólo puede contener números", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void Rol_NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {


                MessageBox.Show("El campo 'Nombre del Rol' no puede contener números", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
