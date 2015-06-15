namespace PagoElectronico.Operaciones.Facturacion
{
    partial class GenerarFactura
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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.FacturaNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperacionFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblinstruccion = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacturaNro,
            this.FacturaFecha,
            this.OperacionFecha,
            this.Detalle,
            this.Costo});
            this.dgvFactura.Location = new System.Drawing.Point(18, 31);
            this.dgvFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(1030, 228);
            this.dgvFactura.TabIndex = 0;
            // 
            // FacturaNro
            // 
            this.FacturaNro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FacturaNro.HeaderText = "Factura Número";
            this.FacturaNro.Name = "FacturaNro";
            this.FacturaNro.ReadOnly = true;
            this.FacturaNro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FacturaNro.Width = 117;
            // 
            // FacturaFecha
            // 
            this.FacturaFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FacturaFecha.HeaderText = "Factura Fecha";
            this.FacturaFecha.Name = "FacturaFecha";
            this.FacturaFecha.ReadOnly = true;
            this.FacturaFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FacturaFecha.Width = 107;
            // 
            // OperacionFecha
            // 
            this.OperacionFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OperacionFecha.HeaderText = "Operación Fecha";
            this.OperacionFecha.Name = "OperacionFecha";
            this.OperacionFecha.ReadOnly = true;
            this.OperacionFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OperacionFecha.Width = 123;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Detalle.Width = 65;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Costo.Width = 57;
            // 
            // lblinstruccion
            // 
            this.lblinstruccion.AutoSize = true;
            this.lblinstruccion.Location = new System.Drawing.Point(21, 25);
            this.lblinstruccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinstruccion.Name = "lblinstruccion";
            this.lblinstruccion.Size = new System.Drawing.Size(265, 20);
            this.lblinstruccion.TabIndex = 1;
            this.lblinstruccion.Text = "Seleccione el cliente al cual facturar:";
            this.lblinstruccion.Visible = false;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(342, 18);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(240, 28);
            this.cmbClientes.TabIndex = 2;
            this.cmbClientes.Visible = false;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(1120, 85);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(216, 97);
            this.btnGenerarFactura.TabIndex = 3;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFactura);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1058, 272);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones Facturadas";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1130, 255);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(201, 46);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 351);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblinstruccion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GenerarFactura";
            this.Text = "Generar Factura";
            this.Load += new System.EventHandler(this.GenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Label lblinstruccion;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperacionFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}