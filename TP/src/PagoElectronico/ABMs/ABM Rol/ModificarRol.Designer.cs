namespace PagoElectronico.ABMs.ABM_Rol
{
    partial class ModificarRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.HabilitarRolCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.RolNombreTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Del Rol:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Funcionalidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(9, 21);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.Size = new System.Drawing.Size(260, 94);
            this.Funcionalidades.TabIndex = 0;
            // 
            // HabilitarRolCheckbox
            // 
            this.HabilitarRolCheckbox.AutoSize = true;
            this.HabilitarRolCheckbox.Location = new System.Drawing.Point(131, 17);
            this.HabilitarRolCheckbox.Name = "HabilitarRolCheckbox";
            this.HabilitarRolCheckbox.Size = new System.Drawing.Size(64, 17);
            this.HabilitarRolCheckbox.TabIndex = 3;
            this.HabilitarRolCheckbox.Text = "Habilitar";
            this.HabilitarRolCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EstadoLabel);
            this.groupBox2.Controls.Add(this.HabilitarRolCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Del Rol";
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Location = new System.Drawing.Point(18, 21);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(50, 13);
            this.EstadoLabel.TabIndex = 4;
            this.EstadoLabel.Text = "\"Estado\"";
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(210, 268);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(104, 35);
            this.ModificarButton.TabIndex = 5;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(33, 268);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(113, 35);
            this.VolverButton.TabIndex = 6;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // RolNombreTextBox
            // 
            this.RolNombreTextBox.Location = new System.Drawing.Point(126, 21);
            this.RolNombreTextBox.Name = "RolNombreTextBox";
            this.RolNombreTextBox.Size = new System.Drawing.Size(129, 20);
            this.RolNombreTextBox.TabIndex = 7;
            this.RolNombreTextBox.Text = "\"NombreActual\"";
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 325);
            this.Controls.Add(this.RolNombreTextBox);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ModificarRol";
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox Funcionalidades;
        private System.Windows.Forms.CheckBox HabilitarRolCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.TextBox RolNombreTextBox;
    }
}