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
    public partial class ModificarRol : Form
    {
        private bool hab;
        private int rol_cod;
        private string nombre;

        public ModificarRol(int rolCod, string rolNombre, bool rolHabilitado)
        {
            InitializeComponent();

            hab = rolHabilitado;
            rol_cod = rolCod;
            nombre = rolNombre;

            RolNombreTextBox.Text = nombre;
            HabilitarRolCheckbox.Checked = hab;

            if (hab)
            {
                HabilitarRolCheckbox.Visible = false;
            }
            EstadoLabel.Text = hab ? "Habilitado" : "Inhabilitado";

            Funcionalidades.DataSource = GestorDeSistema.obtenerFuncionalidadesAsignables();
            Funcionalidades.DisplayMember = "Funcionalidad_Descripcion";
            Funcionalidades.ValueMember = "Funcionalidad_Cod";
            Funcionalidades.Update();

            List<byte> listaDeFuncionalidadesHabilitadas = GestorDeSistema.obtenerFuncionesHabilitadasPorRol(rol_cod);

            for (int count = 0; count < Funcionalidades.Items.Count; count++)
            {
                Funcionalidades.SetItemChecked(count, false);
                if (listaDeFuncionalidadesHabilitadas.Contains((byte)(((DataRowView)Funcionalidades.Items[count])["Funcionalidad_Cod"])))
                {
                    Funcionalidades.SetItemChecked(count, true);
                }
            }
        }

       private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (hab =!HabilitarRolCheckbox.Checked)
            {
                GestorDeSistema.habilitarODeshabilitarRol(rol_cod, (byte)((HabilitarRolCheckbox.Checked) ? 1 : 0));
            }
            foreach (DataRowView view in Funcionalidades.Items)
                GestorDeSistema.agregarFuncionalidadARol(nombre, Convert.ToInt32(view["Funcionalidad_Cod"]), 0);
            foreach (DataRowView view in Funcionalidades.CheckedItems)
                GestorDeSistema.agregarFuncionalidadARol(nombre, Convert.ToInt32(view["Funcionalidad_Cod"]), 1);
            Owner.Show();
            this.Hide();
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
             this.Hide();
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {

        }
    }
}
