using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

using PagoElectronico.ABMs.ABM_de_Usuario;

namespace PagoElectronico.ABMs.ABM_Cliente
{
    public partial class AltaCliente : Form
    {

        bool provenienteDeUsuario;
        string username, password, preguntaSecreta, respuestaSecreta;
        int rol;
              
        public AltaCliente()
        {
            InitializeComponent();
            DataTable tiposDoc = GestorDeSistema.obtenerTiposDoc();
            TipoDcomboBox.DisplayMember = "Documento_Tipo_Descripcion";
            TipoDcomboBox.ValueMember = "Documento_Tipo_Codigo";
            TipoDcomboBox.DataSource = tiposDoc;

            DataTable paises = GestorDeSistema.obtenerPaises();
            PaiscomboBox.DisplayMember = "Pais_Descripcion";
            PaiscomboBox.ValueMember = "Pais_Cod";
            PaiscomboBox.DataSource = paises;

            provenienteDeUsuario = false;

            establecerLongitudesMaximas();
         }

        public void altaProvenienteDeUsuario(string usernameP, string passwordP, int rolP, string preguntaSecretaP, string respuestaSecretaP)
        {
            provenienteDeUsuario = true;
            username = usernameP;
            password = passwordP;
            rol = rolP;
            preguntaSecreta = preguntaSecretaP;
            respuestaSecreta = respuestaSecretaP;
            establecerLongitudesMaximas();
        }

        private void Crearbutton_Click(object sender, EventArgs e)
        {     
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();

        }

        private void CrearClienteBtn_Click(object sender, EventArgs e)
        {
            if (GestorDeSistema.validarDisponibilidadMail(MailtextBox.Text,0) == "0")
            {
                MessageBox.Show("el Mail ingresado ya Existe en la base de datos, lo sentimos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (NombreClitextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar el Nombre de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (ApellidoNuevoClitextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar el Apellido de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (NroDocClitextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar el Nro de Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    
                return;
            }
            if (GestorDeSistema.validarDisponibilidadNroTipoDoc(Convert.ToInt32(TipoDcomboBox.SelectedValue.ToString()), Convert.ToDecimal(NroDocClitextBox.Text),0) == "0")
            {
                MessageBox.Show("Su  Nro de Documento ya existe,verifique que  haya  ingresado los datos  correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (MailtextBox.Text == "")
            {
                MessageBox.Show("Es obligatorio Insertar un mail", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

            GestorDeSistema.crearCliente(NombreClitextBox.Text, ApellidoNuevoClitextBox.Text, Convert.ToInt32(TipoDcomboBox.SelectedValue.ToString()),
                                         Convert.ToDecimal(NroDocClitextBox.Text), MailtextBox.Text, Convert.ToDecimal(PaiscomboBox.SelectedValue.ToString()), DomicilioCalletextBox.Text,
                                         DomNumerotextBox.Text, DomicilioPisoTextBox.Text, DomicilioDeptotextBox.Text,
                                         LocalidadtextBox.Text, NacionalidadtextBox.Text, fechaNacimientodateTimePicker.Value);
            int clienteID = GestorDeSistema.obtenerClienteRecienCreado();

            if (provenienteDeUsuario == true) //esto es si el cliente viene a partir de la creacion de un usuario nuevo
            {

                GestorDeSistema.altaUsuario(username, password, rol, preguntaSecreta, respuestaSecreta, clienteID);
                System.Windows.Forms.MessageBox.Show("El Cliente ha sdo dado de alta. También se registro como Usuario");

            }
            else
            { 
                    AltaUsuario nuevoUsuario = new AltaUsuario();
                    nuevoUsuario.altaDesdeCliente(clienteID);
                    this.Hide();
                    nuevoUsuario.ShowDialog(this);
                    
           
            }
            Owner.Show();
            this.Hide();
        }
//------------------------------------------------------VALIDACIONES------------------------------------------------------------------------------
        private void NombreClitextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&&!(char.IsSeparator(e.KeyChar)))
            {


                MessageBox.Show("el campo Nombre no puede tener numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void completaDomicilio()
        {
            if ((DomicilioCalletextBox.Text == "")||(DomNumerotextBox.Text==""))
            {
                MessageBox.Show("por favor ingrese su Domicilio", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void ApellidoNuevoClitextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&&!(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("el campo Apellido no puede tener numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
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

        private void DomicilioPisoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo domicilio piso solo permite Numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void DomNumerotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("El campo domicilio numero solo permite Numeros", "Problema de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void NombreClitextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData== Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void ApellidoNuevoClitextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void TipoDcomboBox_KeyDown(object sender, KeyEventArgs e)
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

        private void MailtextBox_KeyDown(object sender, KeyEventArgs e)
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

        private void DomicilioCalletextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
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

        private void DomicilioDeptotextBox_KeyDown(object sender, KeyEventArgs e)
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


        private void establecerLongitudesMaximas()
        {
            NombreClitextBox.MaxLength = 255;
            ApellidoNuevoClitextBox.MaxLength = 255;
            NroDocClitextBox.MaxLength = sizeof(Decimal);
            MailtextBox.MaxLength = 255;
            DomicilioCalletextBox.MaxLength = 255;
            DomNumerotextBox.MaxLength = sizeof(Decimal);
            DomicilioPisoTextBox.MaxLength = sizeof(Decimal);
            DomicilioDeptotextBox.MaxLength = 10;
            LocalidadtextBox.MaxLength = 60;
            NacionalidadtextBox.MaxLength = 60;
        }
   
    }

  

}
