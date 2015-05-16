namespace PagoElectronico.ABMs.ABM_Cliente
{
    partial class NuevoCliente
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
            this.NombreNuevoLabel = new System.Windows.Forms.Label();
            this.apellidoNuevoClilabel = new System.Windows.Forms.Label();
            this.TipoDocLabel = new System.Windows.Forms.Label();
            this.TipoDNuevocomboBox = new System.Windows.Forms.ComboBox();
            this.NroDocnuevoLabel = new System.Windows.Forms.Label();
            this.NroDocnuevoClitextBox = new System.Windows.Forms.TextBox();
            this.ApellidoNuevoClitextBox = new System.Windows.Forms.TextBox();
            this.NombreNuevoClitextBox = new System.Windows.Forms.TextBox();
            this.Mailnuevolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreNuevoLabel
            // 
            this.NombreNuevoLabel.AutoSize = true;
            this.NombreNuevoLabel.Location = new System.Drawing.Point(13, 32);
            this.NombreNuevoLabel.Name = "NombreNuevoLabel";
            this.NombreNuevoLabel.Size = new System.Drawing.Size(47, 13);
            this.NombreNuevoLabel.TabIndex = 0;
            this.NombreNuevoLabel.Text = "Nombre:";
            // 
            // apellidoNuevoClilabel
            // 
            this.apellidoNuevoClilabel.AutoSize = true;
            this.apellidoNuevoClilabel.Location = new System.Drawing.Point(13, 61);
            this.apellidoNuevoClilabel.Name = "apellidoNuevoClilabel";
            this.apellidoNuevoClilabel.Size = new System.Drawing.Size(47, 13);
            this.apellidoNuevoClilabel.TabIndex = 1;
            this.apellidoNuevoClilabel.Text = "Apellido:";
            // 
            // TipoDocLabel
            // 
            this.TipoDocLabel.AutoSize = true;
            this.TipoDocLabel.Location = new System.Drawing.Point(13, 92);
            this.TipoDocLabel.Name = "TipoDocLabel";
            this.TipoDocLabel.Size = new System.Drawing.Size(54, 13);
            this.TipoDocLabel.TabIndex = 2;
            this.TipoDocLabel.Text = "Tipo Doc:";
            // 
            // TipoDNuevocomboBox
            // 
            this.TipoDNuevocomboBox.FormattingEnabled = true;
            this.TipoDNuevocomboBox.Location = new System.Drawing.Point(74, 92);
            this.TipoDNuevocomboBox.Name = "TipoDNuevocomboBox";
            this.TipoDNuevocomboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoDNuevocomboBox.TabIndex = 3;
            // 
            // NroDocnuevoLabel
            // 
            this.NroDocnuevoLabel.AutoSize = true;
            this.NroDocnuevoLabel.Location = new System.Drawing.Point(216, 95);
            this.NroDocnuevoLabel.Name = "NroDocnuevoLabel";
            this.NroDocnuevoLabel.Size = new System.Drawing.Size(50, 13);
            this.NroDocnuevoLabel.TabIndex = 4;
            this.NroDocnuevoLabel.Text = "Nro Doc:";
            // 
            // NroDocnuevoClitextBox
            // 
            this.NroDocnuevoClitextBox.Location = new System.Drawing.Point(272, 95);
            this.NroDocnuevoClitextBox.Name = "NroDocnuevoClitextBox";
            this.NroDocnuevoClitextBox.Size = new System.Drawing.Size(131, 20);
            this.NroDocnuevoClitextBox.TabIndex = 5;
            // 
            // ApellidoNuevoClitextBox
            // 
            this.ApellidoNuevoClitextBox.Location = new System.Drawing.Point(74, 58);
            this.ApellidoNuevoClitextBox.Name = "ApellidoNuevoClitextBox";
            this.ApellidoNuevoClitextBox.Size = new System.Drawing.Size(148, 20);
            this.ApellidoNuevoClitextBox.TabIndex = 6;
            // 
            // NombreNuevoClitextBox
            // 
            this.NombreNuevoClitextBox.Location = new System.Drawing.Point(74, 24);
            this.NombreNuevoClitextBox.Name = "NombreNuevoClitextBox";
            this.NombreNuevoClitextBox.Size = new System.Drawing.Size(148, 20);
            this.NombreNuevoClitextBox.TabIndex = 7;
            // 
            // Mailnuevolabel
            // 
            this.Mailnuevolabel.AutoSize = true;
            this.Mailnuevolabel.Location = new System.Drawing.Point(16, 120);
            this.Mailnuevolabel.Name = "Mailnuevolabel";
            this.Mailnuevolabel.Size = new System.Drawing.Size(29, 13);
            this.Mailnuevolabel.TabIndex = 8;
            this.Mailnuevolabel.Text = "Mail:";
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 416);
            this.Controls.Add(this.Mailnuevolabel);
            this.Controls.Add(this.NombreNuevoClitextBox);
            this.Controls.Add(this.ApellidoNuevoClitextBox);
            this.Controls.Add(this.NroDocnuevoClitextBox);
            this.Controls.Add(this.NroDocnuevoLabel);
            this.Controls.Add(this.TipoDNuevocomboBox);
            this.Controls.Add(this.TipoDocLabel);
            this.Controls.Add(this.apellidoNuevoClilabel);
            this.Controls.Add(this.NombreNuevoLabel);
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreNuevoLabel;
        private System.Windows.Forms.Label apellidoNuevoClilabel;
        private System.Windows.Forms.Label TipoDocLabel;
        private System.Windows.Forms.ComboBox TipoDNuevocomboBox;
        private System.Windows.Forms.Label NroDocnuevoLabel;
        private System.Windows.Forms.TextBox NroDocnuevoClitextBox;
        private System.Windows.Forms.TextBox ApellidoNuevoClitextBox;
        private System.Windows.Forms.TextBox NombreNuevoClitextBox;
        private System.Windows.Forms.Label Mailnuevolabel;
    }
}