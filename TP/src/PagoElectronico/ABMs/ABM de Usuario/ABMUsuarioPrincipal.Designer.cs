namespace PagoElectronico.ABMs.ABM_de_Usuario
{
    partial class ABMUsuarioPrincipal
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Fecha_Ultima_Modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usuario_Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(69, 54);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 1;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(69, 18);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(188, 20);
            this.txtBuscarUsuario.TabIndex = 2;
            this.txtBuscarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarUsuaio_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiarUsuario);
            this.panel1.Controls.Add(this.txtBuscarUsuario);
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 89);
            this.panel1.TabIndex = 3;
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(150, 54);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(107, 23);
            this.btnLimpiarUsuario.TabIndex = 3;
            this.btnLimpiarUsuario.Text = "Limpiar Búsqueda";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario_ID,
            this.Usuario_Username,
            this.Usuario_Fecha_Creacion,
            this.Usuario_Fecha_Ultima_Modificacion,
            this.Modificar,
            this.Eliminar,
            this.Usuario_Habilitado});
            this.dgvUsuario.Location = new System.Drawing.Point(12, 117);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.Size = new System.Drawing.Size(704, 150);
            this.dgvUsuario.TabIndex = 4;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // Usuario_ID
            // 
            this.Usuario_ID.HeaderText = "ID";
            this.Usuario_ID.Name = "Usuario_ID";
            this.Usuario_ID.ReadOnly = true;
            // 
            // Usuario_Username
            // 
            this.Usuario_Username.HeaderText = "Usuario";
            this.Usuario_Username.Name = "Usuario_Username";
            this.Usuario_Username.ReadOnly = true;
            // 
            // Usuario_Fecha_Creacion
            // 
            this.Usuario_Fecha_Creacion.HeaderText = "Fecha_Creacion";
            this.Usuario_Fecha_Creacion.Name = "Usuario_Fecha_Creacion";
            this.Usuario_Fecha_Creacion.ReadOnly = true;
            // 
            // Usuario_Fecha_Ultima_Modificacion
            // 
            this.Usuario_Fecha_Ultima_Modificacion.HeaderText = "Ultima_Modificacion";
            this.Usuario_Fecha_Ultima_Modificacion.Name = "Usuario_Fecha_Ultima_Modificacion";
            this.Usuario_Fecha_Ultima_Modificacion.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Usuario_Habilitado
            // 
            this.Usuario_Habilitado.HeaderText = "Habilitado";
            this.Usuario_Habilitado.Name = "Usuario_Habilitado";
            this.Usuario_Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuario_Habilitado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Usuario_Habilitado.TrueValue = "True";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(596, 272);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(345, 33);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(324, 38);
            this.btnNuevoUsuario.TabIndex = 6;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // ABMUsuarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 297);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "ABMUsuarioPrincipal";
            this.Text = "ABM de Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Fecha_Creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Fecha_Ultima_Modificacion;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Usuario_Habilitado;

    }
}