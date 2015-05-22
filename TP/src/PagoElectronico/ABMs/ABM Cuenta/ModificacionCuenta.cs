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

            DataTable paises = GestorDeSistema.obtenerPaises();
            lblPaisActual.Text = pais;
            cmbPaisNuevo.DisplayMember = "Pais_Descripcion";
            cmbPaisNuevo.ValueMember = "Pais_Cod";
            cmbPaisNuevo.DataSource = paises;

            DataTable monedas = GestorDeSistema.obtenerMonedas();

            lblVMonedaActual.Text = moneda;
            cmbMonedaNueva.DisplayMember = "Moneda_Descripcion";
            cmbMonedaNueva.ValueMember = "Moneda_Codigo";
            cmbMonedaNueva.DataSource = monedas;

            DataTable tipoCuentas = GestorDeSistema.obtenerTipoCuentas();
            lblVTipoCuentaActual.Text = tipoCuenta;
            cmbTipoCuentaNuevo.DisplayMember = "Tipo_Cuenta_Descripcion";
            cmbTipoCuentaNuevo.ValueMember = "Tipo_Cuenta_ID";
            cmbTipoCuentaNuevo.DataSource = tipoCuentas;

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
                lblPaisActual.Enabled = true;
                cmbPaisNuevo.Enabled = true;
                btnCambiarPais.Enabled = true;
            }
            else
            {
                lblPaisViejo.Enabled = false;
                lblPaisNuevo.Enabled = false;
                lblPaisActual.Enabled = false;
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
                lblVMonedaActual.Enabled = true;
                cmbMonedaNueva.Enabled = true;
                btnCambiarMoneda.Enabled = true;
            }
            else
            {
                lblMonedaActual.Enabled = false;
                lblMonedaNueva.Enabled = false;
                lblVMonedaActual.Enabled = false;
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
                lblVTipoCuentaActual.Enabled = true;
                cmbTipoCuentaNuevo.Enabled = true;
                btnCambiarTipoCuenta.Enabled = true;
            }
            else
            {
                lblTipoCuentaActual.Enabled = false;
                lblTipoCuentaNuevo.Enabled = false;
                lblVTipoCuentaActual.Enabled = false;
                cmbTipoCuentaNuevo.Enabled = false;
                btnCambiarTipoCuenta.Enabled = false;
            }
        }

        private void groupBoxPais_Enter(object sender, EventArgs e)
        {

        }

        private void btnCambiarPais_Click(object sender, EventArgs e)
        {
            GestorDeSistema.modificarPaisCuenta(Convert.ToInt32(cmbPaisNuevo.SelectedValue), clienteID, numeroCuenta);
            System.Windows.Forms.MessageBox.Show("País modificado correctamente");
        }

        private void btnCambiarTipoCuenta_Click(object sender, EventArgs e)
        {
            GestorDeSistema.modificarTipoCuenta(Convert.ToInt32(cmbTipoCuentaNuevo.SelectedValue), clienteID, numeroCuenta);
            System.Windows.Forms.MessageBox.Show("Tipo de cuenta cambiada, consulte la sección Facturación");
            //FACTURAR
        }
    }
}
