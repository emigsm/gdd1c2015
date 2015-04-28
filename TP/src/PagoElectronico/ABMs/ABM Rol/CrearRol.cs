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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CrearRol_Load(object sender, EventArgs e)
        {

        }
    }
}
