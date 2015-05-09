namespace PagoElectronico.ABMs.ABM_Cliente
{
    partial class ABMClientePrincipal
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoClienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteLabek = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.tipoDocComboBox = new System.Windows.Forms.ComboBox();
            this.tipoDocLabel = new System.Windows.Forms.Label();
            this.nroDocLabel = new System.Windows.Forms.Label();
            this.nroDocTextBox = new System.Windows.Forms.TextBox();
            this.nuevoClienteButton = new System.Windows.Forms.Button();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.ModificarClienteButton = new System.Windows.Forms.Button();
            this.volverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(22, 281);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(485, 176);
            this.dgvClientes.TabIndex = 0;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.Location = new System.Drawing.Point(135, 23);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(114, 20);
            this.nombreClienteTextBox.TabIndex = 1;
            this.nombreClienteTextBox.TextChanged += new System.EventHandler(this.nombreClienteTextBox_TextChanged);
            // 
            // ApellidoClienteTextBox
            // 
            this.ApellidoClienteTextBox.Location = new System.Drawing.Point(135, 62);
            this.ApellidoClienteTextBox.Name = "ApellidoClienteTextBox";
            this.ApellidoClienteTextBox.Size = new System.Drawing.Size(114, 20);
            this.ApellidoClienteTextBox.TabIndex = 2;
            // 
            // nombreClienteLabek
            // 
            this.nombreClienteLabek.AutoSize = true;
            this.nombreClienteLabek.Location = new System.Drawing.Point(13, 30);
            this.nombreClienteLabek.Name = "nombreClienteLabek";
            this.nombreClienteLabek.Size = new System.Drawing.Size(44, 13);
            this.nombreClienteLabek.TabIndex = 3;
            this.nombreClienteLabek.Text = "Nombre";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(16, 65);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(44, 13);
            this.apellidoLabel.TabIndex = 4;
            this.apellidoLabel.Text = "Apellido";
            // 
            // tipoDocComboBox
            // 
            this.tipoDocComboBox.FormattingEnabled = true;
            this.tipoDocComboBox.Location = new System.Drawing.Point(135, 99);
            this.tipoDocComboBox.Name = "tipoDocComboBox";
            this.tipoDocComboBox.Size = new System.Drawing.Size(55, 21);
            this.tipoDocComboBox.TabIndex = 5;
            // 
            // tipoDocLabel
            // 
            this.tipoDocLabel.AutoSize = true;
            this.tipoDocLabel.Location = new System.Drawing.Point(16, 102);
            this.tipoDocLabel.Name = "tipoDocLabel";
            this.tipoDocLabel.Size = new System.Drawing.Size(86, 13);
            this.tipoDocLabel.TabIndex = 6;
            this.tipoDocLabel.Text = "Tipo Documento";
            // 
            // nroDocLabel
            // 
            this.nroDocLabel.AutoSize = true;
            this.nroDocLabel.Location = new System.Drawing.Point(222, 102);
            this.nroDocLabel.Name = "nroDocLabel";
            this.nroDocLabel.Size = new System.Drawing.Size(82, 13);
            this.nroDocLabel.TabIndex = 7;
            this.nroDocLabel.Text = "Nro Documento";
            // 
            // nroDocTextBox
            // 
            this.nroDocTextBox.Location = new System.Drawing.Point(310, 99);
            this.nroDocTextBox.Name = "nroDocTextBox";
            this.nroDocTextBox.Size = new System.Drawing.Size(139, 20);
            this.nroDocTextBox.TabIndex = 8;
            // 
            // nuevoClienteButton
            // 
            this.nuevoClienteButton.Location = new System.Drawing.Point(225, 181);
            this.nuevoClienteButton.Name = "nuevoClienteButton";
            this.nuevoClienteButton.Size = new System.Drawing.Size(86, 70);
            this.nuevoClienteButton.TabIndex = 9;
            this.nuevoClienteButton.Text = "Nuevo Cliente";
            this.nuevoClienteButton.UseVisualStyleBackColor = true;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(19, 139);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(26, 13);
            this.mailLabel.TabIndex = 10;
            this.mailLabel.Text = "Mail";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(135, 136);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(114, 20);
            this.mailTextBox.TabIndex = 11;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(22, 181);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(168, 32);
            this.buscarButton.TabIndex = 12;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(19, 219);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(171, 32);
            this.limpiarButton.TabIndex = 13;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarClienteButton
            // 
            this.ModificarClienteButton.Location = new System.Drawing.Point(329, 181);
            this.ModificarClienteButton.Name = "ModificarClienteButton";
            this.ModificarClienteButton.Size = new System.Drawing.Size(79, 70);
            this.ModificarClienteButton.TabIndex = 14;
            this.ModificarClienteButton.Text = "Modificar Cliente";
            this.ModificarClienteButton.UseVisualStyleBackColor = true;
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(432, 181);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(75, 70);
            this.volverButton.TabIndex = 15;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // ABMClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 479);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.ModificarClienteButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.nuevoClienteButton);
            this.Controls.Add(this.nroDocTextBox);
            this.Controls.Add(this.nroDocLabel);
            this.Controls.Add(this.tipoDocLabel);
            this.Controls.Add(this.tipoDocComboBox);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.nombreClienteLabek);
            this.Controls.Add(this.ApellidoClienteTextBox);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(this.dgvClientes);
            this.Name = "ABMClientePrincipal";
            this.Text = "ABMClientePrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox ApellidoClienteTextBox;
        private System.Windows.Forms.Label nombreClienteLabek;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.ComboBox tipoDocComboBox;
        private System.Windows.Forms.Label tipoDocLabel;
        private System.Windows.Forms.Label nroDocLabel;
        private System.Windows.Forms.TextBox nroDocTextBox;
        private System.Windows.Forms.Button nuevoClienteButton;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button ModificarClienteButton;
        private System.Windows.Forms.Button volverButton;


        public ABMClientePrincipal()
        {
            InitializeComponent();
        }

    }
}