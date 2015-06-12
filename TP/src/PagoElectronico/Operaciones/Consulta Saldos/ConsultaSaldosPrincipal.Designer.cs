namespace PagoElectronico.Operaciones.Consulta_Saldos
{
    partial class ConsultaSaldosPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblClienteNumero = new System.Windows.Forms.Label();
            this.txtClienteNumero = new System.Windows.Forms.TextBox();
            this.lblCuentaNumero = new System.Windows.Forms.Label();
            this.cmbCuentas = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvDepositos = new System.Windows.Forms.DataGridView();
            this.Deposito_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposito_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblVSaldo = new System.Windows.Forms.Label();
            this.gbDepositos = new System.Windows.Forms.GroupBox();
            this.gbRetiros = new System.Windows.Forms.GroupBox();
            this.dgvRetiros = new System.Windows.Forms.DataGridView();
            this.Retiro_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retiro_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retiro_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retiro_Cheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbT = new System.Windows.Forms.GroupBox();
            this.dgvTransferencias = new System.Windows.Forms.DataGridView();
            this.Transferencia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia_Cuenta_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).BeginInit();
            this.gbDepositos.SuspendLayout();
            this.gbRetiros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiros)).BeginInit();
            this.gbT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(636, 827);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 38);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblClienteNumero
            // 
            this.lblClienteNumero.AutoSize = true;
            this.lblClienteNumero.Enabled = false;
            this.lblClienteNumero.Location = new System.Drawing.Point(3, 16);
            this.lblClienteNumero.Name = "lblClienteNumero";
            this.lblClienteNumero.Size = new System.Drawing.Size(120, 20);
            this.lblClienteNumero.TabIndex = 1;
            this.lblClienteNumero.Text = "Cliente numero:";
            // 
            // txtClienteNumero
            // 
            this.txtClienteNumero.Enabled = false;
            this.txtClienteNumero.Location = new System.Drawing.Point(141, 13);
            this.txtClienteNumero.Name = "txtClienteNumero";
            this.txtClienteNumero.Size = new System.Drawing.Size(196, 26);
            this.txtClienteNumero.TabIndex = 2;
            this.txtClienteNumero.TextChanged += new System.EventHandler(this.txtClienteNumero_TextChanged);
            // 
            // lblCuentaNumero
            // 
            this.lblCuentaNumero.AutoSize = true;
            this.lblCuentaNumero.Location = new System.Drawing.Point(3, 61);
            this.lblCuentaNumero.Name = "lblCuentaNumero";
            this.lblCuentaNumero.Size = new System.Drawing.Size(123, 20);
            this.lblCuentaNumero.TabIndex = 3;
            this.lblCuentaNumero.Text = "Cuenta numero:";
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.FormattingEnabled = true;
            this.cmbCuentas.Location = new System.Drawing.Point(141, 58);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Size = new System.Drawing.Size(196, 28);
            this.cmbCuentas.TabIndex = 4;
            this.cmbCuentas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCuentaNumero);
            this.panel1.Controls.Add(this.cmbCuentas);
            this.panel1.Controls.Add(this.lblClienteNumero);
            this.panel1.Controls.Add(this.txtClienteNumero);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 97);
            this.panel1.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(384, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 97);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvDepositos
            // 
            this.dgvDepositos.AllowUserToAddRows = false;
            this.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deposito_Codigo,
            this.Deposito_Fecha,
            this.Deposito_Importe,
            this.Deposito_Tarjeta});
            this.dgvDepositos.Location = new System.Drawing.Point(7, 37);
            this.dgvDepositos.Name = "dgvDepositos";
            this.dgvDepositos.RowHeadersVisible = false;
            this.dgvDepositos.RowTemplate.Height = 28;
            this.dgvDepositos.Size = new System.Drawing.Size(653, 150);
            this.dgvDepositos.TabIndex = 7;
            // 
            // Deposito_Codigo
            // 
            this.Deposito_Codigo.HeaderText = "Codigo";
            this.Deposito_Codigo.Name = "Deposito_Codigo";
            this.Deposito_Codigo.Width = 150;
            // 
            // Deposito_Fecha
            // 
            this.Deposito_Fecha.HeaderText = "Fecha";
            this.Deposito_Fecha.Name = "Deposito_Fecha";
            this.Deposito_Fecha.Width = 150;
            // 
            // Deposito_Importe
            // 
            this.Deposito_Importe.HeaderText = "Importe";
            this.Deposito_Importe.Name = "Deposito_Importe";
            this.Deposito_Importe.Width = 150;
            // 
            // Deposito_Tarjeta
            // 
            this.Deposito_Tarjeta.HeaderText = "Tarjeta";
            this.Deposito_Tarjeta.Name = "Deposito_Tarjeta";
            this.Deposito_Tarjeta.Width = 200;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 123);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 20);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblVSaldo
            // 
            this.lblVSaldo.AutoSize = true;
            this.lblVSaldo.Location = new System.Drawing.Point(149, 123);
            this.lblVSaldo.Name = "lblVSaldo";
            this.lblVSaldo.Size = new System.Drawing.Size(59, 20);
            this.lblVSaldo.TabIndex = 10;
            this.lblVSaldo.Text = "(Vacío)";
            // 
            // gbDepositos
            // 
            this.gbDepositos.Controls.Add(this.dgvDepositos);
            this.gbDepositos.Location = new System.Drawing.Point(12, 159);
            this.gbDepositos.Name = "gbDepositos";
            this.gbDepositos.Size = new System.Drawing.Size(673, 200);
            this.gbDepositos.TabIndex = 11;
            this.gbDepositos.TabStop = false;
            this.gbDepositos.Text = "Últimos 5 depósitos";
            this.gbDepositos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbRetiros
            // 
            this.gbRetiros.Controls.Add(this.dgvRetiros);
            this.gbRetiros.Location = new System.Drawing.Point(12, 377);
            this.gbRetiros.Name = "gbRetiros";
            this.gbRetiros.Size = new System.Drawing.Size(673, 200);
            this.gbRetiros.TabIndex = 12;
            this.gbRetiros.TabStop = false;
            this.gbRetiros.Text = "Últimos 5 retiros";
            // 
            // dgvRetiros
            // 
            this.dgvRetiros.AllowUserToAddRows = false;
            this.dgvRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Retiro_Codigo,
            this.Retiro_Fecha,
            this.Retiro_Importe,
            this.Retiro_Cheque});
            this.dgvRetiros.Location = new System.Drawing.Point(7, 37);
            this.dgvRetiros.Name = "dgvRetiros";
            this.dgvRetiros.RowHeadersVisible = false;
            this.dgvRetiros.RowTemplate.Height = 28;
            this.dgvRetiros.Size = new System.Drawing.Size(653, 150);
            this.dgvRetiros.TabIndex = 7;
            // 
            // Retiro_Codigo
            // 
            this.Retiro_Codigo.HeaderText = "Codigo";
            this.Retiro_Codigo.Name = "Retiro_Codigo";
            this.Retiro_Codigo.Width = 150;
            // 
            // Retiro_Fecha
            // 
            this.Retiro_Fecha.HeaderText = "Fecha";
            this.Retiro_Fecha.Name = "Retiro_Fecha";
            this.Retiro_Fecha.Width = 150;
            // 
            // Retiro_Importe
            // 
            this.Retiro_Importe.HeaderText = "Importe";
            this.Retiro_Importe.Name = "Retiro_Importe";
            this.Retiro_Importe.Width = 150;
            // 
            // Retiro_Cheque
            // 
            this.Retiro_Cheque.HeaderText = "Cheque";
            this.Retiro_Cheque.Name = "Retiro_Cheque";
            this.Retiro_Cheque.Width = 200;
            // 
            // gbT
            // 
            this.gbT.Controls.Add(this.dgvTransferencias);
            this.gbT.Location = new System.Drawing.Point(12, 602);
            this.gbT.Name = "gbT";
            this.gbT.Size = new System.Drawing.Size(774, 200);
            this.gbT.TabIndex = 12;
            this.gbT.TabStop = false;
            this.gbT.Text = "Últimas 10 transferencias";
            // 
            // dgvTransferencias
            // 
            this.dgvTransferencias.AllowUserToAddRows = false;
            this.dgvTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transferencia_Codigo,
            this.Transferencia_Fecha,
            this.Transferencia_Importe,
            this.Transferencia_Costo,
            this.Transferencia_Cuenta_Destino});
            this.dgvTransferencias.Location = new System.Drawing.Point(7, 37);
            this.dgvTransferencias.Name = "dgvTransferencias";
            this.dgvTransferencias.RowHeadersVisible = false;
            this.dgvTransferencias.RowTemplate.Height = 28;
            this.dgvTransferencias.Size = new System.Drawing.Size(755, 150);
            this.dgvTransferencias.TabIndex = 7;
            // 
            // Transferencia_Codigo
            // 
            this.Transferencia_Codigo.HeaderText = "Codigo";
            this.Transferencia_Codigo.Name = "Transferencia_Codigo";
            this.Transferencia_Codigo.Width = 150;
            // 
            // Transferencia_Fecha
            // 
            this.Transferencia_Fecha.HeaderText = "Fecha";
            this.Transferencia_Fecha.Name = "Transferencia_Fecha";
            this.Transferencia_Fecha.Width = 150;
            // 
            // Transferencia_Importe
            // 
            this.Transferencia_Importe.HeaderText = "Importe";
            this.Transferencia_Importe.Name = "Transferencia_Importe";
            // 
            // Transferencia_Costo
            // 
            this.Transferencia_Costo.HeaderText = "Costo de Transaccion";
            this.Transferencia_Costo.Name = "Transferencia_Costo";
            this.Transferencia_Costo.Width = 150;
            // 
            // Transferencia_Cuenta_Destino
            // 
            this.Transferencia_Cuenta_Destino.HeaderText = "Cuenta Destino";
            this.Transferencia_Cuenta_Destino.Name = "Transferencia_Cuenta_Destino";
            this.Transferencia_Cuenta_Destino.Width = 200;
            // 
            // ConsultaSaldosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 883);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbT);
            this.Controls.Add(this.gbRetiros);
            this.Controls.Add(this.lblVSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbDepositos);
            this.Name = "ConsultaSaldosPrincipal";
            this.Text = "Consulta de Saldos";
            this.Load += new System.EventHandler(this.ConsultaSaldosPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).EndInit();
            this.gbDepositos.ResumeLayout(false);
            this.gbRetiros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiros)).EndInit();
            this.gbT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblClienteNumero;
        private System.Windows.Forms.TextBox txtClienteNumero;
        private System.Windows.Forms.Label lblCuentaNumero;
        private System.Windows.Forms.ComboBox cmbCuentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvDepositos;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblVSaldo;
        private System.Windows.Forms.GroupBox gbDepositos;
        private System.Windows.Forms.GroupBox gbRetiros;
        private System.Windows.Forms.DataGridView dgvRetiros;
        private System.Windows.Forms.GroupBox gbT;
        private System.Windows.Forms.DataGridView dgvTransferencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposito_Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retiro_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retiro_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retiro_Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retiro_Cheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia_Cuenta_Destino;
    }
}