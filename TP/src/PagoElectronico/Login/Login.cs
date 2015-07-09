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
using PagoElectronico.ABMs.ABM_de_Usuario;

namespace PagoElectronico
{
    public partial class Login : Form
    {
        private int cantidadIntentos;

        public Login()
        {
            InitializeComponent();
            GestorDeSistema.insertarFechaFuncionamiento(Settings1.Default.Fecha_de_Sistema);
            cantidadIntentos = 0;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool validacionesCorrectas = validaciones();
            if (validacionesCorrectas == true)
            {
                bool existeUsuario = Convert.ToBoolean(GestorDeSistema.loginUsuario(txtUsuario.Text, Cifrador.Cifrar(txtContrasena.Text)));
                bool poseeRolesActivos = Convert.ToBoolean(GestorDeSistema.poseeRolesActivos(txtUsuario.Text));
                int cantidadRoles = GestorDeSistema.cantidadRoles(txtUsuario.Text);

                if (existeUsuario == true && poseeRolesActivos == true)
                {
                    GestorDeSistema.logLogin(txtUsuario.Text, false, cantidadIntentos + 1);  /*Agrega el log de logueo correcto a la base*/
                    /*Login Correcto como ADMIN*/
                    cantidadIntentos = 0;
                    if (cantidadRoles > 1)
                    {
                        /*Tiene mas de un Rol*/
                        SeleccionRol frmSeleccionRol = new SeleccionRol(txtUsuario.Text);
                        frmSeleccionRol.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        /*Tiene un solo Rol*/
                        int rolCod = GestorDeSistema.obtenerRol(txtUsuario.Text);
                        Principal frmPrincipal = new Principal(rolCod, txtUsuario.Text);
                        frmPrincipal.Show(this);
                        this.Hide();
                    }
                }
                else
                {
                    GestorDeSistema.logLogin(txtUsuario.Text, true, cantidadIntentos + 1);  /*Agrega el log de logueo incorrecto a la base*/
                    /*Login incorrecto*/
                    cantidadIntentos++;
                    if (cantidadIntentos >= 3)
                    {
                        GestorDeSistema.inhabilitarUsuario(txtUsuario.Text);
                        System.Windows.Forms.MessageBox.Show("Maximo superado. Su cuenta queda INHABILITADA");
                        ConexionDB.DesconectarDB();
                        Application.Exit();
                    }
                    else
                    {
                        if (poseeRolesActivos == false)
                        {
                            System.Windows.Forms.MessageBox.Show("No posee roles habilitados para ingresar. \nIntentos " + this.cantidadIntentos.ToString() + " de 3");

                        }
                        else 
                        {
                            System.Windows.Forms.MessageBox.Show("Datos no válidos o usuario bloqueado. \nIntentos " + this.cantidadIntentos.ToString() + " de 3");

                        }
                    }

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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            AltaUsuario nuevoUsuario = new AltaUsuario();
            nuevoUsuario.altaDeLogin();
            nuevoUsuario.Show(this);
            this.Hide();
        }

        private bool validaciones()
        {
            if (txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Nombre de Usuario o Password en blanco, por favor verifique.");
                return false;
            }
            
            return true;
        }

    }
}
