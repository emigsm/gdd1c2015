using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;
using PagoElectronico.Operaciones.Asociacion_TC;

namespace PagoElectronico.ABMs.ABM_Cliente
{
    public partial class ModificacionCliente : Form
    {
        private Int32 idCliente { get; set; }
        private string apellidoCliente { get; set;}
        private string nombreCliente { get; set; }
        
        public ModificacionCliente(Int32 id, string nombre, string apellido, int tipoDoc, Decimal nroDoc, string mail, int pais, string domCalle,
                                        String domNumero, String domPiso, string domDepto,
                                        string localidad, string nacionalidad, DateTime fechaNac, bool habilitado)
        {
            InitializeComponent();
            idCliente = id;
            apellidoCliente = apellido;
            nombreCliente = nombre;
            DataTable tiposDoc = GestorDeSistema.obtenerTiposDoc();
            TipoDcomboBox.DisplayMember = "Documento_Tipo_Descripcion";
            TipoDcomboBox.ValueMember = "Documento_Tipo_Codigo";
            TipoDcomboBox.DataSource = tiposDoc;

            DataTable paises = GestorDeSistema.obtenerPaises();
            PaiscomboBox.DisplayMember = "Pais_Descripcion";
            PaiscomboBox.ValueMember = "Pais_Cod";
            PaiscomboBox.DataSource = paises;

            IDLabelValor.Text = id.ToString();
            ApellidoClitextBox.Text = apellido;
            NombreClitextBox.Text = nombre;
            TipoDcomboBox.SelectedValue = tipoDoc;
            NroDocClitextBox.Text = nroDoc.ToString();
            MailtextBox.Text = mail;
            PaiscomboBox.SelectedValue = pais;
            DomicilioCalletextBox.Text = domCalle;
            DomNumerotextBox.Text = domNumero.ToString();
            DomicilioPisoTextBox.Text = domPiso.ToString();
            DomicilioDeptotextBox.Text = domDepto;
            LocalidadtextBox.Text = localidad;
            NacionalidadtextBox.Text = nacionalidad;
            fechaNacimientodateTimePicker.Value = fechaNac;
            habilitadocheckBox.Checked = habilitado;
            establecerLongMaximaCampos();
            if (habilitadocheckBox.Checked == true)
            {
                habilitadocheckBox.Text = "Habilitado";
            }
            else
            {
                habilitadocheckBox.Text = "Inhabilitado";
            }



        }



        private void VolverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();

        }

        private void guardarBoton_Click(object sender, EventArgs e)
        {
            if (GestorDeSistema.validarDisponibilidadMail(MailtextBox.Text,idCliente) == "0")
            {
                MessageBox.Show("el Mail ingresado ya Existe en la base de datos, lo sentimos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
        
            
            if (NroDocClitextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar el Nro de Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                return;
            }
            if (MailtextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar un mail", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (GestorDeSistema.validarDisponibilidadNroTipoDoc(Convert.ToInt32(TipoDcomboBox.SelectedValue.ToString()), Convert.ToDecimal(NroDocClitextBox.Text), idCliente) == "0")
            {
                MessageBox.Show("Su  Nro de Documento ya existe,verifique que  haya  ingresado los datos  correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (NombreClitextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar el Nombre de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (ApellidoClitextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar el Apellido de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if ((DomicilioCalletextBox.Text == "") || (DomNumerotextBox.Text == ""))
            {
                MessageBox.Show("por favor ingrese su Domicilio", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToDateTime(GestorDeSistema.solicitarFecha()) < Convert.ToDateTime(fechaNacimientodateTimePicker.Value))
            {
                MessageBox.Show("La fecha de nacimiento es mayor a la fecha actual de sistema, por favor verifique los datos ingresados", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GestorDeSistema.modificarCliente(Convert.ToInt32(IDLabelValor.Text), NombreClitextBox.Text, ApellidoClitextBox.Text, Convert.ToInt32(TipoDcomboBox.SelectedValue.ToString()),
                                         Convert.ToDecimal(NroDocClitextBox.Text), MailtextBox.Text, Convert.ToInt32(PaiscomboBox.SelectedValue.ToString()), DomicilioCalletextBox.Text,
                                         (DomNumerotextBox.Text),(DomicilioPisoTextBox.Text), DomicilioDeptotextBox.Text,
                                         LocalidadtextBox.Text, NacionalidadtextBox.Text, fechaNacimientodateTimePicker.Value, habilitadocheckBox.Checked);

            MessageBox.Show("El cliente ha sido modificado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Owner.Show();
            this.Hide();
        }

        private void habilitadocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (habilitadocheckBox.Checked == true)
            {
                habilitadocheckBox.Text = "Habilitado";
            }
            else
            {
                habilitadocheckBox.Text = "Inhabilitado";
            }
        }

        private void establecerLongMaximaCampos()
        {
            ApellidoClitextBox.MaxLength = 255;
            NombreClitextBox.MaxLength = 255;
            NroDocClitextBox.MaxLength= sizeof(Decimal);
            MailtextBox.MaxLength = 255;
            DomicilioCalletextBox.MaxLength = 255;
            DomNumerotextBox.MaxLength = sizeof(Decimal);
            DomicilioPisoTextBox.MaxLength=sizeof(Decimal);
            DomicilioDeptotextBox.MaxLength = 10;
            LocalidadtextBox.MaxLength = 60;
            NacionalidadtextBox.MaxLength = 60;
        }



//--------------------------------------VALIDACIONES----TEXTBOX-------------------------------------------------------------------------------
        private void NombreClitextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&&!(char.IsSeparator(e.KeyChar)))
            {

              
                MessageBox.Show("el campo Nombre no puede tener numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
           
            }
        }
        private void completaDomicilio()
        {
            if ((DomicilioCalletextBox.Text == "") || (DomNumerotextBox.Text == ""))
            {
                MessageBox.Show("por favor ingrese su Domicilio", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void ApellidoClitextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&&!(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("el campo Apellido no puede tener numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void NroDocClitextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            

       }

        private void DomNumerotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo Nro Documento Solo permite Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void DomicilioPisoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo domicilio piso solo permite Numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void DomicilioDeptotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NacionalidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("el campo Nacionalidad no puede tener numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void NombreClitextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void ApellidoClitextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void NroDocClitextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void MailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DomNumerotextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void DomicilioPisoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void LocalidadtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void DomicilioDeptotextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void DomicilioCalletextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void PaiscomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void TipoDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoDcomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void MailtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void NacionalidadtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void fechaNacimientodateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {

        }

        private void modificarTarjetasbutton_Click(object sender, EventArgs e)
        {
            AsociacionTCPrincipal tarjetas = new AsociacionTCPrincipal(nombreCliente, apellidoCliente, idCliente);
            tarjetas.Show(this);
            this.Hide();
        }
    }
}
