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

       private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTipoCuenta.Text = GestorDeSistema.obtenerTipoDeCuenta(cmbCuenta.SelectedValue.ToString());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            String resultado;
            resultado = GestorDeSistema.comprarSuscripcion(cmbCuenta.SelectedValue.ToString(), Convert.ToInt32(CantidadTextBox.Text));
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
