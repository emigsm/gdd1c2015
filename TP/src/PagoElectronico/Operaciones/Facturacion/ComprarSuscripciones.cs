using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Facturacion
{
    public partial class ComprarSuscripciones : Form
    {
        public ComprarSuscripciones(string usuario)
        {
            InitializeComponent();
            DataTable cuenta = GestorDeSistema.obtenerCuentasDeUsuario(usuario);
            cmbCuenta.DisplayMember = "Cuenta_Numero";
            cmbCuenta.ValueMember = "Cuenta_Numero";
            cmbCuenta.DataSource = cuenta;
            

        }

        private void ComprarSuscripciones_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTipoCuenta.Text = GestorDeSistema.obtenerTipoDeCuenta(cmbCuenta.SelectedValue.ToString());
        }
    }
}
