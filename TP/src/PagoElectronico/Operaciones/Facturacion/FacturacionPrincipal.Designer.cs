namespace PagoElectronico.Operaciones.Facturacion
{
    partial class FacturacionPrincipal
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
            this.opGenerarFactura = new System.Windows.Forms.RadioButton();
            this.opComprarSuscripcion = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opGenerarFactura
            // 
            this.opGenerarFactura.AutoSize = true;
            this.opGenerarFactura.Location = new System.Drawing.Point(15, 27);
            this.opGenerarFactura.Name = "opGenerarFactura";
            this.opGenerarFactura.Size = new System.Drawing.Size(102, 17);
            this.opGenerarFactura.TabIndex = 0;
            this.opGenerarFactura.TabStop = true;
            this.opGenerarFactura.Text = "Generar Factura";
            this.opGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // opComprarSuscripcion
            // 
            this.opComprarSuscripcion.AutoSize = true;
            this.opComprarSuscripcion.Location = new System.Drawing.Point(176, 27);
            this.opComprarSuscripcion.Name = "opComprarSuscripcion";
            this.opComprarSuscripcion.Size = new System.Drawing.Size(185, 17);
            this.opComprarSuscripcion.TabIndex = 1;
            this.opComprarSuscripcion.TabStop = true;
            this.opComprarSuscripcion.Text = "Comprar Suscripciones de Cuenta";
            this.opComprarSuscripcion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opComprarSuscripcion);
            this.groupBox1.Controls.Add(this.opGenerarFactura);
            this.groupBox1.Location = new System.Drawing.Point(15, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la operación a realizar:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(427, 12);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(108, 25);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(429, 44);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 24);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FacturacionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 83);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturacionPrincipal";
            this.Text = "FacturacionPrincipal";
            this.Load += new System.EventHandler(this.FacturacionPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton opGenerarFactura;
        private System.Windows.Forms.RadioButton opComprarSuscripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnVolver;
    }
}