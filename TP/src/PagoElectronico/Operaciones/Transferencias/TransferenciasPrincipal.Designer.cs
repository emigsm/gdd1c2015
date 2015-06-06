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
            this.FiltroText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImporteText = new System.Windows.Forms.TextBox();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.NumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaDestino)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la Cuenta de Origen:";
            // 
            // cmbCuentaOrigen
            // 
            this.cmbCuentaOrigen.FormattingEnabled = true;
            this.cmbCuentaOrigen.Location = new System.Drawing.Point(234, 26);
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
            this.dgvCuentaDestino.Location = new System.Drawing.Point(6, 78);
            this.dgvCuentaDestino.Name = "dgvCuentaDestino";
            this.dgvCuentaDestino.ReadOnly = true;
            this.dgvCuentaDestino.Size = new System.Drawing.Size(447, 63);
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FiltroText);
            this.groupBox1.Controls.Add(this.dgvCuentaDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la Cuenta de Destino:";
            // 
            // FiltroText
            // 
            this.FiltroText.Location = new System.Drawing.Point(99, 52);
            this.FiltroText.Name = "FiltroText";
            this.FiltroText.Size = new System.Drawing.Size(149, 20);
            this.FiltroText.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese el Importe a Transferir:";
            // 
            // ImporteText
            // 
            this.ImporteText.Location = new System.Drawing.Point(205, 248);
            this.ImporteText.Name = "ImporteText";
            this.ImporteText.Size = new System.Drawing.Size(127, 20);
            this.ImporteText.TabIndex = 6;
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Location = new System.Drawing.Point(371, 236);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(186, 50);
            this.btnTransferencias.TabIndex = 7;
            this.btnTransferencias.Text = "Realizar Transferencia";
            this.btnTransferencias.UseVisualStyleBackColor = true;
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
            // 
            // TransferenciasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 331);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.ImporteText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCuentaOrigen);
            this.Controls.Add(this.label1);
            this.Name = "TransferenciasPrincipal";
            this.Text = "Transferencias";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuenta;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}