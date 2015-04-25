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
        private int cantidadIntentos;

        public Login()
        {
            InitializeComponent();
            cantidadIntentos = 1;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int rolCod = GestorDeSistema.loginUsuario(txtUsuario.Text, Cifrador.Cifrar(txtContrasena.Text));
            if (rolCod == 1)
            {
                System.Windows.Forms.MessageBox.Show("Login Correcto como ADMIN");
            }
            else if (rolCod == 2)
            {
                System.Windows.Forms.MessageBox.Show("Login Correcto como CLIENTE");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Login Incorrecto");
                cantidadIntentos++;
                if (cantidadIntentos > 3)
                {
                    System.Windows.Forms.MessageBox.Show("Maximo superado. Su cuenta queda INHABILITADA");
                }
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
