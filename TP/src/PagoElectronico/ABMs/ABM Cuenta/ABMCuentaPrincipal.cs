using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABMs.ABM_Cuenta
{
    public partial class ABMCuentaPrincipal : Form
    {
        public ABMCuentaPrincipal(int rolCod)
        {
            InitializeComponent();
            if (rolCod == 1) {lblClienteID.Enabled = true ; txtClienteID.Enabled = true;}
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
