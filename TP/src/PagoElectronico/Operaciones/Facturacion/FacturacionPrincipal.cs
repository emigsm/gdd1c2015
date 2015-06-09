using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Operaciones.Facturacion;

namespace PagoElectronico.Operaciones.Facturacion
{
    public partial class FacturacionPrincipal : Form
    {
        string usuario;

        public FacturacionPrincipal(string username)
        {
            InitializeComponent();
            usuario = username;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (opComprarSuscripcion.Checked == true)
            {
                ComprarSuscripciones frmSuscripciones = new ComprarSuscripciones(usuario);
                frmSuscripciones.Show();
                this.Hide();
            }
            if (opGenerarFactura.Checked == true)
            {
                GenerarFactura frmGenerarFactura = new GenerarFactura(usuario);
                frmGenerarFactura.Show();
                this.Hide();
            }
        }
    }
}
