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
    public partial class GenerarFactura : Form
    {
        string cliente;

        public GenerarFactura(string usuario)
        {
            InitializeComponent();
            int rol = Convert.ToInt32(GestorDeSistema.obtenerRol(usuario));
            if (rol == 1)
            {
                cmbClientes.Visible = true;
                lblinstruccion.Visible = true;
                DataTable cliente = GestorDeSistema.obtenerClientes();
                cmbClientes.DisplayMember = "Cliente_ID";
                cmbClientes.ValueMember = "Cliente_ID";
                cmbClientes.DataSource = cliente;

            }
            else
            {
                cliente ="falta sp" ;
            }

        }

        private void GenerarFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        
    }
}
