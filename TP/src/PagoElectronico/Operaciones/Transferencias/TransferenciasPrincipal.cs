using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Transferencias
{
    public partial class TransferenciasPrincipal : Form
    {
        string NroCuenta ="" ;
        public TransferenciasPrincipal(string username)
        {
            InitializeComponent();
            string usuario = username;
            DataTable cuenta = GestorDeSistema.obtenerCuentasDeUsuario(usuario);
            cmbCuentaOrigen.DisplayMember = "Cuenta_Numero";
            cmbCuentaOrigen.ValueMember = "Cuenta_Numero";
            cmbCuentaOrigen.DataSource = cuenta;

            lblFecha.Text = Convert.ToString(GestorDeSistema.solicitarFecha());
            lblCuenta.Text = NroCuenta;

        }

        private void TransferenciasPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCuentas_Click(object sender, EventArgs e)
        {
            dgvCuentaDestino.Rows.Clear();
            dgvCuentaDestino.Update();
            DataTable cuentas = GestorDeSistema.buscarCuentas(FiltroText.Text);

            foreach (DataRow cuenta in cuentas.Rows)
            {
                dgvCuentaDestino.Rows.Add(cuenta.ItemArray[0]);
            }
            dgvCuentaDestino.Update();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            FiltroText.Text = String.Empty;
            dgvCuentaDestino.Rows.Clear();
            dgvCuentaDestino.Update();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void dgvCuentaDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NroCuenta = dgvCuentaDestino.Rows[e.RowIndex].Cells["NumeroCuenta"].Value.ToString();
        }
    }
}
