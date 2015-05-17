using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utilidades.ModeloSistema;

namespace PagoElectronico.ABMs.ABM_Cliente
{
    public partial class ModificacionCliente : Form
    {
        public ModificacionCliente(Int32 id, string nombre, string apellido, int tipoDoc, int nroDoc, string mail, int pais, string domCalle,
                                        Decimal domNumero, Decimal domPiso, string domDepto,
                                        string localidad, string nacionalidad, DateTime fechaNac, bool habilitado)
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
            
            
            GestorDeSistema.modificarCliente(Convert.ToInt32(IDLabelValor.Text), NombreClitextBox.Text, ApellidoClitextBox.Text, Convert.ToInt32(TipoDcomboBox.SelectedValue.ToString()),
                                         Convert.ToInt32(NroDocClitextBox.Text), MailtextBox.Text, Convert.ToInt32(PaiscomboBox.SelectedValue.ToString()), DomicilioCalletextBox.Text,
                                         Convert.ToDecimal(DomNumerotextBox.Text), Convert.ToInt32(DomicilioPisoTextBox.Text), DomicilioDeptotextBox.Text,
                                         LocalidadtextBox.Text, NacionalidadtextBox.Text, fechaNacimientodateTimePicker.Value, habilitadocheckBox.Checked);
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



        private Boolean validarCampos()
        {
            if ((validarSoloTexto(NombreClitextBox, 255) |
            validarSoloTexto(ApellidoClitextBox, 255) |
            validarSoloTexto(MailtextBox, 250) |
            validarSoloDigitos(NroDocClitextBox, sizeof(Decimal)) |
            validarSoloTexto(DomicilioCalletextBox, 255) |
            validarSoloDigitos(DomNumerotextBox, sizeof(Decimal)) |
            validarSoloDigitos(DomicilioPisoTextBox, sizeof(Decimal)) |
            validarSoloTexto(DomicilioPisoTextBox, 10) |
            validarSoloTexto(LocalidadtextBox, 255) |
            validarSoloTexto(NacionalidadtextBox, 255)) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
            /*validarSoloTexto(NombreClitextBox,255);
            validarSoloTexto(ApellidoClitextBox,255);
            validarSoloTexto(MailtextBox,250);
            validarSoloDigitos(NroDocClitextBox,sizeof(Decimal));
            validarSoloTexto(DomicilioCalletextBox, 255);
            validarSoloDigitos(DomNumerotextBox, sizeof(Decimal));
            validarSoloDigitos(DomicilioPisoTextBox,sizeof(Decimal));
            validarSoloTexto(DomicilioPisoTextBox, 10);
            validarSoloTexto(LocalidadtextBox, 255);
            validarSoloTexto(NacionalidadtextBox, 255);*/
        }

        private Boolean validarSoloTexto(TextBox text,int longitud)
        {
            for (Int32 i = 0; i == text.Text.Length; i++)
            {
                if((text.Text[i].ToString()))
                {

                }
            }
                return true;
        }
        private Boolean validarSoloDigitos(TextBox text,int longitud)
        {
            return true;
        }
   
    }

  

}
