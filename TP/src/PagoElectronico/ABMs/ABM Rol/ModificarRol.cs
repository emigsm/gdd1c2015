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

        private void ModificarRol_Load(object sender, EventArgs e)
        {

        }
    }
}
