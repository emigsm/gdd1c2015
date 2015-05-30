namespace PagoElectronico.Operaciones.Retiros
{
    partial class RetirosPrincipal
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
            this.cuentacomboBox = new System.Windows.Forms.ComboBox();
            this.cuentalabel = new System.Windows.Forms.Label();
            this.importelabel = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.nroDoclabel = new System.Windows.Forms.Label();
            this.tipoDocLabel = new System.Windows.Forms.Label();
            this.tipoDoccomboBox = new System.Windows.Forms.ComboBox();
            this.nroDoctextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cuentacomboBox
            // 
            this.cuentacomboBox.FormattingEnabled = true;
            this.cuentacomboBox.Location = new System.Drawing.Point(167, 60);
            this.cuentacomboBox.Name = "cuentacomboBox";
            this.cuentacomboBox.Size = new System.Drawing.Size(201, 21);
            this.cuentacomboBox.TabIndex = 0;
            // 
            // cuentalabel
            // 
            this.cuentalabel.AutoSize = true;
            this.cuentalabel.Location = new System.Drawing.Point(12, 63);
            this.cuentalabel.Name = "cuentalabel";
            this.cuentalabel.Size = new System.Drawing.Size(121, 13);
            this.cuentalabel.TabIndex = 1;
            this.cuentalabel.Text = "Seleccione una Cuenta:";
            // 
            // importelabel
            // 
            this.importelabel.AutoSize = true;
            this.importelabel.Location = new System.Drawing.Point(15, 105);
            this.importelabel.Name = "importelabel";
            this.importelabel.Size = new System.Drawing.Size(131, 13);
            this.importelabel.TabIndex = 2;
            this.importelabel.Text = "Ingrese un Importe:    US$";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(167, 102);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.Size = new System.Drawing.Size(201, 20);
            this.ImportetextBox.TabIndex = 3;
            this.ImportetextBox.TextChanged += new System.EventHandler(this.ImportetextBox_TextChanged);
            // 
            // nroDoclabel
            // 
            this.nroDoclabel.AutoSize = true;
            this.nroDoclabel.Location = new System.Drawing.Point(235, 152);
            this.nroDoclabel.Name = "nroDoclabel";
            this.nroDoclabel.Size = new System.Drawing.Size(91, 13);
            this.nroDoclabel.TabIndex = 4;
            this.nroDoclabel.Text = "Nro. Documento: ";
            // 
            // tipoDocLabel
            // 
            this.tipoDocLabel.AutoSize = true;
            this.tipoDocLabel.Location = new System.Drawing.Point(13, 152);
            this.tipoDocLabel.Name = "tipoDocLabel";
            this.tipoDocLabel.Size = new System.Drawing.Size(89, 13);
            this.tipoDocLabel.TabIndex = 5;
            this.tipoDocLabel.Text = "Tipo Documento:";
            // 
            // tipoDoccomboBox
            // 
            this.tipoDoccomboBox.FormattingEnabled = true;
            this.tipoDoccomboBox.Location = new System.Drawing.Point(108, 149);
            this.tipoDoccomboBox.Name = "tipoDoccomboBox";
            this.tipoDoccomboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoDoccomboBox.TabIndex = 6;
            // 
            // nroDoctextBox
            // 
            this.nroDoctextBox.Location = new System.Drawing.Point(332, 149);
            this.nroDoctextBox.Name = "nroDoctextBox";
            this.nroDoctextBox.Size = new System.Drawing.Size(136, 20);
            this.nroDoctextBox.TabIndex = 7;
            // 
            // RetirosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 335);
            this.Controls.Add(this.nroDoctextBox);
            this.Controls.Add(this.tipoDoccomboBox);
            this.Controls.Add(this.tipoDocLabel);
            this.Controls.Add(this.nroDoclabel);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.importelabel);
            this.Controls.Add(this.cuentalabel);
            this.Controls.Add(this.cuentacomboBox);
            this.Name = "RetirosPrincipal";
            this.Text = "RetirosPrincipal";
            this.Load += new System.EventHandler(this.RetirosPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cuentacomboBox;
        private System.Windows.Forms.Label cuentalabel;
        private System.Windows.Forms.Label importelabel;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label nroDoclabel;
        private System.Windows.Forms.Label tipoDocLabel;
        private System.Windows.Forms.ComboBox tipoDoccomboBox;
        private System.Windows.Forms.TextBox nroDoctextBox;
    }
}