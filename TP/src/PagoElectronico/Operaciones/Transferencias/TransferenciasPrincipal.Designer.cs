namespace PagoElectronico.Operaciones.Transferencias
{
    partial class TransferenciasPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.dgvCuentaDestino = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltroText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImporteText = new System.Windows.Forms.TextBox();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscarCuentas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.NumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaDestino)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la Cuenta de Origen:";
            // 
            // cmbCuentaOrigen
            // 
            this.cmbCuentaOrigen.FormattingEnabled = true;
            this.cmbCuentaOrigen.Location = new System.Drawing.Point(234, 66);
            this.cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            this.cmbCuentaOrigen.Size = new System.Drawing.Size(219, 21);
            this.cmbCuentaOrigen.TabIndex = 1;
            // 
            // dgvCuentaDestino
            // 
            this.dgvCuentaDestino.AllowUserToAddRows = false;
            this.dgvCuentaDestino.AllowUserToDeleteRows = false;
            this.dgvCuentaDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentaDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCuenta,
            this.Seleccionar});
            this.dgvCuentaDestino.Location = new System.Drawing.Point(6, 86);
            this.dgvCuentaDestino.Name = "dgvCuentaDestino";
            this.dgvCuentaDestino.ReadOnly = true;
            this.dgvCuentaDestino.Size = new System.Drawing.Size(353, 85);
            this.dgvCuentaDestino.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el número exacto o parcial de la cuenta, para acotar la selección.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBuscarCuentas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FiltroText);
            this.groupBox1.Controls.Add(this.dgvCuentaDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la Cuenta de Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtro:";
            // 
            // FiltroText
            // 
            this.FiltroText.Location = new System.Drawing.Point(99, 52);
            this.FiltroText.Name = "FiltroText";
            this.FiltroText.Size = new System.Drawing.Size(149, 20);
            this.FiltroText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese el Importe a Transferir:";
            // 
            // ImporteText
            // 
            this.ImporteText.Location = new System.Drawing.Point(205, 294);
            this.ImporteText.Name = "ImporteText";
            this.ImporteText.Size = new System.Drawing.Size(127, 20);
            this.ImporteText.TabIndex = 6;
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Location = new System.Drawing.Point(370, 349);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(186, 50);
            this.btnTransferencias.TabIndex = 7;
            this.btnTransferencias.Text = "Realizar Transferencia";
            this.btnTransferencias.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Actual:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(233, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "FECHA";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(84, 352);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(191, 47);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Vover";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscarCuentas
            // 
            this.btnBuscarCuentas.Location = new System.Drawing.Point(375, 86);
            this.btnBuscarCuentas.Name = "btnBuscarCuentas";
            this.btnBuscarCuentas.Size = new System.Drawing.Size(144, 26);
            this.btnBuscarCuentas.TabIndex = 6;
            this.btnBuscarCuentas.Text = "Buscar";
            this.btnBuscarCuentas.UseVisualStyleBackColor = true;
            this.btnBuscarCuentas.Click += new System.EventHandler(this.btnBuscarCuentas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(375, 133);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 25);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // NumeroCuenta
            // 
            this.NumeroCuenta.HeaderText = "Número de Cuenta";
            this.NumeroCuenta.Name = "NumeroCuenta";
            this.NumeroCuenta.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TransferenciasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 426);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.ImporteText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCuentaOrigen);
            this.Controls.Add(this.label1);
            this.Name = "TransferenciasPrincipal";
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.TransferenciasPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaDestino)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCuentaOrigen;
        private System.Windows.Forms.DataGridView dgvCuentaDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FiltroText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImporteText;
        private System.Windows.Forms.Button btnTransferencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscarCuentas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}