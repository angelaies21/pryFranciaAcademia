namespace pryFranciaAcademia
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListado = new System.Windows.Forms.ToolStripMenuItem();
            this.mstPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistro,
            this.btnListado});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.Size = new System.Drawing.Size(495, 25);
            this.mstPrincipal.TabIndex = 1;
            this.mstPrincipal.Text = "f";
            this.mstPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnRegistro
            // 
            this.btnRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlumno,
            this.btnMateria,
            this.btnPlan});
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(69, 21);
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.Click += new System.EventHandler(this.mstPrincipal_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(140, 22);
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(140, 22);
            this.btnMateria.Text = "Materia";
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(140, 22);
            this.btnPlan.Text = "Carga plan";
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnListado
            // 
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(62, 21);
            this.btnListado.Text = "Listado";
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 426);
            this.Controls.Add(this.mstPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pag principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnRegistro;
        private System.Windows.Forms.ToolStripMenuItem btnListado;
        private System.Windows.Forms.ToolStripMenuItem btnAlumno;
        private System.Windows.Forms.ToolStripMenuItem btnMateria;
        private System.Windows.Forms.ToolStripMenuItem btnPlan;
    }
}