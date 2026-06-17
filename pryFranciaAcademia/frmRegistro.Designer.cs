namespace pryFranciaAcademia
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.btnPlanEstudio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnVolver = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(35, 49);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(35, 158);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(34, 16);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(35, 213);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(44, 16);
            this.lblActivo.TabIndex = 3;
            this.lblActivo.Text = "Activo";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(123, 213);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListado.Location = new System.Drawing.Point(25, 287);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(83, 31);
            this.btnListado.TabIndex = 7;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Location = new System.Drawing.Point(114, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrar.Location = new System.Drawing.Point(207, 287);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(77, 31);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegristar_Click);
            // 
            // cmbPlan
            // 
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Items.AddRange(new object[] {
            "Plan 1",
            "Plan 2",
            "Plan 3"});
            this.cmbPlan.Location = new System.Drawing.Point(114, 153);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(148, 21);
            this.cmbPlan.TabIndex = 10;
            this.cmbPlan.SelectedIndexChanged += new System.EventHandler(this.cmbPlan_SelectedIndexChanged);
            // 
            // btnPlanEstudio
            // 
            this.btnPlanEstudio.Location = new System.Drawing.Point(162, 235);
            this.btnPlanEstudio.Name = "btnPlanEstudio";
            this.btnPlanEstudio.Size = new System.Drawing.Size(122, 23);
            this.btnPlanEstudio.TabIndex = 13;
            this.btnPlanEstudio.Text = "Cargar plan de estudio";
            this.btnPlanEstudio.UseVisualStyleBackColor = true;
            this.btnPlanEstudio.Click += new System.EventHandler(this.btnPlanEstudio_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVolver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnVolver
            // 
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 20);
            this.btnVolver.Text = "Volver a la pagina principal";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(300, 327);
            this.Controls.Add(this.btnPlanEstudio);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.frmRegristro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Button btnPlanEstudio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnVolver;
    }
}