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
    public partial class AltaTarjeta : Form
    {
        public AltaTarjeta(Int32 clienteId)
        {
            InitializeComponent();
            DataTable emisores = GestorDeSistema.obtenerEmisoresTarjetas();
            EmisorTarjetaCombobox.DisplayMember = "Tarjeta_Emisor_Descripcion";
            EmisorTarjetaCombobox.ValueMember = "Row";
            EmisorTarjetaCombobox.DataSource = emisores;
            clienteIDValorLabel.Text = clienteId.ToString();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void DarAltaBtn_Click(object sender, EventArgs e)
        {
            GestorDeSistema.altaTarjeta(EmisorTarjetaCombobox.SelectedValue.ToString(), Convert.ToInt32(clienteIDValorLabel.Text));
        }
    }
}
