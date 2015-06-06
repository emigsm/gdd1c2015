namespace PagoElectronico.Operaciones.Listados
{
    partial class ListadosPrincipal
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
            this.GBListados = new System.Windows.Forms.GroupBox();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cmbListados = new System.Windows.Forms.ComboBox();
            this.lblSeleccionListado = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.GBListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // GBListados
            // 
            this.GBListados.Controls.Add(this.cmbTrimestre);
            this.GBListados.Controls.Add(this.lblTrimestre);
            this.GBListados.Controls.Add(this.cmbAnio);
            this.GBListados.Controls.Add(this.lblAño);
            this.GBListados.Controls.Add(this.cmbListados);
            this.GBListados.Controls.Add(this.lblSeleccionListado);
            this.GBListados.Location = new System.Drawing.Point(13, 14);
            this.GBListados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBListados.Name = "GBListados";
            this.GBListados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBListados.Size = new System.Drawing.Size(637, 140);
            this.GBListados.TabIndex = 1;
            this.GBListados.TabStop = false;
            this.GBListados.Text = "Listado Estadistico";
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Location = new System.Drawing.Point(310, 29);
            this.cmbTrimestre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(121, 28);
            this.cmbTrimestre.TabIndex = 9;
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(220, 34);
            this.lblTrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(79, 20);
            this.lblTrimestre.TabIndex = 8;
            this.lblTrimestre.Text = "Trimestre:";
            // 
            // cmbAnio
            // 
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(62, 29);
            this.cmbAnio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(148, 28);
            this.cmbAnio.TabIndex = 7;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(9, 34);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(42, 20);
            this.lblAño.TabIndex = 6;
            this.lblAño.Text = "Año:";
            // 
            // cmbListados
            // 
            this.cmbListados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListados.FormattingEnabled = true;
            this.cmbListados.Location = new System.Drawing.Point(9, 91);
            this.cmbListados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbListados.Name = "cmbListados";
            this.cmbListados.Size = new System.Drawing.Size(620, 28);
            this.cmbListados.TabIndex = 5;
            // 
            // lblSeleccionListado
            // 
            this.lblSeleccionListado.AutoSize = true;
            this.lblSeleccionListado.Location = new System.Drawing.Point(9, 66);
            this.lblSeleccionListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionListado.Name = "lblSeleccionListado";
            this.lblSeleccionListado.Size = new System.Drawing.Size(159, 20);
            this.lblSeleccionListado.TabIndex = 4;
            this.lblSeleccionListado.Text = "Seleccione el Listado";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(658, 105);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 35);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(658, 61);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(658, 16);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(112, 35);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(13, 164);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(900, 435);
            this.dgvResultados.TabIndex = 8;
            // 
            // ListadosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 609);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.GBListados);
            this.Name = "ListadosPrincipal";
            this.Text = "ListadosPrincipal";
            this.GBListados.ResumeLayout(false);
            this.GBListados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBListados;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cmbListados;
        private System.Windows.Forms.Label lblSeleccionListado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvResultados;

    }
}