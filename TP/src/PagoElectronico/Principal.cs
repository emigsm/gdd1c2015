using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PagoElectronico.Utilidades.ModeloSistema;
using PagoElectronico.ABMs.ABM_Cliente;
using PagoElectronico.ABMs.ABM_Cuenta;
using PagoElectronico.ABMs.ABM_de_Usuario;
using PagoElectronico.ABMs.ABM_Rol;
using PagoElectronico.Operaciones.Asociacion_TC;
using PagoElectronico.Operaciones.Consulta_Saldos;
using PagoElectronico.Operaciones.Depositos;
using PagoElectronico.Operaciones.Facturacion;
using PagoElectronico.Operaciones.Listados;
using PagoElectronico.Operaciones.Retiros;
using PagoElectronico.Operaciones.Transferencias;

namespace PagoElectronico
{
    public partial class Principal : Form
    {
        private int rolCod;

        string username;

        public Principal(int rolCodP, string usernameP)
        {
            InitializeComponent();
            username = usernameP;
            rolCod = rolCodP;
            DataTable funcionalidades = GestorDeSistema.obtenerFuncionalidades(rolCod);
            cmbFuncionalidades.DisplayMember = "Funcionalidad_Descripcion";
            cmbFuncionalidades.ValueMember = "Funcionalidad_Descripcion";
            cmbFuncionalidades.DataSource = funcionalidades;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string rol = cmbFuncionalidades.SelectedValue.ToString();
            switch (rol)
            {
                case "ABM de Rol":
                    ABMRolPrincipal frmABMRolPrincipal = new ABMRolPrincipal();
                    frmABMRolPrincipal.Show(this);
                    this.Hide();
                    break;

                case "ABM de Usuario":
                    ABMUsuarioPrincipal frmABMUsuarioPrincipal = new ABMUsuarioPrincipal();
                    frmABMUsuarioPrincipal.Show(this);
                    this.Hide();
                    break;

                case "ABM de Clientes":
                    ABMClientePrincipal frmABMClientePrincipal = new ABMClientePrincipal();
                    frmABMClientePrincipal.Show(this);
                    this.Hide();
                    break;

                case "ABM de Cuenta":
                    ABMCuentaPrincipal frmABMCuentaPrincipal = new ABMCuentaPrincipal(rolCod, username);
                    frmABMCuentaPrincipal.Show(this);
                    this.Hide();
                    break;

                case "Asociar/Desasociar Tarjetas de Credito":
                    AsociacionTCPrincipal frmAsociacionTCPrincipal = new AsociacionTCPrincipal(username);
                    frmAsociacionTCPrincipal.Show(this);
                    this.Hide();
                    break;

                case "Depositos":
                    DepositosPrincipal frmDepositosTCPrincipal = new DepositosPrincipal(username);
                    frmDepositosTCPrincipal.Show(this);
                    this.Hide();
                    break;

                case "Retiros":
                    RetirosPrincipal frmRetirosPrincipal = new RetirosPrincipal(username);
                    frmRetirosPrincipal.Show(this);
                    this.Hide();
                    break;

                case "Transferencias":
                    TransferenciasPrincipal frmTransferenciasPrincipal = new TransferenciasPrincipal(username);
                    frmTransferenciasPrincipal.Show(this);
                    this.Hide();
                    break;

                case "Facturacion":
                    FacturacionPrincipal frmFacturacionPrincipal = new FacturacionPrincipal();
                    frmFacturacionPrincipal.Show(this);
                    this.Hide();
                    break;

                case "Consulta Saldos":
                    ConsultaSaldosPrincipal frmConsultaSaldosPrincipal = new ConsultaSaldosPrincipal(rolCod, username);
                    frmConsultaSaldosPrincipal.Show(this);
                    this.Hide();
                    break;

                case "Listados Estadisticos":
                    ListadosPrincipal frmListadosPrincipal = new ListadosPrincipal();
                    frmListadosPrincipal.Show(this);
                    this.Hide();
                    break;
            }
        }

        private void cmbFuncionalidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnSeleccionar.PerformClick();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
