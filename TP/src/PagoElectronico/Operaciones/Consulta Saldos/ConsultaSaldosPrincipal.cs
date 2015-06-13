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

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bool validacionesCorrectas = validaciones();
            if (validacionesCorrectas == true)
            {
                dgvDepositos.Rows.Clear();

                int clienteABuscar = Convert.ToInt32(txtClienteNumero.Text);
                long cuentaABuscar = Convert.ToInt64(cmbCuentas.SelectedValue);
                lblVSaldo.Text = GestorDeSistema.obtenerSaldo(clienteABuscar, cuentaABuscar);
                DataTable saldosDepositos = GestorDeSistema.saldosDepositos(clienteABuscar, cuentaABuscar);
                if (saldosDepositos.Rows.Count > 0)
                {
                    foreach (DataRow saldoDEncontrado in saldosDepositos.Rows)
                    {
                        dgvDepositos.Rows.Add(saldoDEncontrado.ItemArray[0],
                                             saldoDEncontrado.ItemArray[1],
                                             saldoDEncontrado.ItemArray[2].ToString(),
                                             saldoDEncontrado.ItemArray[3].ToString());
                    }
                    dgvDepositos.Update();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No se encontraron depósitos realizados con los datos proporcionados");
                }

                DataTable saldosRetiros = GestorDeSistema.saldosRetiros(clienteABuscar, cuentaABuscar);
                if (saldosRetiros.Rows.Count > 0)
                {
                    foreach (DataRow saldoREncontrado in saldosRetiros.Rows)
                    {
                        dgvRetiros.Rows.Add(saldoREncontrado.ItemArray[0],
                                             saldoREncontrado.ItemArray[1],
                                             saldoREncontrado.ItemArray[2].ToString(),
                                             saldoREncontrado.ItemArray[3].ToString());
                    }
                    dgvRetiros.Update();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No se encontraron retiros realizados con los datos proporcionados");
                }

                DataTable saldosTransferencias = GestorDeSistema.saldosTransferencias(clienteABuscar, cuentaABuscar);
                if (saldosTransferencias.Rows.Count > 0)
                {
                    foreach (DataRow saldoTEncontrado in saldosTransferencias.Rows)
                    {
                        dgvTransferencias.Rows.Add(saldoTEncontrado.ItemArray[0],
                                             saldoTEncontrado.ItemArray[1],
                                             saldoTEncontrado.ItemArray[2].ToString(),
                                             saldoTEncontrado.ItemArray[3].ToString(),
                                             saldoTEncontrado.ItemArray[4].ToString());
                    }
                    dgvTransferencias.Update();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No se encontraron transferencias realizadas con los datos proporcionados");
                }

            }
            

        }



        private void btnCargarCuentas_Click(object sender, EventArgs e)
        {
            bool validacionesCorrectas = validaciones();
            if (validacionesCorrectas == true)
            {
                DataTable cuentas = GestorDeSistema.obtenerCuentasCliente(Convert.ToInt32(txtClienteNumero.Text));
                if (cuentas.Rows.Count != 0)
                {
                    cmbCuentas.DisplayMember = "Cuenta_Numero";
                    cmbCuentas.ValueMember = "Cuenta_Numero";
                    cmbCuentas.DataSource = cuentas;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("El Número de Cliente es inexistente o no posee cuentas.");
                }

            }

        }

        private bool validaciones()
        {
            if (txtClienteNumero.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("El campo 'Cliente Número' no puede estar vacío");
                return false;
            }

            string valorClienteID = txtClienteNumero.Text;
            int verificacion = 0;
            bool canConvert = int.TryParse(valorClienteID, out verificacion);
            if (canConvert != true)
            {
                MessageBox.Show("El campo 'Cliente Número' sólo puede contener números", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}