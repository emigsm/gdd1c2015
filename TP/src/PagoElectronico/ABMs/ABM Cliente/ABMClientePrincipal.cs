using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABMs.ABM_Cliente
{
    public partial class ABMClientePrincipal : Form
    {
        public ABMClientePrincipal()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
