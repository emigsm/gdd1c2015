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
    public partial class AltaCuenta : Form
    {
        public AltaCuenta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
