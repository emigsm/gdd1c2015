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

        private void txtClienteNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteNumero.Text != "") 
            {
                DataTable cuentas = GestorDeSistema.obtenerCuentasCliente(Convert.ToInt32(txtClienteNumero.Text));
                cmbCuentas.DisplayMember = "Cuenta_Numero";
                cmbCuentas.ValueMember = "Cuenta_Numero";
                cmbCuentas.DataSource = cuentas;
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvDepositos.Rows.Clear();

            int clienteABuscar = Convert.ToInt32(txtClienteNumero.Text);
            long cuentaABuscar = Convert.ToInt64(cmbCuentas.SelectedValue);
            DataTable saldosDepositos = GestorDeSistema.saldosDepositos(clienteABuscar, cuentaABuscar);
            if (saldosDepositos.Rows.Count > 0)
            {
                foreach (DataRow saldoEncontrado in saldosDepositos.Rows)
                {
                    dgvDepositos.Rows.Add(saldoEncontrado.ItemArray[0],
                                         saldoEncontrado.ItemArray[1],
                                         saldoEncontrado.ItemArray[2].ToString(),
                                         saldoEncontrado.ItemArray[3].ToString());
                }
                dgvDepositos.Update();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se encontraron depósitos realizados con los datos proporcionados");
            }
        }
    }
}