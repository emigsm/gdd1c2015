namespace PagoElectronico.Operaciones.Asociacion_TC
{
    partial class AsociacionTCPrincipal
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
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.Numero_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Seguridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emisora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tarjetaCliIdLabel = new System.Windows.Forms.Label();
            this.leyendaCliId = new System.Windows.Forms.Label();
            this.tarjetaApellidoCliLabel = new System.Windows.Forms.Label();
            this.tarjetaNombreCliLabel = new System.Windows.Forms.Label();
            this.VincularTarjetabutton = new System.Windows.Forms.Button();
            this.desvincularTarjetabutton = new System.Windows.Forms.Button();
            this.volverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Tarjeta,
            this.Codigo_Seguridad,
            this.Emisora,
            this.Fecha_Emision,
            this.Fecha_Vencimiento,
            this.Habilitada});
            this.dgvTarjetas.Location = new System.Drawing.Point(24, 129);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.Size = new System.Drawing.Size(358, 214);
            this.dgvTarjetas.TabIndex = 0;
            // 
            // Numero_Tarjeta
            // 
            this.Numero_Tarjeta.HeaderText = "Numero Tarjeta";
            this.Numero_Tarjeta.Name = "Numero_Tarjeta";
            this.Numero_Tarjeta.ReadOnly = true;
            // 
            // Codigo_Seguridad
            // 
            this.Codigo_Seguridad.HeaderText = "Codigo Seguridad";
            this.Codigo_Seguridad.Name = "Codigo_Seguridad";
            this.Codigo_Seguridad.ReadOnly = true;
            // 
            // Emisora
            // 
            this.Emisora.HeaderText = "Emisora";
            this.Emisora.Name = "Emisora";
            this.Emisora.ReadOnly = true;
            // 
            // Fecha_Emision
            // 
            this.Fecha_Emision.HeaderText = "Fecha Emision";
            this.Fecha_Emision.Name = "Fecha_Emision";
            this.Fecha_Emision.ReadOnly = true;
            // 
            // Fecha_Vencimiento
            // 
            this.Fecha_Vencimiento.HeaderText = "Fecha Vencimiento";
            this.Fecha_Vencimiento.Name = "Fecha_Vencimiento";
            this.Fecha_Vencimiento.ReadOnly = true;
            // 
            // Habilitada
            // 
            this.Habilitada.HeaderText = "Habilitada";
            this.Habilitada.Name = "Habilitada";
            this.Habilitada.ReadOnly = true;
            // 
            // tarjetaCliIdLabel
            // 
            this.tarjetaCliIdLabel.AutoSize = true;
            this.tarjetaCliIdLabel.Location = new System.Drawing.Point(144, 76);
            this.tarjetaCliIdLabel.Name = "tarjetaCliIdLabel";
            this.tarjetaCliIdLabel.Size = new System.Drawing.Size(50, 13);
            this.tarjetaCliIdLabel.TabIndex = 1;
            this.tarjetaCliIdLabel.Text = "ClienteID";
            // 
            // leyendaCliId
            // 
            this.leyendaCliId.AutoSize = true;
            this.leyendaCliId.Location = new System.Drawing.Point(32, 76);
            this.leyendaCliId.Name = "leyendaCliId";
            this.leyendaCliId.Size = new System.Drawing.Size(56, 13);
            this.leyendaCliId.TabIndex = 2;
            this.leyendaCliId.Text = "Cliente ID:";
            // 
            // tarjetaApellidoCliLabel
            // 
            this.tarjetaApellidoCliLabel.AutoSize = true;
            this.tarjetaApellidoCliLabel.Location = new System.Drawing.Point(32, 43);
            this.tarjetaApellidoCliLabel.Name = "tarjetaApellidoCliLabel";
            this.tarjetaApellidoCliLabel.Size = new System.Drawing.Size(44, 13);
            this.tarjetaApellidoCliLabel.TabIndex = 3;
            this.tarjetaApellidoCliLabel.Text = "Apellido";
            // 
            // tarjetaNombreCliLabel
            // 
            this.tarjetaNombreCliLabel.AutoSize = true;
            this.tarjetaNombreCliLabel.Location = new System.Drawing.Point(144, 43);
            this.tarjetaNombreCliLabel.Name = "tarjetaNombreCliLabel";
            this.tarjetaNombreCliLabel.Size = new System.Drawing.Size(44, 13);
            this.tarjetaNombreCliLabel.TabIndex = 4;
            this.tarjetaNombreCliLabel.Text = "Nombre";
            // 
            // VincularTarjetabutton
            // 
            this.VincularTarjetabutton.Location = new System.Drawing.Point(457, 149);
            this.VincularTarjetabutton.Name = "VincularTarjetabutton";
            this.VincularTarjetabutton.Size = new System.Drawing.Size(115, 64);
            this.VincularTarjetabutton.TabIndex = 5;
            this.VincularTarjetabutton.Text = "Vincular Tarjeta";
            this.VincularTarjetabutton.UseVisualStyleBackColor = true;
            // 
            // desvincularTarjetabutton
            // 
            this.desvincularTarjetabutton.Location = new System.Drawing.Point(457, 230);
            this.desvincularTarjetabutton.Name = "desvincularTarjetabutton";
            this.desvincularTarjetabutton.Size = new System.Drawing.Size(115, 68);
            this.desvincularTarjetabutton.TabIndex = 6;
            this.desvincularTarjetabutton.Text = "Desvincular Tarjeta";
            this.desvincularTarjetabutton.UseVisualStyleBackColor = true;
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(457, 320);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(124, 52);
            this.volverButton.TabIndex = 7;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // AsociacionTCPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 384);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.desvincularTarjetabutton);
            this.Controls.Add(this.VincularTarjetabutton);
            this.Controls.Add(this.tarjetaNombreCliLabel);
            this.Controls.Add(this.tarjetaApellidoCliLabel);
            this.Controls.Add(this.leyendaCliId);
            this.Controls.Add(this.tarjetaCliIdLabel);
            this.Controls.Add(this.dgvTarjetas);
            this.Name = "AsociacionTCPrincipal";
            this.Text = "AsociacionTCPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.Label tarjetaCliIdLabel;
        private System.Windows.Forms.Label leyendaCliId;
        private System.Windows.Forms.Label tarjetaApellidoCliLabel;
        private System.Windows.Forms.Label tarjetaNombreCliLabel;
        private System.Windows.Forms.Button VincularTarjetabutton;
        private System.Windows.Forms.Button desvincularTarjetabutton;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Seguridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emisora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Emision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Vencimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitada;
    }
}