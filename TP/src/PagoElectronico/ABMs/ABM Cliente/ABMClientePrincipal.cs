using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.ABMs.ABM_Cliente
{
    public partial class ABMClientePrincipal : Form
    {
        public  ABMClientePrincipal()
        {
            
            InitializeComponent();
            DataTable tiposDoc = GestorDeSistema.obtenerTiposDoc();
            tipoDocComboBox.DisplayMember = "Documento_Tipo_Descripcion";
            tipoDocComboBox.ValueMember = "Documento_Tipo_Codigo";
            tipoDocComboBox.DataSource = tiposDoc;


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();

            prubaDoc1.Text = nroDocTextBox.Text.GetType().ToString();
            string tipoDoc = tipoDocComboBox.SelectedValue.ToString();
            string nroDoc = nroDocTextBox.Text;
            prubaDoc1.Text = nroDocTextBox.Text.Length.ToString();


            DataTable clientesEncontrados = GestorDeSistema.buscarClientes(nombreClienteTextBox.Text,ApellidoClienteTextBox.Text,tipoDoc,nroDoc,mailTextBox.Text);

            if (clientesEncontrados.Rows.Count > 0)
            {
                foreach (DataRow clienteEncontrado in clientesEncontrados.Rows)
                {
                    dgvClientes.Rows.Add(
                    clienteEncontrado.ItemArray[0],
                    clienteEncontrado.ItemArray[1],
                    clienteEncontrado.ItemArray[2],
                    clienteEncontrado.ItemArray[3],
                    clienteEncontrado.ItemArray[4],
                    clienteEncontrado.ItemArray[5],
                    clienteEncontrado.ItemArray[6],
                    clienteEncontrado.ItemArray[7],
                    clienteEncontrado.ItemArray[8],
                    clienteEncontrado.ItemArray[9],
                    clienteEncontrado.ItemArray[10],
                    clienteEncontrado.ItemArray[11],
                    clienteEncontrado.ItemArray[12],
                    clienteEncontrado.ItemArray[13],
                    clienteEncontrado.ItemArray[14]
                        );
                }
                dgvClientes.Update();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se encontraron resultados con los datos proporcionados");
            }
        }

        private void nombreClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarClienteButton_Click(object sender, EventArgs e)
        {

        }

        private void ABMClientePrincipal_Load(object sender, EventArgs e)
        {

         
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            dgvClientes.ClearSelection();
        }

      
    }
}
