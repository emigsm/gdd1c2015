﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico
{
    public partial class SeleccionRol : Form
    {
        string username;
        
        public SeleccionRol(string usernameP)
        {
            InitializeComponent();
            username = usernameP;
            DataTable roles = GestorDeSistema.obtenerRolesLogin(usernameP);
            cmbRol.DisplayMember = "Rol_Nombre";
            cmbRol.ValueMember = "Rol_Cod";
            cmbRol.DataSource = roles;
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int rol = Convert.ToInt32(cmbRol.SelectedValue.ToString());
            Principal frmPrincipal = new Principal(rol, username);
            frmPrincipal.Show(this);
            this.Hide();
        }

        private void cmbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnSeleccionar.PerformClick();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
