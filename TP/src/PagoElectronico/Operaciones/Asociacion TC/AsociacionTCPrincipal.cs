using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Asociacion_TC
{
    public partial class AsociacionTCPrincipal : Form
    {
        public AsociacionTCPrincipal(String nombre, String apellido, Int32 id)
        {
        
            InitializeComponent();
            tarjetaApellidoCliLabel.Text = apellido;
            tarjetaNombreCliLabel.Text = nombre;
            tarjetaCliIdLabel.Text = id.ToString();
            
            DataTable tarjetas = GestorDeSistema.obtenerTarjetasCliente(id);

            if (tarjetas.Rows.Count > 0)
            {
                foreach (DataRow tarjeta in tarjetas.Rows)
                {
                    dgvTarjetas.Rows.Add(
                    tarjeta.ItemArray[0],
                    tarjeta.ItemArray[1],
                    tarjeta.ItemArray[2],
                    tarjeta.ItemArray[3],
                    tarjeta.ItemArray[4],
                    tarjeta.ItemArray[5]
                    );
                }
                dgvTarjetas.Update();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("el Cliente No posee Tarjetas a su Nombre");
            }
        }
        public AsociacionTCPrincipal()
        {

        }

        public void deshabilitarModificaciones()
        {
            VincularTarjetabutton.Enabled = false;
            desvincularTarjetabutton.Enabled = false;
            
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
