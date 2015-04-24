using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ConexionDB;
using PagoElectronico.Utilidades.Cifrado;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int usuarioid = GestorDeSistema.loginUsuario(txtUsuario.Text, Cifrador.Cifrar(txtContrasena.Text));
            if (usuarioid == 1 || usuarioid == 2 || usuarioid == 3)
            {
                System.Windows.Forms.MessageBox.Show("Login Correcto");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Fallo el Login");
            }
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConexionDB.DesconectarDB();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnIngresar.PerformClick();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnIngresar.PerformClick();
            }
        }

    }
}
