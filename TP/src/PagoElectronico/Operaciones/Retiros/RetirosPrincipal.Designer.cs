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
            this.tipoDocComboBox = new System.Windows.Forms.ComboBox();
            this.nroDoctextBox = new System.Windows.Forms.TextBox();
            this.GenerarRetirobutton = new System.Windows.Forms.Button();
            this.VOLVERbutton = new System.Windows.Forms.Button();
            this.FechaLeyendalabel = new System.Windows.Forms.Label();
            this.fechaValorLabel = new System.Windows.Forms.Label();
            this.bancoLabel = new System.Windows.Forms.Label();
            this.dgvBancos = new System.Windows.Forms.DataGridView();
            this.Banco_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // cuentacomboBox
            // 
            this.cuentacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuentacomboBox.FormattingEnabled = true;
            this.cuentacomboBox.Location = new System.Drawing.Point(246, 97);
            this.cuentacomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuentacomboBox.Name = "cuentacomboBox";
            this.cuentacomboBox.Size = new System.Drawing.Size(300, 28);
            this.cuentacomboBox.TabIndex = 0;
            this.cuentacomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cuentacomboBox_KeyDown);
            // 
            // cuentalabel
            // 
            this.cuentalabel.AutoSize = true;
            this.cuentalabel.Location = new System.Drawing.Point(18, 97);
            this.cuentalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cuentalabel.Name = "cuentalabel";
            this.cuentalabel.Size = new System.Drawing.Size(178, 20);
            this.cuentalabel.TabIndex = 1;
            this.cuentalabel.Text = "Seleccione una Cuenta:";
            // 
            // importelabel
            // 
            this.importelabel.AutoSize = true;
            this.importelabel.Location = new System.Drawing.Point(18, 166);
            this.importelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.importelabel.Name = "importelabel";
            this.importelabel.Size = new System.Drawing.Size(196, 20);
            this.importelabel.TabIndex = 2;
            this.importelabel.Text = "Ingrese un Importe:    US$";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(246, 162);
            this.ImportetextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.Size = new System.Drawing.Size(300, 26);
            this.ImportetextBox.TabIndex = 3;
            this.ImportetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImportetextBox_KeyDown);
            this.ImportetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImportetextBox_KeyPress);
            // 
            // nroDoclabel
            // 
            this.nroDoclabel.AutoSize = true;
            this.nroDoclabel.Location = new System.Drawing.Point(352, 234);
            this.nroDoclabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nroDoclabel.Name = "nroDoclabel";
            this.nroDoclabel.Size = new System.Drawing.Size(133, 20);
            this.nroDoclabel.TabIndex = 4;
            this.nroDoclabel.Text = "Nro. Documento: ";
            // 
            // tipoDocLabel
            // 
            this.tipoDocLabel.AutoSize = true;
            this.tipoDocLabel.Location = new System.Drawing.Point(20, 234);
            this.tipoDocLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoDocLabel.Name = "tipoDocLabel";
            this.tipoDocLabel.Size = new System.Drawing.Size(130, 20);
            this.tipoDocLabel.TabIndex = 5;
            this.tipoDocLabel.Text = "Tipo Documento:";
            // 
            // tipoDocComboBox
            // 
            this.tipoDocComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDocComboBox.FormattingEnabled = true;
            this.tipoDocComboBox.Location = new System.Drawing.Point(162, 230);
            this.tipoDocComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipoDocComboBox.Name = "tipoDocComboBox";
            this.tipoDocComboBox.Size = new System.Drawing.Size(180, 28);
            this.tipoDocComboBox.TabIndex = 6;
            this.tipoDocComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipoDocComboBox_KeyDown);
            // 
            // nroDoctextBox
            // 
            this.nroDoctextBox.Location = new System.Drawing.Point(498, 229);
            this.nroDoctextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nroDoctextBox.Name = "nroDoctextBox";
            this.nroDoctextBox.Size = new System.Drawing.Size(202, 26);
            this.nroDoctextBox.TabIndex = 7;
            this.nroDoctextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nroDoctextBox_KeyDown);
            this.nroDoctextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nroDoctextBox_KeyPress);
            // 
            // GenerarRetirobutton
            // 
            this.GenerarRetirobutton.Location = new System.Drawing.Point(68, 565);
            this.GenerarRetirobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerarRetirobutton.Name = "GenerarRetirobutton";
            this.GenerarRetirobutton.Size = new System.Drawing.Size(276, 66);
            this.GenerarRetirobutton.TabIndex = 10;
            this.GenerarRetirobutton.Text = "Generar Retiro";
            this.GenerarRetirobutton.UseVisualStyleBackColor = true;
            this.GenerarRetirobutton.Click += new System.EventHandler(this.GenerarRetirobutton_Click);
            // 
            // VOLVERbutton
            // 
            this.VOLVERbutton.Location = new System.Drawing.Point(428, 565);
            this.VOLVERbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VOLVERbutton.Name = "VOLVERbutton";
            this.VOLVERbutton.Size = new System.Drawing.Size(290, 66);
            this.VOLVERbutton.TabIndex = 11;
            this.VOLVERbutton.Text = "Volver";
            this.VOLVERbutton.UseVisualStyleBackColor = true;
            this.VOLVERbutton.Click += new System.EventHandler(this.VOLVERbutton_Click);
            // 
            // FechaLeyendalabel
            // 
            this.FechaLeyendalabel.AutoSize = true;
            this.FechaLeyendalabel.Location = new System.Drawing.Point(20, 520);
            this.FechaLeyendalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLeyendalabel.Name = "FechaLeyendalabel";
            this.FechaLeyendalabel.Size = new System.Drawing.Size(62, 20);
            this.FechaLeyendalabel.TabIndex = 12;
            this.FechaLeyendalabel.Text = "Fecha :";
            // 
            // fechaValorLabel
            // 
            this.fechaValorLabel.AutoSize = true;
            this.fechaValorLabel.Location = new System.Drawing.Point(248, 520);
            this.fechaValorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaValorLabel.Name = "fechaValorLabel";
            this.fechaValorLabel.Size = new System.Drawing.Size(95, 20);
            this.fechaValorLabel.TabIndex = 13;
            this.fechaValorLabel.Text = "Valor Fecha";
            // 
            // bancoLabel
            // 
            this.bancoLabel.AutoSize = true;
            this.bancoLabel.Location = new System.Drawing.Point(20, 289);
            this.bancoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bancoLabel.Name = "bancoLabel";
            this.bancoLabel.Size = new System.Drawing.Size(167, 20);
            this.bancoLabel.TabIndex = 14;
            this.bancoLabel.Text = "Seleccione un Banco :";
            // 
            // dgvBancos
            // 
            this.dgvBancos.AllowUserToAddRows = false;
            this.dgvBancos.AllowUserToDeleteRows = false;
            this.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Banco_Codigo,
            this.Banco_Nombre,
            this.Banco_Direccion});
            this.dgvBancos.Location = new System.Drawing.Point(24, 329);
            this.dgvBancos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBancos.Name = "dgvBancos";
            this.dgvBancos.ReadOnly = true;
            this.dgvBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBancos.Size = new System.Drawing.Size(502, 172);
            this.dgvBancos.TabIndex = 15;
            this.dgvBancos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBancos_CellContentClick);
            // 
            // Banco_Codigo
            // 
            this.Banco_Codigo.HeaderText = "Numero de Banco";
            this.Banco_Codigo.Name = "Banco_Codigo";
            this.Banco_Codigo.ReadOnly = true;
            // 
            // Banco_Nombre
            // 
            this.Banco_Nombre.HeaderText = "Nombre Banco";
            this.Banco_Nombre.Name = "Banco_Nombre";
            this.Banco_Nombre.ReadOnly = true;
            // 
            // Banco_Direccion
            // 
            this.Banco_Direccion.HeaderText = "Direccion Banco";
            this.Banco_Direccion.Name = "Banco_Direccion";
            this.Banco_Direccion.ReadOnly = true;
            // 
            // RetirosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 675);
            this.Controls.Add(this.dgvBancos);
            this.Controls.Add(this.bancoLabel);
            this.Controls.Add(this.fechaValorLabel);
            this.Controls.Add(this.FechaLeyendalabel);
            this.Controls.Add(this.VOLVERbutton);
            this.Controls.Add(this.GenerarRetirobutton);
            this.Controls.Add(this.nroDoctextBox);
            this.Controls.Add(this.tipoDocComboBox);
            this.Controls.Add(this.tipoDocLabel);
            this.Controls.Add(this.nroDoclabel);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.importelabel);
            this.Controls.Add(this.cuentalabel);
            this.Controls.Add(this.cuentacomboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RetirosPrincipal";
            this.Text = "RetirosPrincipal";
            this.Load += new System.EventHandler(this.RetirosPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).EndInit();
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
        private System.Windows.Forms.ComboBox tipoDocComboBox;
        private System.Windows.Forms.TextBox nroDoctextBox;
        private System.Windows.Forms.Button GenerarRetirobutton;
        private System.Windows.Forms.Button VOLVERbutton;
        private System.Windows.Forms.Label FechaLeyendalabel;
        private System.Windows.Forms.Label fechaValorLabel;
        private System.Windows.Forms.Label bancoLabel;
        private System.Windows.Forms.DataGridView dgvBancos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco_Direccion;
    }
}