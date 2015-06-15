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
            this.SuspendLayout();
            // 
            // EmisorTarjetaCombobox
            // 
            this.EmisorTarjetaCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmisorTarjetaCombobox.FormattingEnabled = true;
            this.EmisorTarjetaCombobox.Location = new System.Drawing.Point(168, 110);
            this.EmisorTarjetaCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmisorTarjetaCombobox.Name = "EmisorTarjetaCombobox";
            this.EmisorTarjetaCombobox.Size = new System.Drawing.Size(259, 28);
            this.EmisorTarjetaCombobox.TabIndex = 0;
            // 
            // leyendaClienteIDLabel
            // 
            this.leyendaClienteIDLabel.AutoSize = true;
            this.leyendaClienteIDLabel.Location = new System.Drawing.Point(33, 40);
            this.leyendaClienteIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leyendaClienteIDLabel.Name = "leyendaClienteIDLabel";
            this.leyendaClienteIDLabel.Size = new System.Drawing.Size(83, 20);
            this.leyendaClienteIDLabel.TabIndex = 1;
            this.leyendaClienteIDLabel.Text = "Cliente ID:";
            // 
            // clienteIDValorLabel
            // 
            this.clienteIDValorLabel.AutoSize = true;
            this.clienteIDValorLabel.Location = new System.Drawing.Point(164, 40);
            this.clienteIDValorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteIDValorLabel.Name = "clienteIDValorLabel";
            this.clienteIDValorLabel.Size = new System.Drawing.Size(101, 20);
            this.clienteIDValorLabel.TabIndex = 2;
            this.clienteIDValorLabel.Text = "ID del cliente";
            // 
            // emisorTarjetaLabel
            // 
            this.emisorTarjetaLabel.AutoSize = true;
            this.emisorTarjetaLabel.Location = new System.Drawing.Point(38, 118);
            this.emisorTarjetaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emisorTarjetaLabel.Name = "emisorTarjetaLabel";
            this.emisorTarjetaLabel.Size = new System.Drawing.Size(115, 20);
            this.emisorTarjetaLabel.TabIndex = 3;
            this.emisorTarjetaLabel.Text = "Emisor Tarjeta:";
            // 
            // DarAltaBtn
            // 
            this.DarAltaBtn.Location = new System.Drawing.Point(38, 197);
            this.DarAltaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DarAltaBtn.Name = "DarAltaBtn";
            this.DarAltaBtn.Size = new System.Drawing.Size(258, 43);
            this.DarAltaBtn.TabIndex = 4;
            this.DarAltaBtn.Text = "Dar Alta Tarjeta";
            this.DarAltaBtn.UseVisualStyleBackColor = true;
            this.DarAltaBtn.Click += new System.EventHandler(this.DarAltaBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(330, 189);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(270, 51);
            this.volverBtn.TabIndex = 5;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // AltaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 288);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.DarAltaBtn);
            this.Controls.Add(this.emisorTarjetaLabel);
            this.Controls.Add(this.clienteIDValorLabel);
            this.Controls.Add(this.leyendaClienteIDLabel);
            this.Controls.Add(this.EmisorTarjetaCombobox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}