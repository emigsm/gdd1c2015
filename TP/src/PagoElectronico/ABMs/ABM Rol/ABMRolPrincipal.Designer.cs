namespace PagoElectronico.ABMs.ABM_Rol
{
    partial class ABMRolPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LimpiarBusquedaButton = new System.Windows.Forms.Button();
            this.BuscarRolesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rol_NombreTextBox = new System.Windows.Forms.TextBox();
            this.Rol_CodTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VolverButton = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.Rol_Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol_Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ModificarButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CrearRolButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LimpiarBusquedaButton);
            this.panel1.Controls.Add(this.BuscarRolesButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Rol_NombreTextBox);
            this.panel1.Controls.Add(this.Rol_CodTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 129);
            this.panel1.TabIndex = 0;
            // 
            // LimpiarBusquedaButton
            // 
            this.LimpiarBusquedaButton.Location = new System.Drawing.Point(271, 87);
            this.LimpiarBusquedaButton.Name = "LimpiarBusquedaButton";
            this.LimpiarBusquedaButton.Size = new System.Drawing.Size(113, 23);
            this.LimpiarBusquedaButton.TabIndex = 5;
            this.LimpiarBusquedaButton.Text = "Limpiar Búsqueda";
            this.LimpiarBusquedaButton.UseVisualStyleBackColor = true;
            this.LimpiarBusquedaButton.Click += new System.EventHandler(this.LimpiarBusquedaButton_Click);
            // 
            // BuscarRolesButton
            // 
            this.BuscarRolesButton.Location = new System.Drawing.Point(145, 87);
            this.BuscarRolesButton.Name = "BuscarRolesButton";
            this.BuscarRolesButton.Size = new System.Drawing.Size(107, 23);
            this.BuscarRolesButton.TabIndex = 4;
            this.BuscarRolesButton.Text = "Buscar";
            this.BuscarRolesButton.UseVisualStyleBackColor = true;
            this.BuscarRolesButton.Click += new System.EventHandler(this.BuscarRolesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código del Rol";
            // 
            // Rol_NombreTextBox
            // 
            this.Rol_NombreTextBox.Location = new System.Drawing.Point(145, 48);
            this.Rol_NombreTextBox.Name = "Rol_NombreTextBox";
            this.Rol_NombreTextBox.Size = new System.Drawing.Size(113, 20);
            this.Rol_NombreTextBox.TabIndex = 1;
            this.Rol_NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rol_NombreTextBox_KeyPress);
            // 
            // Rol_CodTextBox
            // 
            this.Rol_CodTextBox.Location = new System.Drawing.Point(145, 14);
            this.Rol_CodTextBox.Name = "Rol_CodTextBox";
            this.Rol_CodTextBox.Size = new System.Drawing.Size(113, 20);
            this.Rol_CodTextBox.TabIndex = 0;
            this.Rol_CodTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rol_CodTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilice los filtros para buscar un rol en particular.";
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(535, 374);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(147, 33);
            this.VolverButton.TabIndex = 2;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol_Cod,
            this.Rol_Nombre,
            this.Rol_Habilitado,
            this.ModificarButton,
            this.EliminarButton});
            this.dgvRoles.Location = new System.Drawing.Point(22, 212);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(543, 147);
            this.dgvRoles.TabIndex = 3;
            this.dgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            // 
            // Rol_Cod
            // 
            this.Rol_Cod.Frozen = true;
            this.Rol_Cod.HeaderText = "Código";
            this.Rol_Cod.Name = "Rol_Cod";
            this.Rol_Cod.ReadOnly = true;
            // 
            // Rol_Nombre
            // 
            this.Rol_Nombre.Frozen = true;
            this.Rol_Nombre.HeaderText = "Nombre";
            this.Rol_Nombre.Name = "Rol_Nombre";
            this.Rol_Nombre.ReadOnly = true;
            // 
            // Rol_Habilitado
            // 
            this.Rol_Habilitado.Frozen = true;
            this.Rol_Habilitado.HeaderText = "Habilitado";
            this.Rol_Habilitado.Name = "Rol_Habilitado";
            this.Rol_Habilitado.ReadOnly = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Frozen = true;
            this.ModificarButton.HeaderText = "Modificar";
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.ReadOnly = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Frozen = true;
            this.EliminarButton.HeaderText = "Eliminar";
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.ReadOnly = true;
            // 
            // CrearRolButton
            // 
            this.CrearRolButton.Location = new System.Drawing.Point(466, 67);
            this.CrearRolButton.Name = "CrearRolButton";
            this.CrearRolButton.Size = new System.Drawing.Size(193, 71);
            this.CrearRolButton.TabIndex = 4;
            this.CrearRolButton.Text = "Crear Nuevo Rol";
            this.CrearRolButton.UseVisualStyleBackColor = true;
            this.CrearRolButton.Click += new System.EventHandler(this.CrearRolButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puede crear un nuevo rol utilizando el respectivo botón";
            // 
            // ABMRolPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CrearRolButton);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ABMRolPrincipal";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.ABMRolPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LimpiarBusquedaButton;
        private System.Windows.Forms.Button BuscarRolesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rol_NombreTextBox;
        private System.Windows.Forms.TextBox Rol_CodTextBox;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button CrearRolButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rol_Habilitado;
        private System.Windows.Forms.DataGridViewButtonColumn ModificarButton;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarButton;
    }
}