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
    public partial class AltaCuenta : Form
    {

        int rolCod;
        string clienteID;
        long numeroCuenta; 
        
        public AltaCuenta(int rolCodP, string clienteIDP)
        {
            InitializeComponent();
            rolCod = rolCodP;
            clienteID = clienteIDP;

            if (rolCod == 1)
            {
                lblClienteID.Enabled = true;
                txtClienteID.Enabled = true;
            }
            else
            {
                txtClienteID.Text = clienteID;
            }

            DataTable paises = GestorDeSistema.obtenerPaises();
            cmbPais.DisplayMember = "Pais_Descripcion";
            cmbPais.ValueMember = "Pais_Cod";
            cmbPais.DataSource = paises;
            DataTable monedas = GestorDeSistema.obtenerMonedas();
            cmbMoneda.DisplayMember = "Moneda_Descripcion";
            cmbMoneda.ValueMember = "Moneda_Codigo";
            cmbMoneda.DataSource = monedas;
            DataTable tipoCuentas = GestorDeSistema.obtenerTipoCuentas();
            cmbTipoCuenta.DisplayMember = "Tipo_Cuenta_Descripcion";
            cmbTipoCuenta.ValueMember = "Tipo_Cuenta_ID";
            cmbTipoCuenta.DataSource = tipoCuentas;
 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnAltaCuenta_Click(object sender, EventArgs e)
        {
            clienteID = txtClienteID.Text;
            numeroCuenta = GestorDeSistema.altaCuenta(clienteID, Convert.ToInt32(cmbPais.SelectedValue), Convert.ToInt32(cmbMoneda.SelectedValue), Convert.ToInt32(cmbTipoCuenta.SelectedValue));
            System.Windows.Forms.MessageBox.Show("Cuenta creada correctamente");
            System.Windows.Forms.MessageBox.Show("Su Cuenta ha sido dada de alta. \nEl numero de cuenta es: " + numeroCuenta.ToString() + " \nActualmente su cuenta se encuenta PENDIENTE DE ACTIVACION, consulte la seccion de Facturación");
            //METODO DE FACTURACION
        }
    }
}
