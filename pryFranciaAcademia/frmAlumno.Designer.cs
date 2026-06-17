namespace pryFranciaAcademia
{
    partial class frmAlumno
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.brnVolver = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brnVolver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // brnVolver
            // 
            this.brnVolver.Name = "brnVolver";
            this.brnVolver.Size = new System.Drawing.Size(163, 20);
            this.brnVolver.Text = "volver a la pagina prinicipal";
            this.brnVolver.Click += new System.EventHandler(this.volverALaPaginaPrinicipalToolStripMenuItem_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 46);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 127);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Location = new System.Drawing.Point(177, 67);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(52, 13);
            this.lblDirección.TabIndex = 4;
            this.lblDirección.Text = "Dirección";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(179, 109);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 5;
            this.lblContacto.Text = "Contacto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(27, 173);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(124, 15);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Nacimiento";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(62, 43);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 7;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(62, 124);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(243, 67);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(244, 109);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(131, 20);
            this.txtContacto.TabIndex = 11;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(42, 232);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(86, 31);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = " Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(151, 232);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 31);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(271, 232);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 31);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(169, 173);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 15;
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(12, 280);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(421, 95);
            this.lstAlumnos.TabIndex = 16;
            this.lstAlumnos.Visible = false;
            this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(502, 428);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem brnVolver;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lstAlumnos;
    }
}