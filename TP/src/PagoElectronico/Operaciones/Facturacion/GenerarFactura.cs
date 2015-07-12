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
        int cliente;
        int factura;
        int resultadoOperacion;
        int rol;

        public GenerarFactura(int rolCod, string usuario)
        {
            InitializeComponent();
            int rol = rolCod;
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
                if (Convert.ToInt32(GestorDeSistema.obtenerIDCliente(usuario)) != -1)
                {
                    cliente = Convert.ToInt32(GestorDeSistema.obtenerIDCliente(usuario));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No posee datos de Cliente asociados, por favor consulte a un administrador.");

                }
                
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

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = Convert.ToInt32(cmbClientes.SelectedValue.ToString());
            
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if(GestorDeSistema.cuentaGratuitaPendiente(cliente)==true)
            {
                MessageBox.Show("Una o más cuentas gratuitas han sido activadas, dicha activación es sin cargo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            resultadoOperacion = Convert.ToInt32(GestorDeSistema.facturar(cliente));
            if (resultadoOperacion > 0)
            {
                factura = resultadoOperacion;
                
                dgvFactura.Rows.Clear();
                dgvFactura.Update();

                DataTable operacionesFacturadas = GestorDeSistema.obtenerFactura(factura);

                foreach (DataRow operacionFacturada in operacionesFacturadas.Rows)
                {
                    dgvFactura.Rows.Add(operacionFacturada.ItemArray[0],operacionFacturada.ItemArray[1],
                        operacionFacturada.ItemArray[2], operacionFacturada.ItemArray[3], operacionFacturada.ItemArray[4]);
                }
                dgvFactura.Update();
            }
            else
            { 
            MessageBox.Show("No hay operaciones pendientes de facturación","Resultado Operación",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

                
    }
}
