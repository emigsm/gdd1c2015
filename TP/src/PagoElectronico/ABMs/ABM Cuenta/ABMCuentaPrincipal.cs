using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.ABMs.ABM_Cuenta
{
    public partial class ABMCuentaPrincipal : Form
    {
        int rolCod;
        string username;

        public ABMCuentaPrincipal(int rolCodP, string usernameP)
        {
            InitializeComponent();
            rolCod = rolCodP;
            username = usernameP;

            if (rolCod == 1)
            {
                lblClienteID.Enabled = true;
                txtClienteID.Enabled = true;
                lblCuentaNumero.Enabled = true;
                txtBuscarCuentaNumero.Enabled = true;
            }
            else
            {
                txtClienteID.Text = (GestorDeSistema.obtenerNumeroCliente(username)).ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            dgvCuenta.Rows.Clear();
            string cuentaABuscar = txtBuscarCuentaNumero.Text;

            string clienteABuscar = txtClienteID.Text;
            DataTable cuentasEncontradas = GestorDeSistema.obtenerDatosCuenta(cuentaABuscar, clienteABuscar);
            if (cuentasEncontradas.Rows.Count > 0)
            {
                foreach (DataRow usuarioEncontrado in cuentasEncontradas.Rows)
                {
                    dgvCuenta.Rows.Add(usuarioEncontrado.ItemArray[0],
                                         usuarioEncontrado.ItemArray[1],
                                         usuarioEncontrado.ItemArray[2].ToString(),
                                         usuarioEncontrado.ItemArray[3].ToString(),
                                         usuarioEncontrado.ItemArray[4],
                                         usuarioEncontrado.ItemArray[5],
                                         usuarioEncontrado.ItemArray[6],
                                         usuarioEncontrado.ItemArray[7],
                                         usuarioEncontrado.ItemArray[8],
                                         "Modificar",
                                         "Borrar");
                }
                dgvCuenta.Update();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se encontraron cuentas con los datos proporcionados");
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            dgvCuenta.Rows.Clear();
        }

        private void btnNuevaCuenta_Click(object sender, EventArgs e)
        {
            AltaCuenta nuevaCuenta = new AltaCuenta();
            nuevaCuenta.Show(this);
            this.Hide();
        }

    }
}
