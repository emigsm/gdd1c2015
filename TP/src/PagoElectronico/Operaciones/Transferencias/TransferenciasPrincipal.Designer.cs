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
            this.NumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarCuentas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltroText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaDestino)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la Cuenta de Origen:";
            // 
            // cmbCuentaOrigen
            // 
            this.cmbCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentaOrigen.FormattingEnabled = true;
            this.cmbCuentaOrigen.Location = new System.Drawing.Point(351, 75);
            this.cmbCuentaOrigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            this.cmbCuentaOrigen.Size = new System.Drawing.Size(326, 28);
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
            this.dgvCuentaDestino.Location = new System.Drawing.Point(9, 155);
            this.dgvCuentaDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCuentaDestino.Name = "dgvCuentaDestino";
            this.dgvCuentaDestino.ReadOnly = true;
            this.dgvCuentaDestino.Size = new System.Drawing.Size(530, 132);
            this.dgvCuentaDestino.TabIndex = 2;
            this.dgvCuentaDestino.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentaDestino_CellContentClick);
            // 
            // NumeroCuenta
            // 
            this.NumeroCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumeroCuenta.HeaderText = "Número de Cuenta";
            this.NumeroCuenta.Name = "NumeroCuenta";
            this.NumeroCuenta.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el número exacto o parcial de la cuenta, para acotar la selección.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCuenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBuscarCuentas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FiltroText);
            this.groupBox1.Controls.Add(this.dgvCuentaDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(874, 352);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la Cuenta de Destino:";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(297, 312);
            this.lblCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(74, 20);
            this.lblCuenta.TabIndex = 10;
            this.lblCuenta.Text = "CUENTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nro de cuenta seleccionada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seleccione la celda con el número de cuenta de destino.";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(590, 240);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(216, 38);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarCuentas
            // 
            this.btnBuscarCuentas.Location = new System.Drawing.Point(591, 158);
            this.btnBuscarCuentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCuentas.Name = "btnBuscarCuentas";
            this.btnBuscarCuentas.Size = new System.Drawing.Size(216, 40);
            this.btnBuscarCuentas.TabIndex = 6;
            this.btnBuscarCuentas.Text = "Buscar";
            this.btnBuscarCuentas.UseVisualStyleBackColor = true;
            this.btnBuscarCuentas.Click += new System.EventHandler(this.btnBuscarCuentas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtro:";
            // 
            // FiltroText
            // 
            this.FiltroText.Location = new System.Drawing.Point(148, 80);
            this.FiltroText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FiltroText.MaxLength = 10;
            this.FiltroText.Name = "FiltroText";
            this.FiltroText.Size = new System.Drawing.Size(222, 26);
            this.FiltroText.TabIndex = 4;
            this.FiltroText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltroText_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 525);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese el Importe a Transferir:";
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Location = new System.Drawing.Point(308, 514);
            this.ImporteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImporteTextBox.MaxLength = 10;
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.Size = new System.Drawing.Size(188, 26);
            this.ImporteTextBox.TabIndex = 6;
            this.ImporteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImporteTextBox_KeyPress);
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Location = new System.Drawing.Point(555, 583);
            this.btnTransferencias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(279, 77);
            this.btnTransferencias.TabIndex = 7;
            this.btnTransferencias.Text = "Realizar Transferencia";
            this.btnTransferencias.UseVisualStyleBackColor = true;
            this.btnTransferencias.Click += new System.EventHandler(this.btnTransferencias_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Actual:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(350, 29);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "FECHA";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(126, 588);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(286, 72);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(638, 514);
            this.btnLimpiar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(164, 31);
            this.btnLimpiar2.TabIndex = 11;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // TransferenciasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 680);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.ImporteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCuentaOrigen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.Button btnTransferencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscarCuentas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuenta;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button btnLimpiar2;
    }
}