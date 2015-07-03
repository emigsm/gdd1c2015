using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.ABMs.ABM_Rol
{
    public partial class CrearRol : Form
    {
        public CrearRol()
        {
            InitializeComponent();
            Funcionalidades.DataSource = GestorDeSistema.obtenerFuncionalidadesAsignables();
            Funcionalidades.DisplayMember = "Funcionalidad_Descripcion";
            Funcionalidades.ValueMember = "Funcionalidad_Cod";
            Funcionalidades.Update();
        }
           
        private void CrearRol_Load(object sender, EventArgs e)
        {

        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void CrearRolButton_Click(object sender, EventArgs e)
        {

            if (Rol_NombreTextBox.Text == "")
            { MessageBox.Show("Ingrese un nombre para el nuevo rol"); return; }
            if (GestorDeSistema.rolExiste(Rol_NombreTextBox.Text) == true)
            { MessageBox.Show("Ya existe un rol con ese nombre"); return; }
            if (Funcionalidades.CheckedItems.Count ==0)
            { MessageBox.Show("Seleccione alguna funcionalidad"); return; }

            GestorDeSistema.crearRol(Rol_NombreTextBox.Text, HabilitadoOpButton.Checked);

            foreach (DataRowView funcionalidad in Funcionalidades.CheckedItems)
                GestorDeSistema.agregarFuncionalidadARol(Rol_NombreTextBox.Text, Convert.ToInt32(funcionalidad["Funcionalidad_Cod"]), 1);

            MessageBox.Show("Rol creado");
        }

        //Validaciones

        private void Rol_NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo 'Nombre del Rol' no puede contener números", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}
