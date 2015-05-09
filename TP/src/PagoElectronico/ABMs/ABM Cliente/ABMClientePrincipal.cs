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
        private  ABMClientePrincipal()
        {
            
            InitializeComponent();
            DataTable tiposDoc = GestorDeSistema.obtenerTiposDoc();
            tipoDocComboBox.DisplayMember = "Documento_Tipo_Descripcion";
            tipoDocComboBox.ValueMember = "Documento_Tipo_Descripcion";
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
            DataTable clientesEncontrados = GestorDeSistema.buscarClientes(nombreClienteTextBox.Text,ApellidoClienteTextBox.Text,tipoDocComboBox.SelectedItem,nroDocTextBox.Text,mailTextBox.Text);
        }

        private void nombreClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
