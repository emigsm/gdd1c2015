using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Depositos
{
    public partial class DepositosPrincipal : Form
    {
        public DepositosPrincipal(string username)
        {
            InitializeComponent();
            string usuario = username;
            DataTable cuenta = GestorDeSistema.obtenerCuentasDeUsuario(usuario);
            cmbCuenta.DisplayMember = "Cuenta_Numero";
            cmbCuenta.ValueMember = "Cuenta_Numero";
            cmbCuenta.DataSource = cuenta;

            DataTable moneda = GestorDeSistema.obtenerMonedas();
            cmbMoneda.DisplayMember = "Moneda_Descripcion";
            cmbMoneda.ValueMember = "Moneda_Descripcion";
            cmbMoneda.DataSource = moneda;

            DataTable tarjeta = GestorDeSistema.obtenerTarjetasUsuario(usuario);
            cmbTarjeta.DisplayMember = "Tarjeta_Numero";
            cmbTarjeta.ValueMember = "Tarjeta_Numero";
            cmbTarjeta.DataSource = tarjeta;

            lblFecha.Text = Convert.ToString(GestorDeSistema.solicitarFecha());
        }

        private void DepositosPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }



        //Validaciones

        private void ImporteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo 'Importe' sólo puede contener números", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (ImporteTextBox.Text == "")
            {
                MessageBox.Show("El campo 'Importe' debe ser mayor o igual a 1", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            
            if (Convert.ToInt64(ImporteTextBox.Text) > 2147483647)
            {
                MessageBox.Show("El número ingresado en el campo 'Importe' es demasiado grande ", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbTarjeta.Items.Count == 0)
            {
                MessageBox.Show("No posee tarjetas para efectivizar el depósito", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(ImporteTextBox.Text) <1)
            {
                MessageBox.Show("El campo 'Importe' debe ser mayor o igual a 1", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {
                
                string cuenta =cmbCuenta.SelectedValue.ToString();
                int importe=Convert.ToInt32(ImporteTextBox.Text);
                string moneda= cmbMoneda.SelectedValue.ToString();
                string tarjeta=cmbTarjeta.SelectedValue.ToString();
                String mensaje = GestorDeSistema.depositar(cuenta, importe, moneda, tarjeta);
                MessageBox.Show(mensaje, "Resultado Operacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }


       
    }
}
