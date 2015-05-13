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
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Location = new System.Drawing.Point(12, 95);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.Size = new System.Drawing.Size(312, 150);
            this.dgvTarjetas.TabIndex = 3;
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
    }
}