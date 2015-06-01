using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Retiros
{
    public partial class RetirosPrincipal : Form
    {
        public RetirosPrincipal(string username)
        {
            InitializeComponent();

            InitializeComponent();
            string usuario = username;
            DataTable cuenta = GestorDeSistema.obtenerCuentasDeUsuario(usuario);
            cuentacomboBox.DisplayMember = "Cuenta_Numero";
            cuentacomboBox.ValueMember = "Cuenta_Numero";
            cuentacomboBox.DataSource = cuenta;

            DataTable tiposDoc = GestorDeSistema.obtenerTiposDoc();
            tipoDocComboBox.DisplayMember = "Documento_Tipo_Descripcion";
            tipoDocComboBox.ValueMember = "Documento_Tipo_Codigo";
            tipoDocComboBox.DataSource = tiposDoc;

       
            fechaValorLabel.Text = Convert.ToString(GestorDeSistema.solicitarFecha());


        }

        private void RetirosPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
