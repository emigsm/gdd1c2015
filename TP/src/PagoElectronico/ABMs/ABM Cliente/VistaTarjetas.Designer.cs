namespace PagoElectronico.ABMs.ABM_Cliente
{
    partial class VistaTarjetas
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
            this.tarjetaApellidoCliLabel = new System.Windows.Forms.Label();
            this.tarjetaNombreCliLabel = new System.Windows.Forms.Label();
            this.tarjetaCliIdLabel = new System.Windows.Forms.Label();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.TarjetaVolverBtn = new System.Windows.Forms.Button();
            this.Tarjeta_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta_Codigo_Seg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta_Emisor_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta_Fecha_Emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // tarjetaApellidoCliLabel
            // 
            this.tarjetaApellidoCliLabel.AutoSize = true;
            this.tarjetaApellidoCliLabel.Location = new System.Drawing.Point(12, 36);
            this.tarjetaApellidoCliLabel.Name = "tarjetaApellidoCliLabel";
            this.tarjetaApellidoCliLabel.Size = new System.Drawing.Size(110, 13);
            this.tarjetaApellidoCliLabel.TabIndex = 0;
            this.tarjetaApellidoCliLabel.Text = "tarjetaApellidoCliLabel";
            // 
            // tarjetaNombreCliLabel
            // 
            this.tarjetaNombreCliLabel.AutoSize = true;
            this.tarjetaNombreCliLabel.Location = new System.Drawing.Point(148, 36);
            this.tarjetaNombreCliLabel.Name = "tarjetaNombreCliLabel";
            this.tarjetaNombreCliLabel.Size = new System.Drawing.Size(53, 13);
            this.tarjetaNombreCliLabel.TabIndex = 1;
            this.tarjetaNombreCliLabel.Text = "nombreCli";
            // 
            // tarjetaCliIdLabel
            // 
            this.tarjetaCliIdLabel.AutoSize = true;
            this.tarjetaCliIdLabel.Location = new System.Drawing.Point(12, 64);
            this.tarjetaCliIdLabel.Name = "tarjetaCliIdLabel";
            this.tarjetaCliIdLabel.Size = new System.Drawing.Size(26, 13);
            this.tarjetaCliIdLabel.TabIndex = 2;
            this.tarjetaCliIdLabel.Text = "cliId";
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarjeta_Numero,
            this.Tarjeta_Codigo_Seg,
            this.Tarjeta_Emisor_Descripcion,
            this.Tarjeta_Fecha_Emision});
            this.dgvTarjetas.Location = new System.Drawing.Point(12, 95);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.Size = new System.Drawing.Size(312, 150);
            this.dgvTarjetas.TabIndex = 3;
            this.dgvTarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjetas_CellContentClick);
            // 
            // TarjetaVolverBtn
            // 
            this.TarjetaVolverBtn.Location = new System.Drawing.Point(15, 268);
            this.TarjetaVolverBtn.Name = "TarjetaVolverBtn";
            this.TarjetaVolverBtn.Size = new System.Drawing.Size(124, 23);
            this.TarjetaVolverBtn.TabIndex = 4;
            this.TarjetaVolverBtn.Text = "Volver";
            this.TarjetaVolverBtn.UseVisualStyleBackColor = true;
            this.TarjetaVolverBtn.Click += new System.EventHandler(this.TarjetaVolverBtn_Click);
            // 
            // Tarjeta_Numero
            // 
            this.Tarjeta_Numero.HeaderText = "Numero de Tarjeta";
            this.Tarjeta_Numero.Name = "Tarjeta_Numero";
            this.Tarjeta_Numero.ReadOnly = true;
            // 
            // Tarjeta_Codigo_Seg
            // 
            this.Tarjeta_Codigo_Seg.HeaderText = "Codigo de Seguridad";
            this.Tarjeta_Codigo_Seg.Name = "Tarjeta_Codigo_Seg";
            this.Tarjeta_Codigo_Seg.ReadOnly = true;
            // 
            // Tarjeta_Emisor_Descripcion
            // 
            this.Tarjeta_Emisor_Descripcion.HeaderText = "Emisora";
            this.Tarjeta_Emisor_Descripcion.Name = "Tarjeta_Emisor_Descripcion";
            this.Tarjeta_Emisor_Descripcion.ReadOnly = true;
            // 
            // Tarjeta_Fecha_Emision
            // 
            this.Tarjeta_Fecha_Emision.HeaderText = "Fecha de Emision";
            this.Tarjeta_Fecha_Emision.Name = "Tarjeta_Fecha_Emision";
            this.Tarjeta_Fecha_Emision.ReadOnly = true;
            // 
            // VistaTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 311);
            this.Controls.Add(this.TarjetaVolverBtn);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.tarjetaCliIdLabel);
            this.Controls.Add(this.tarjetaNombreCliLabel);
            this.Controls.Add(this.tarjetaApellidoCliLabel);
            this.Name = "VistaTarjetas";
            this.Text = "VistaTarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tarjetaApellidoCliLabel;
        private System.Windows.Forms.Label tarjetaNombreCliLabel;
        private System.Windows.Forms.Label tarjetaCliIdLabel;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.Button TarjetaVolverBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta_Codigo_Seg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta_Emisor_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta_Fecha_Emision;
    }
}