using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABMs.ABM_Rol
{
    public partial class ModificarRol : Form
    {
        public ModificarRol(int rolCod, string rolNombre, bool rolHabilitado)
        {
            InitializeComponent();
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {

        }
    }
}
