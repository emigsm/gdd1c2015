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
        private DataTable tarjetas {get;set;}
       
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


        public AsociacionTCPrincipal(string username)
        {
            InitializeComponent();
            DataTable clientesEncontrados = GestorDeSistema.buscarCliente(username);

            if (clientesEncontrados.Rows.Count > 0)
            {

                tarjetaApellidoCliLabel.Text = clientesEncontrados.Rows[0].ItemArray[0].ToString();
                tarjetaNombreCliLabel.Text = clientesEncontrados.Rows[0].ItemArray[1].ToString();
                tarjetaCliIdLabel.Text = clientesEncontrados.Rows[0].ItemArray[2].ToString();
                idCliente = Convert.ToInt32(tarjetaCliIdLabel.Text);


            }
            obtenerTarjetasCliente(idCliente);
        }


        public void obtenerTarjetasCliente(Int32 id)
        {
            //DataTable tarjetas = new DataTable();
            
            this.tarjetas = GestorDeSistema.obtenerTarjetasCliente(id);
            
            foreach (DataRow tarjeta in tarjetas.Rows)
            {
                dgvTarjetas.Rows.Add(
                
                tarjeta.ItemArray[1],
                (Utilidades.Cifrado.Cifrador.Cifrar(tarjeta.ItemArray[2].ToString())),
                tarjeta.ItemArray[3],
                tarjeta.ItemArray[4],
                tarjeta.ItemArray[5],
                tarjeta.ItemArray[6],
                tarjeta.ItemArray[7]
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

                  int indice = dgvTarjetas.Rows.IndexOf(dgvTarjetas.SelectedRows[0]);
                  dgvTarjetas.Rows.Clear();
                  numeroTarjeta = tarjetas.Rows[indice].ItemArray[0].ToString();

                  if (Convert.ToBoolean(tarjetas.Rows[indice].ItemArray[7].ToString()) == true)
                  {
                      GestorDeSistema.desvincularTarjeta(numeroTarjeta);
                      MessageBox.Show("La tarjeta ha sido desvinculada Efectivamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      obtenerTarjetasCliente(idCliente);
                      dgvTarjetas.Update();
                  }
                  else
                  {
                      MessageBox.Show("La tarjeta ya está desvinculada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      obtenerTarjetasCliente(idCliente);
                      dgvTarjetas.Update();
                  }

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

                  int indice = dgvTarjetas.Rows.IndexOf(dgvTarjetas.SelectedRows[0]);
                  dgvTarjetas.Rows.Clear();
                  numeroTarjeta = tarjetas.Rows[indice].ItemArray[0].ToString();

                  if (Convert.ToBoolean(tarjetas.Rows[indice].ItemArray[7].ToString()) == false)
                  {
                      GestorDeSistema.vincularTarjeta(numeroTarjeta);
                      MessageBox.Show("La tarjeta ha sido vinculada Efectivamente con el cliente.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      obtenerTarjetasCliente(idCliente);
                      dgvTarjetas.Update();
                  }
                  else
                  {
                      MessageBox.Show("La tarjeta ya está vinculada con el Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      obtenerTarjetasCliente(idCliente);
                      dgvTarjetas.Update();
                  }

              }
              else
              {
                  MessageBox.Show("Seleccione la Tarjeta que quiere vincular", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                  return;
              }
          }
          private void NuevaTarjetabutton_Click(object sender, EventArgs e)
          {
              if (idCliente != 0)
              {
                  AltaTarjeta altaTarjeta = new AltaTarjeta(idCliente);
                  this.Hide();
                  altaTarjeta.ShowDialog(this);

                  this.actualizarLista();
              }
              else 
              {
                  System.Windows.Forms.MessageBox.Show("No posee datos de Cliente asociados, por favor consulte a un administrador.");
              }
              


          }

          public void actualizarLista()
          {
              
              dgvTarjetas.Update();
              dgvTarjetas.Rows.Clear();
              obtenerTarjetasCliente(idCliente);
          }

          private void AsociacionTCPrincipal_Load(object sender, EventArgs e)
          {
              dgvTarjetas.Rows.Clear();
              obtenerTarjetasCliente(idCliente);
          }

        

          
          
        
    }

          }

        

     

        
    

