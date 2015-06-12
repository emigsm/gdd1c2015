namespace PagoElectronico.ABMs.ABM_Cuenta
{
    partial class ModificacionCuenta
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
            this.btnCambiarPais = new System.Windows.Forms.Button();
            this.groupBoxPais = new System.Windows.Forms.GroupBox();
            this.lblPaisActual = new System.Windows.Forms.Label();
            this.cmbPaisNuevo = new System.Windows.Forms.ComboBox();
            this.lblPaisNuevo = new System.Windows.Forms.Label();
            this.lblPaisViejo = new System.Windows.Forms.Label();
            this.checkBoxPais = new System.Windows.Forms.CheckBox();
            this.btnCambiarMoneda = new System.Windows.Forms.Button();
            this.groupBoxMoneda = new System.Windows.Forms.GroupBox();
            this.lblVMonedaActual = new System.Windows.Forms.Label();
            this.cmbMonedaNueva = new System.Windows.Forms.ComboBox();
            this.lblMonedaNueva = new System.Windows.Forms.Label();
            this.lblMonedaActual = new System.Windows.Forms.Label();
            this.checkBoxMoneda = new System.Windows.Forms.CheckBox();
            this.btnCambiarTipoCuenta = new System.Windows.Forms.Button();
            this.groupBoxTipoCuenta = new System.Windows.Forms.GroupBox();
            this.lblVTipoCuentaActual = new System.Windows.Forms.Label();
            this.cmbTipoCuentaNuevo = new System.Windows.Forms.ComboBox();
            this.lblTipoCuentaNuevo = new System.Windows.Forms.Label();
            this.lblTipoCuentaActual = new System.Windows.Forms.Label();
            this.checkBoxTipoCuenta = new System.Windows.Forms.CheckBox();
            this.groupBoxPais.SuspendLayout();
            this.groupBoxMoneda.SuspendLayout();
            this.groupBoxTipoCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(530, 429);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCambiarPais
            // 
            this.btnCambiarPais.Enabled = false;
            this.btnCambiarPais.Location = new System.Drawing.Point(493, 14);
            this.btnCambiarPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarPais.Name = "btnCambiarPais";
            this.btnCambiarPais.Size = new System.Drawing.Size(112, 125);
            this.btnCambiarPais.TabIndex = 7;
            this.btnCambiarPais.Text = "Cambiar";
            this.btnCambiarPais.UseVisualStyleBackColor = true;
            this.btnCambiarPais.Click += new System.EventHandler(this.btnCambiarPais_Click);
            // 
            // groupBoxPais
            // 
            this.groupBoxPais.Controls.Add(this.lblPaisActual);
            this.groupBoxPais.Controls.Add(this.cmbPaisNuevo);
            this.groupBoxPais.Controls.Add(this.lblPaisNuevo);
            this.groupBoxPais.Controls.Add(this.lblPaisViejo);
            this.groupBoxPais.Controls.Add(this.checkBoxPais);
            this.groupBoxPais.Location = new System.Drawing.Point(5, 14);
            this.groupBoxPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPais.Name = "groupBoxPais";
            this.groupBoxPais.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPais.Size = new System.Drawing.Size(480, 125);
            this.groupBoxPais.TabIndex = 6;
            this.groupBoxPais.TabStop = false;
            this.groupBoxPais.Text = "Cambio de pais";
            this.groupBoxPais.Enter += new System.EventHandler(this.groupBoxPais_Enter);
            // 
            // lblPaisActual
            // 
            this.lblPaisActual.AutoSize = true;
            this.lblPaisActual.Enabled = false;
            this.lblPaisActual.Location = new System.Drawing.Point(236, 28);
            this.lblPaisActual.Name = "lblPaisActual";
            this.lblPaisActual.Size = new System.Drawing.Size(59, 20);
            this.lblPaisActual.TabIndex = 7;
            this.lblPaisActual.Text = "(Vacío)";
            // 
            // cmbPaisNuevo
            // 
            this.cmbPaisNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaisNuevo.Enabled = false;
            this.cmbPaisNuevo.FormattingEnabled = true;
            this.cmbPaisNuevo.Location = new System.Drawing.Point(236, 63);
            this.cmbPaisNuevo.Name = "cmbPaisNuevo";
            this.cmbPaisNuevo.Size = new System.Drawing.Size(234, 28);
            this.cmbPaisNuevo.TabIndex = 6;
            // 
            // lblPaisNuevo
            // 
            this.lblPaisNuevo.AutoSize = true;
            this.lblPaisNuevo.Enabled = false;
            this.lblPaisNuevo.Location = new System.Drawing.Point(9, 72);
            this.lblPaisNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaisNuevo.Name = "lblPaisNuevo";
            this.lblPaisNuevo.Size = new System.Drawing.Size(90, 20);
            this.lblPaisNuevo.TabIndex = 2;
            this.lblPaisNuevo.Text = "Pais nuevo:";
            // 
            // lblPaisViejo
            // 
            this.lblPaisViejo.AutoSize = true;
            this.lblPaisViejo.Enabled = false;
            this.lblPaisViejo.Location = new System.Drawing.Point(9, 31);
            this.lblPaisViejo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaisViejo.Name = "lblPaisViejo";
            this.lblPaisViejo.Size = new System.Drawing.Size(90, 20);
            this.lblPaisViejo.TabIndex = 1;
            this.lblPaisViejo.Text = "Pais actual:";
            // 
            // checkBoxPais
            // 
            this.checkBoxPais.AutoSize = true;
            this.checkBoxPais.Location = new System.Drawing.Point(127, 0);
            this.checkBoxPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPais.Name = "checkBoxPais";
            this.checkBoxPais.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPais.TabIndex = 0;
            this.checkBoxPais.UseVisualStyleBackColor = true;
            this.checkBoxPais.CheckedChanged += new System.EventHandler(this.checkBoxPais_CheckedChanged);
            // 
            // btnCambiarMoneda
            // 
            this.btnCambiarMoneda.Enabled = false;
            this.btnCambiarMoneda.Location = new System.Drawing.Point(493, 149);
            this.btnCambiarMoneda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarMoneda.Name = "btnCambiarMoneda";
            this.btnCambiarMoneda.Size = new System.Drawing.Size(112, 125);
            this.btnCambiarMoneda.TabIndex = 9;
            this.btnCambiarMoneda.Text = "Cambiar";
            this.btnCambiarMoneda.UseVisualStyleBackColor = true;
            // 
            // groupBoxMoneda
            // 
            this.groupBoxMoneda.Controls.Add(this.lblVMonedaActual);
            this.groupBoxMoneda.Controls.Add(this.cmbMonedaNueva);
            this.groupBoxMoneda.Controls.Add(this.lblMonedaNueva);
            this.groupBoxMoneda.Controls.Add(this.lblMonedaActual);
            this.groupBoxMoneda.Controls.Add(this.checkBoxMoneda);
            this.groupBoxMoneda.Location = new System.Drawing.Point(5, 149);
            this.groupBoxMoneda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMoneda.Name = "groupBoxMoneda";
            this.groupBoxMoneda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMoneda.Size = new System.Drawing.Size(480, 125);
            this.groupBoxMoneda.TabIndex = 8;
            this.groupBoxMoneda.TabStop = false;
            this.groupBoxMoneda.Text = "Cambio de moneda";
            // 
            // lblVMonedaActual
            // 
            this.lblVMonedaActual.AutoSize = true;
            this.lblVMonedaActual.Enabled = false;
            this.lblVMonedaActual.Location = new System.Drawing.Point(232, 31);
            this.lblVMonedaActual.Name = "lblVMonedaActual";
            this.lblVMonedaActual.Size = new System.Drawing.Size(59, 20);
            this.lblVMonedaActual.TabIndex = 8;
            this.lblVMonedaActual.Text = "(Vacío)";
            // 
            // cmbMonedaNueva
            // 
            this.cmbMonedaNueva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonedaNueva.Enabled = false;
            this.cmbMonedaNueva.FormattingEnabled = true;
            this.cmbMonedaNueva.Location = new System.Drawing.Point(236, 62);
            this.cmbMonedaNueva.Name = "cmbMonedaNueva";
            this.cmbMonedaNueva.Size = new System.Drawing.Size(234, 28);
            this.cmbMonedaNueva.TabIndex = 6;
            // 
            // lblMonedaNueva
            // 
            this.lblMonedaNueva.AutoSize = true;
            this.lblMonedaNueva.Enabled = false;
            this.lblMonedaNueva.Location = new System.Drawing.Point(9, 72);
            this.lblMonedaNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonedaNueva.Name = "lblMonedaNueva";
            this.lblMonedaNueva.Size = new System.Drawing.Size(118, 20);
            this.lblMonedaNueva.TabIndex = 2;
            this.lblMonedaNueva.Text = "Moneda nueva:";
            // 
            // lblMonedaActual
            // 
            this.lblMonedaActual.AutoSize = true;
            this.lblMonedaActual.Enabled = false;
            this.lblMonedaActual.Location = new System.Drawing.Point(9, 31);
            this.lblMonedaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonedaActual.Name = "lblMonedaActual";
            this.lblMonedaActual.Size = new System.Drawing.Size(118, 20);
            this.lblMonedaActual.TabIndex = 1;
            this.lblMonedaActual.Text = "Moneda actual:";
            // 
            // checkBoxMoneda
            // 
            this.checkBoxMoneda.AutoSize = true;
            this.checkBoxMoneda.Location = new System.Drawing.Point(156, 0);
            this.checkBoxMoneda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMoneda.Name = "checkBoxMoneda";
            this.checkBoxMoneda.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMoneda.TabIndex = 0;
            this.checkBoxMoneda.UseVisualStyleBackColor = true;
            this.checkBoxMoneda.CheckedChanged += new System.EventHandler(this.checkBoxMoneda_CheckedChanged);
            // 
            // btnCambiarTipoCuenta
            // 
            this.btnCambiarTipoCuenta.Enabled = false;
            this.btnCambiarTipoCuenta.Location = new System.Drawing.Point(493, 286);
            this.btnCambiarTipoCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarTipoCuenta.Name = "btnCambiarTipoCuenta";
            this.btnCambiarTipoCuenta.Size = new System.Drawing.Size(112, 125);
            this.btnCambiarTipoCuenta.TabIndex = 11;
            this.btnCambiarTipoCuenta.Text = "Cambiar";
            this.btnCambiarTipoCuenta.UseVisualStyleBackColor = true;
            this.btnCambiarTipoCuenta.Click += new System.EventHandler(this.btnCambiarTipoCuenta_Click);
            // 
            // groupBoxTipoCuenta
            // 
            this.groupBoxTipoCuenta.Controls.Add(this.lblVTipoCuentaActual);
            this.groupBoxTipoCuenta.Controls.Add(this.cmbTipoCuentaNuevo);
            this.groupBoxTipoCuenta.Controls.Add(this.lblTipoCuentaNuevo);
            this.groupBoxTipoCuenta.Controls.Add(this.lblTipoCuentaActual);
            this.groupBoxTipoCuenta.Controls.Add(this.checkBoxTipoCuenta);
            this.groupBoxTipoCuenta.Location = new System.Drawing.Point(5, 286);
            this.groupBoxTipoCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTipoCuenta.Name = "groupBoxTipoCuenta";
            this.groupBoxTipoCuenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTipoCuenta.Size = new System.Drawing.Size(480, 125);
            this.groupBoxTipoCuenta.TabIndex = 10;
            this.groupBoxTipoCuenta.TabStop = false;
            this.groupBoxTipoCuenta.Text = "Cambio de Tipo";
            // 
            // lblVTipoCuentaActual
            // 
            this.lblVTipoCuentaActual.AutoSize = true;
            this.lblVTipoCuentaActual.Enabled = false;
            this.lblVTipoCuentaActual.Location = new System.Drawing.Point(232, 31);
            this.lblVTipoCuentaActual.Name = "lblVTipoCuentaActual";
            this.lblVTipoCuentaActual.Size = new System.Drawing.Size(59, 20);
            this.lblVTipoCuentaActual.TabIndex = 9;
            this.lblVTipoCuentaActual.Text = "(Vacío)";
            // 
            // cmbTipoCuentaNuevo
            // 
            this.cmbTipoCuentaNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuentaNuevo.Enabled = false;
            this.cmbTipoCuentaNuevo.FormattingEnabled = true;
            this.cmbTipoCuentaNuevo.Location = new System.Drawing.Point(236, 62);
            this.cmbTipoCuentaNuevo.Name = "cmbTipoCuentaNuevo";
            this.cmbTipoCuentaNuevo.Size = new System.Drawing.Size(234, 28);
            this.cmbTipoCuentaNuevo.TabIndex = 6;
            // 
            // lblTipoCuentaNuevo
            // 
            this.lblTipoCuentaNuevo.AutoSize = true;
            this.lblTipoCuentaNuevo.Enabled = false;
            this.lblTipoCuentaNuevo.Location = new System.Drawing.Point(9, 72);
            this.lblTipoCuentaNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCuentaNuevo.Name = "lblTipoCuentaNuevo";
            this.lblTipoCuentaNuevo.Size = new System.Drawing.Size(168, 20);
            this.lblTipoCuentaNuevo.TabIndex = 2;
            this.lblTipoCuentaNuevo.Text = "Tipo de Cuenta nuevo:";
            // 
            // lblTipoCuentaActual
            // 
            this.lblTipoCuentaActual.AutoSize = true;
            this.lblTipoCuentaActual.Enabled = false;
            this.lblTipoCuentaActual.Location = new System.Drawing.Point(9, 31);
            this.lblTipoCuentaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCuentaActual.Name = "lblTipoCuentaActual";
            this.lblTipoCuentaActual.Size = new System.Drawing.Size(168, 20);
            this.lblTipoCuentaActual.TabIndex = 1;
            this.lblTipoCuentaActual.Text = "Tipo de Cuenta actual:";
            // 
            // checkBoxTipoCuenta
            // 
            this.checkBoxTipoCuenta.AutoSize = true;
            this.checkBoxTipoCuenta.Location = new System.Drawing.Point(156, 0);
            this.checkBoxTipoCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTipoCuenta.Name = "checkBoxTipoCuenta";
            this.checkBoxTipoCuenta.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTipoCuenta.TabIndex = 0;
            this.checkBoxTipoCuenta.UseVisualStyleBackColor = true;
            this.checkBoxTipoCuenta.CheckedChanged += new System.EventHandler(this.checkBoxTipoCuenta_CheckedChanged);
            // 
            // ModificacionCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 475);
            this.Controls.Add(this.btnCambiarTipoCuenta);
            this.Controls.Add(this.groupBoxTipoCuenta);
            this.Controls.Add(this.btnCambiarMoneda);
            this.Controls.Add(this.groupBoxMoneda);
            this.Controls.Add(this.btnCambiarPais);
            this.Controls.Add(this.groupBoxPais);
            this.Controls.Add(this.btnVolver);
            this.Name = "ModificacionCuenta";
            this.Text = "ModificacionCuenta";
            this.groupBoxPais.ResumeLayout(false);
            this.groupBoxPais.PerformLayout();
            this.groupBoxMoneda.ResumeLayout(false);
            this.groupBoxMoneda.PerformLayout();
            this.groupBoxTipoCuenta.ResumeLayout(false);
            this.groupBoxTipoCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCambiarPais;
        private System.Windows.Forms.GroupBox groupBoxPais;
        private System.Windows.Forms.Label lblPaisNuevo;
        private System.Windows.Forms.Label lblPaisViejo;
        private System.Windows.Forms.CheckBox checkBoxPais;
        private System.Windows.Forms.ComboBox cmbPaisNuevo;
        private System.Windows.Forms.Button btnCambiarMoneda;
        private System.Windows.Forms.GroupBox groupBoxMoneda;
        private System.Windows.Forms.ComboBox cmbMonedaNueva;
        private System.Windows.Forms.Label lblMonedaNueva;
        private System.Windows.Forms.Label lblMonedaActual;
        private System.Windows.Forms.CheckBox checkBoxMoneda;
        private System.Windows.Forms.Button btnCambiarTipoCuenta;
        private System.Windows.Forms.GroupBox groupBoxTipoCuenta;
        private System.Windows.Forms.ComboBox cmbTipoCuentaNuevo;
        private System.Windows.Forms.Label lblTipoCuentaNuevo;
        private System.Windows.Forms.Label lblTipoCuentaActual;
        private System.Windows.Forms.CheckBox checkBoxTipoCuenta;
        private System.Windows.Forms.Label lblPaisActual;
        private System.Windows.Forms.Label lblVMonedaActual;
        private System.Windows.Forms.Label lblVTipoCuentaActual;
    }
}