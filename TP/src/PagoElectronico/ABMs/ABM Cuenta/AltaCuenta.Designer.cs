namespace PagoElectronico.ABMs.ABM_Cuenta
{
    partial class AltaCuenta
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
            this.groupBoxNuevaCuenta = new System.Windows.Forms.GroupBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.groupBoxNuevaCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(197, 227);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBoxNuevaCuenta
            // 
            this.groupBoxNuevaCuenta.Controls.Add(this.lblTipoCuenta);
            this.groupBoxNuevaCuenta.Controls.Add(this.lblMoneda);
            this.groupBoxNuevaCuenta.Controls.Add(this.lblPais);
            this.groupBoxNuevaCuenta.Location = new System.Drawing.Point(13, 13);
            this.groupBoxNuevaCuenta.Name = "groupBoxNuevaCuenta";
            this.groupBoxNuevaCuenta.Size = new System.Drawing.Size(259, 208);
            this.groupBoxNuevaCuenta.TabIndex = 1;
            this.groupBoxNuevaCuenta.TabStop = false;
            this.groupBoxNuevaCuenta.Text = "Nueva Cuenta";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(7, 29);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 0;
            this.lblPais.Text = "Pais:";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(6, 73);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(49, 13);
            this.lblMoneda.TabIndex = 1;
            this.lblMoneda.Text = "Moneda:";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(7, 116);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCuenta.TabIndex = 2;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // AltaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBoxNuevaCuenta);
            this.Controls.Add(this.btnVolver);
            this.Name = "AltaCuenta";
            this.Text = "Alta de Cuenta";
            this.groupBoxNuevaCuenta.ResumeLayout(false);
            this.groupBoxNuevaCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBoxNuevaCuenta;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblMoneda;
    }
}