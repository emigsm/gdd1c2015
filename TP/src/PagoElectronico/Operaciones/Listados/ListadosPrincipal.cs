using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.Operaciones.Listados
{
    public partial class ListadosPrincipal : Form
    {
        public ListadosPrincipal()
        {
            InitializeComponent();

            DataTable dtcmbTrimestre = new DataTable();
            dtcmbTrimestre.Columns.Add("DisplayMember");
            dtcmbTrimestre.Columns.Add("ValueMember");
            dtcmbTrimestre.Rows.Add("Primero", 1);
            dtcmbTrimestre.Rows.Add("Segundo", 2);
            dtcmbTrimestre.Rows.Add("Tercero", 3);
            dtcmbTrimestre.Rows.Add("Cuarto", 4);
            cmbTrimestre.DataSource = dtcmbTrimestre;
            cmbTrimestre.DisplayMember = "DisplayMember";
            cmbTrimestre.ValueMember = "ValueMember";

            DataTable dtcmbAnio = new DataTable();
            dtcmbAnio.Columns.Add("DisplayMember");
            dtcmbAnio.Columns.Add("ValueMember");
            dtcmbAnio.Rows.Add("2013", "2013");
            dtcmbAnio.Rows.Add("2014", "2014");
            dtcmbAnio.Rows.Add("2015", "2015");
            dtcmbAnio.Rows.Add("2016", "2016");
            cmbAnio.DataSource = dtcmbAnio;
            cmbAnio.DisplayMember = "DisplayMember";
            cmbAnio.ValueMember = "ValueMember";

            DataTable dtcmbListados = new DataTable();
            dtcmbListados.Columns.Add("DisplayMember");
            dtcmbListados.Columns.Add("ValueMember");
            dtcmbListados.Rows.Add("Clientes con cuentas inhabilitadas por no pagar los costos de transacción", 1);
            dtcmbListados.Rows.Add("Cliente con mayor cantidad de comisiones facturadas en todas sus cuentas", 2);
            dtcmbListados.Rows.Add("Clientes con mayor cantidad de transacciones realizadas entre cuentas propias", 3);
            dtcmbListados.Rows.Add("Países con mayor cantidad de movimientos", 4);
            dtcmbListados.Rows.Add("Total facturado para los distintos tipos de cuentas", 5);
            cmbListados.DataSource = dtcmbListados;
            cmbListados.DisplayMember = "DisplayMember";
            cmbListados.ValueMember = "ValueMember";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int anioSeleccionado = Convert.ToInt32(cmbAnio.SelectedValue);
            int trimestreSeleccionado = Convert.ToInt32(cmbTrimestre.SelectedValue);
            
            switch (Convert.ToInt32(cmbListados.SelectedValue))
            { 
                case 1:
                    break;
                case 2:
                    DataTable listado2 = GestorDeSistema.listado2(anioSeleccionado, trimestreSeleccionado);
                    if (listado2.Rows.Count > 0)
                    {
                       dgvResultados.DataSource = listado2;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No se encontraron operaciones con los datos proporcionados");
                    } 
                    break;

                case 3:
                    DataTable listado3 = GestorDeSistema.listado3(anioSeleccionado, trimestreSeleccionado);
                    if (listado3.Rows.Count > 0)
                    {
                        dgvResultados.DataSource = listado3;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No se encontraron operaciones con los datos proporcionados");
                    } 


                    break;
                case 4:
                    DataTable listado4I = GestorDeSistema.listado4I(anioSeleccionado, trimestreSeleccionado);
                    DataTable listado4E = GestorDeSistema.listado4E(anioSeleccionado, trimestreSeleccionado);
                    listado4E.Merge(listado4I);
                    if (listado4E.Rows.Count > 0)
                    {
                        dgvResultados.DataSource = listado4E;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No se encontraron operaciones con los datos proporcionados");
                    } 
                    break;
                case 5:
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = null;
            dgvResultados.Update();
        }
    }
}
