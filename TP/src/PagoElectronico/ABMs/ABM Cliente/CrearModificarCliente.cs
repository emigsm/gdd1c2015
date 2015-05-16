using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABMs.ABM_Cliente
{
    public partial class CrearModificarCliente : Form
    {
        public CrearModificarCliente()
        {
            InitializeComponent();
        }

        public void dehabilitarModificacion()
        {
            Guardarbutton.Enabled = false;
        }
    }

  

}
