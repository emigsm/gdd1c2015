using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Consulta_Saldos
{
    public partial class ConsultaSaldosPrincipal : Form
    {

        int rolCod, numeroCliente;

        public ConsultaSaldosPrincipal(int rolCodP, string usernameP)
        {
            InitializeComponent();
            rolCod = rolCodP;

            if (rolCod == 1)
            {
                lblClienteNumero.Enabled = true;
                txtClienteNumero.Enabled = true;
            }
            else
            {
                numeroCliente = GestorDeSistema.obtenerNumeroCliente(usernameP);
                txtClienteNumero.Text = numeroCliente.ToString();

                DataTable cuentas = GestorDeSistema.obtenerCuentasCliente(Convert.ToInt32(txtClienteNumero.Text));
                cmbCuentas.DisplayMember = "Cuenta_Numero";
                cmbCuentas.ValueMember = "Cuenta_Numero";
                cmbCuentas.DataSource = cuentas;
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsultaSaldosPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}