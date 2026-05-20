namespace pryFranciaAcademia
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.rbTodo = new System.Windows.Forms.RadioButton();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbPlan = new System.Windows.Forms.RadioButton();
            this.tbCódigo = new System.Windows.Forms.RadioButton();
            this.grpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTodo
            // 
            this.rbTodo.AutoSize = true;
            this.rbTodo.Location = new System.Drawing.Point(41, 42);
            this.rbTodo.Name = "rbTodo";
            this.rbTodo.Size = new System.Drawing.Size(50, 17);
            this.rbTodo.TabIndex = 0;
            this.rbTodo.TabStop = true;
            this.rbTodo.Text = "Todo";
            this.rbTodo.UseVisualStyleBackColor = true;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.cmbPlan);
            this.grpBuscar.Controls.Add(this.txtNombre);
            this.grpBuscar.Controls.Add(this.txtCódigo);
            this.grpBuscar.Controls.Add(this.rbNombre);
            this.grpBuscar.Controls.Add(this.rbPlan);
            this.grpBuscar.Controls.Add(this.tbCódigo);
            this.grpBuscar.Controls.Add(this.rbTodo);
            this.grpBuscar.Location = new System.Drawing.Point(32, 26);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(307, 228);
            this.grpBuscar.TabIndex = 1;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // cmbPlan
            // 
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(127, 183);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(146, 21);
            this.cmbPlan.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(127, 92);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(146, 20);
            this.txtCódigo.TabIndex = 4;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(41, 137);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 3;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbPlan
            // 
            this.rbPlan.AutoSize = true;
            this.rbPlan.Location = new System.Drawing.Point(45, 179);
            this.rbPlan.Name = "rbPlan";
            this.rbPlan.Size = new System.Drawing.Size(46, 17);
            this.rbPlan.TabIndex = 2;
            this.rbPlan.TabStop = true;
            this.rbPlan.Text = "Plan";
            this.rbPlan.UseVisualStyleBackColor = true;
            // 
            // tbCódigo
            // 
            this.tbCódigo.AutoSize = true;
            this.tbCódigo.Location = new System.Drawing.Point(41, 92);
            this.tbCódigo.Name = "tbCódigo";
            this.tbCódigo.Size = new System.Drawing.Size(58, 17);
            this.tbCódigo.TabIndex = 1;
            this.tbCódigo.TabStop = true;
            this.tbCódigo.Text = "Código";
            this.tbCódigo.UseVisualStyleBackColor = true;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(368, 287);
            this.Controls.Add(this.grpBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTodo;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbPlan;
        private System.Windows.Forms.RadioButton tbCódigo;
        private System.Windows.Forms.ComboBox cmbPlan;
    }
}