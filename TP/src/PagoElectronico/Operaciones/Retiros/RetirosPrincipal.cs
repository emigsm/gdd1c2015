﻿using System;
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
        string usuario { get; set; }

        public RetirosPrincipal(string username)
        {


            InitializeComponent();
            usuario = username;
            DataTable cuenta = GestorDeSistema.obtenerCuentasDeUsuario(usuario);
            cuentacomboBox.DisplayMember = "Cuenta_Numero";
            cuentacomboBox.ValueMember = "Cuenta_Numero";
            cuentacomboBox.DataSource = cuenta;

            DataTable tiposDoc = GestorDeSistema.obtenerTiposDoc();
            tipoDocComboBox.DisplayMember = "Documento_Tipo_Descripcion";
            tipoDocComboBox.ValueMember = "Documento_Tipo_Codigo";
            tipoDocComboBox.DataSource = tiposDoc;

            nroDoctextBox.MaxLength = 16;
            ImportetextBox.MaxLength = 16;

            fechaValorLabel.Text = Convert.ToString(GestorDeSistema.solicitarFecha());

            establecerLongitudesMaximas();


        }

        private void establecerLongitudesMaximas()
        {
            ImportetextBox.MaxLength = sizeof(Decimal);
            nroDoctextBox.MaxLength = sizeof(Decimal);
        }

        private void RetirosPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void GenerarRetirobutton_Click(object sender, EventArgs e)
        {
            string mensaje = GestorDeSistema.efectuarRetiro(Convert.ToDecimal(cuentacomboBox.SelectedValue.ToString()),
                                                            Convert.ToDecimal(ImportetextBox.Text),
                                                            Convert.ToDecimal(tipoDocComboBox.SelectedValue.ToString()),
                                                            Convert.ToDecimal(nroDoctextBox.Text),Convert.ToDateTime(fechaValorLabel.Text), usuario);


            MessageBox.Show(mensaje, "Resultado Operacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return;
        }

        private void VOLVERbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }


//-----------------------------------------------------VALIDACIONES------------------------------------------------------------------------------//
        private void cuentacomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void ImportetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void tipoDocComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void nroDoctextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void ImportetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Importe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nroDoctextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo Numero de Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
