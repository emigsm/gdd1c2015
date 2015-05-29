namespace PagoElectronico.Operaciones.Asociacion_TC
{
    partial class AltaTarjeta
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
            this.EmisorTarjetaCombobox = new System.Windows.Forms.ComboBox();
            this.leyendaClienteIDLabel = new System.Windows.Forms.Label();
            this.clienteIDValorLabel = new System.Windows.Forms.Label();
            this.emisorTarjetaLabel = new System.Windows.Forms.Label();
            this.DarAltaBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmisorTarjetaCombobox
            // 
            this.EmisorTarjetaCombobox.FormattingEnabled = true;
            this.EmisorTarjetaCombobox.Location = new System.Drawing.Point(112, 70);
            this.EmisorTarjetaCombobox.Name = "EmisorTarjetaCombobox";
            this.EmisorTarjetaCombobox.Size = new System.Drawing.Size(174, 21);
            this.EmisorTarjetaCombobox.TabIndex = 0;
            // 
            // leyendaClienteIDLabel
            // 
            this.leyendaClienteIDLabel.AutoSize = true;
            this.leyendaClienteIDLabel.Location = new System.Drawing.Point(22, 26);
            this.leyendaClienteIDLabel.Name = "leyendaClienteIDLabel";
            this.leyendaClienteIDLabel.Size = new System.Drawing.Size(56, 13);
            this.leyendaClienteIDLabel.TabIndex = 1;
            this.leyendaClienteIDLabel.Text = "Cliente ID:";
            // 
            // clienteIDValorLabel
            // 
            this.clienteIDValorLabel.AutoSize = true;
            this.clienteIDValorLabel.Location = new System.Drawing.Point(109, 26);
            this.clienteIDValorLabel.Name = "clienteIDValorLabel";
            this.clienteIDValorLabel.Size = new System.Drawing.Size(69, 13);
            this.clienteIDValorLabel.TabIndex = 2;
            this.clienteIDValorLabel.Text = "ID del cliente";
            // 
            // emisorTarjetaLabel
            // 
            this.emisorTarjetaLabel.AutoSize = true;
            this.emisorTarjetaLabel.Location = new System.Drawing.Point(25, 77);
            this.emisorTarjetaLabel.Name = "emisorTarjetaLabel";
            this.emisorTarjetaLabel.Size = new System.Drawing.Size(77, 13);
            this.emisorTarjetaLabel.TabIndex = 3;
            this.emisorTarjetaLabel.Text = "Emisor Tarjeta:";
            // 
            // DarAltaBtn
            // 
            this.DarAltaBtn.Location = new System.Drawing.Point(25, 128);
            this.DarAltaBtn.Name = "DarAltaBtn";
            this.DarAltaBtn.Size = new System.Drawing.Size(172, 28);
            this.DarAltaBtn.TabIndex = 4;
            this.DarAltaBtn.Text = "Dar Alta Tarjeta";
            this.DarAltaBtn.UseVisualStyleBackColor = true;
            this.DarAltaBtn.Click += new System.EventHandler(this.DarAltaBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(220, 123);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(180, 33);
            this.volverBtn.TabIndex = 5;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // AltaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.DarAltaBtn);
            this.Controls.Add(this.emisorTarjetaLabel);
            this.Controls.Add(this.clienteIDValorLabel);
            this.Controls.Add(this.leyendaClienteIDLabel);
            this.Controls.Add(this.EmisorTarjetaCombobox);
            this.Name = "AltaTarjeta";
            this.Text = "AltaTarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EmisorTarjetaCombobox;
        private System.Windows.Forms.Label leyendaClienteIDLabel;
        private System.Windows.Forms.Label clienteIDValorLabel;
        private System.Windows.Forms.Label emisorTarjetaLabel;
        private System.Windows.Forms.Button DarAltaBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label label1;
    }
}