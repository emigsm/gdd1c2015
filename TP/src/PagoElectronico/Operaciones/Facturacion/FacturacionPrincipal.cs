using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Facturacion
{
    public partial class FacturacionPrincipal : Form
    {
        string usuario;
        int rol;

        public FacturacionPrincipal(int rolCod , string username)
        {
            InitializeComponent();
            usuario = username;
            rol = rolCod;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (opGenerarFactura.Checked == true)
            {
                GenerarFactura frmGenerarFactura = new GenerarFactura(rol,usuario);
                frmGenerarFactura.Owner = this;
                frmGenerarFactura.Show();
                this.Hide();
            }
            if (opComprarSuscripcion.Checked == true && rol == 1)
            {
                MessageBox.Show("Esta funcionalidad solo está disponible para clientes", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (opComprarSuscripcion.Checked == true && rol == 2)
            {
                ComprarSuscripciones frmSuscripciones = new ComprarSuscripciones(usuario);
                frmSuscripciones.Owner = this;
                frmSuscripciones.Show();
                this.Hide();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void FacturacionPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
