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
            if (GestorDeSistema.buscarRoles("",Rol_NombreTextBox.Text).Rows.Count>=1)
            { MessageBox.Show("Ya existe un rol con ese nombre"); return; }

            GestorDeSistema.crearRol(Rol_NombreTextBox.Text, HabilitadoOpButton.Checked);

            foreach (DataRowView funcionalidad in Funcionalidades.CheckedItems)
                GestorDeSistema.agregarFuncionalidadARol(Rol_NombreTextBox.Text, Convert.ToInt32(funcionalidad["Funcionalidad_Cod"]), 1);

            MessageBox.Show("Rol creado");
        }
    }
}
