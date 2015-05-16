using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Depositos
{
    public partial class DepositosPrincipal : Form
    {
        public DepositosPrincipal(string username)
        {
            InitializeComponent();
            string usuario = username;
            DataTable cuenta = GestorDeSistema.obtenerCuentasDeUsuario(usuario);
            cmbCuenta.DisplayMember = "Cuenta_Numero";
            cmbCuenta.ValueMember = "Cuenta_Numero";
            cmbCuenta.DataSource = cuenta;
        }
                
    }
}
