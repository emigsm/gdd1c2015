using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABMs.ABM_Cuenta
{
    public partial class ModificacionCuenta : Form
    {

        int clienteID;
        string pais, moneda, tipoCuenta;
        long numeroCuenta;
        
        public ModificacionCuenta(long numeroCuentaP, int clienteIDP, string paisP, string monedaP, string tipoCuentaP)
        {
            InitializeComponent();
            clienteID = clienteIDP;
            pais = paisP;
            moneda = monedaP;
            tipoCuenta = tipoCuentaP;
            numeroCuenta = numeroCuentaP;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void checkBoxPais_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPais.Checked == true)
            {
                lblPaisViejo.Enabled = true;
                lblPaisNuevo.Enabled = true;
                cmbPaisViejo.Enabled = true;
                cmbPaisNuevo.Enabled = true;
                btnCambiarPais.Enabled = true;
            }
            else
            {
                lblPaisViejo.Enabled = false;
                lblPaisNuevo.Enabled = false;
                cmbPaisViejo.Enabled = false;
                cmbPaisNuevo.Enabled = false;
                btnCambiarPais.Enabled = false;
            }

        }

        private void checkBoxMoneda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMoneda.Checked == true)
            {
                lblMonedaActual.Enabled = true;
                lblMonedaNueva.Enabled = true;
                cmbMonedaActual.Enabled = true;
                cmbMonedaNueva.Enabled = true;
                btnCambiarMoneda.Enabled = true;
            }
            else
            {
                lblMonedaActual.Enabled = false;
                lblMonedaNueva.Enabled = false;
                cmbMonedaActual.Enabled = false;
                cmbMonedaNueva.Enabled = false;
                btnCambiarMoneda.Enabled = false;
            }
        }


        private void checkBoxTipoCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTipoCuenta.Checked == true)
            {
                lblTipoCuentaActual.Enabled = true;
                lblTipoCuentaNuevo.Enabled = true;
                cmbTipoCuentaActual.Enabled = true;
                cmbTipoCuentaNuevo.Enabled = true;
                btnCambiarTipoCuenta.Enabled = true;
            }
            else
            {
                lblTipoCuentaActual.Enabled = false;
                lblTipoCuentaNuevo.Enabled = false;
                cmbTipoCuentaActual.Enabled = false;
                cmbTipoCuentaNuevo.Enabled = false;
                btnCambiarTipoCuenta.Enabled = false;
            }
        }
    }
}
