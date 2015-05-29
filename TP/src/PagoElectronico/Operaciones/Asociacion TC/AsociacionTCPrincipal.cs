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
        Int32 idCliente { get; set; }

        public AsociacionTCPrincipal(string nombre,string apellido,Int32 id)
        {
            InitializeComponent();
            tarjetaApellidoCliLabel.Text = apellido;
            tarjetaNombreCliLabel.Text = nombre;
            tarjetaCliIdLabel.Text = id.ToString();
            idCliente = id;

            obtenerTarjetasCliente(id);
        }
        public AsociacionTCPrincipal()
        {
            InitializeComponent();
        }

        public void obtenerTarjetasCliente(Int32 id)
        {
            DataTable tarjetas = new DataTable();
            tarjetas = GestorDeSistema.obtenerTarjetasCliente(id);
            foreach (DataRow tarjeta in tarjetas.Rows)
            {
                dgvTarjetas.Rows.Add(
                tarjeta.ItemArray[0],
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
          public void deshabilitarModificaciones()
        {
            
            VincularTarjetabutton.Enabled = false;
            desvincularTarjetabutton.Enabled = false;
            NuevaTarjetabutton.Enabled = false;
        }

          private void volverButton_Click(object sender, EventArgs e)
          {
              Owner.Show();
              this.Hide();
          }

          private void desvincularTarjetabutton_Click(object sender, EventArgs e)
          {
              string numeroTarjeta;
            if (dgvTarjetas.SelectedRows.Count == 1)
            {
                numeroTarjeta=dgvTarjetas.SelectedRows[0].Cells["Primeros_Numeros_Tarjeta"].Value.ToString(); //aca iria la union de los primeros numeros y los ultimos 4 o 3 encriptados..
                dgvTarjetas.Rows.Clear();
                GestorDeSistema.desvincularTarjeta(numeroTarjeta);
                obtenerTarjetasCliente(idCliente);
                    dgvTarjetas.Update();
             }
            else
            {
                MessageBox.Show("Seleccione la Tarjeta que quiere Desvincular", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
                return;
            }
          
       
        }

          private void VincularTarjetabutton_Click(object sender, EventArgs e)
          {
              string numeroTarjeta;
              if (dgvTarjetas.SelectedRows.Count == 1)
              {
                  numeroTarjeta = dgvTarjetas.SelectedRows[0].Cells["Primeros_Numeros_Tarjeta"].Value.ToString(); //aca iria la union de los primeros numeros y los ultimos 4 o 3 encriptados..
                  dgvTarjetas.Rows.Clear();
                  GestorDeSistema.vincularTarjeta(numeroTarjeta);
                  obtenerTarjetasCliente(idCliente);
                  dgvTarjetas.Update();
              }
              else
              {
                  MessageBox.Show("Seleccione la Tarjeta que quiere vincular", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                  return;
              }
          }

        
    }

          }

        

     

        
    

