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
            if (CantidadTextBox.Text == "")
            {
                MessageBox.Show("El campo 'Cantidad de Suscripciones' debe ser mayor o igual a 1", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            if (Convert.ToInt64(CantidadTextBox.Text) > 254)
            {
                MessageBox.Show("El número ingresado en el campo 'Cantidad de Suscripciones' es demasiado grande ", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(CantidadTextBox.Text) < 1)
            {
                MessageBox.Show("El campo 'Cantidad de Suscripciones' debe ser mayor o igual a 1", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbCuenta.Items.Count == 0)
            {
                MessageBox.Show("No posee cuentas para comprar suscripciones", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (GestorDeSistema.overflowSuscripciones(Convert.ToInt32(CantidadTextBox.Text), cmbCuenta.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("Operación abortada.", "Prevención de Overflow", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String resultado;
            resultado = GestorDeSistema.comprarSuscripcion(cmbCuenta.SelectedValue.ToString(), Convert.ToInt32(CantidadTextBox.Text));
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo 'Cantidad de Suscrupciones' sólo puede contener números", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}
