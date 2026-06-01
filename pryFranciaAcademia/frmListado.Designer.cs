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
            this.btnBuscarList = new System.Windows.Forms.Button();
            this.cmbPlanList = new System.Windows.Forms.ComboBox();
            this.txtNombreList = new System.Windows.Forms.TextBox();
            this.txtCódigoList = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbPlan = new System.Windows.Forms.RadioButton();
            this.tbCódigo = new System.Windows.Forms.RadioButton();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTodo
            // 
            this.rbTodo.AutoSize = true;
            this.rbTodo.Location = new System.Drawing.Point(77, 19);
            this.rbTodo.Name = "rbTodo";
            this.rbTodo.Size = new System.Drawing.Size(50, 17);
            this.rbTodo.TabIndex = 0;
            this.rbTodo.TabStop = true;
            this.rbTodo.Text = "Todo";
            this.rbTodo.UseVisualStyleBackColor = true;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.btnBuscarList);
            this.grpBuscar.Controls.Add(this.cmbPlanList);
            this.grpBuscar.Controls.Add(this.txtNombreList);
            this.grpBuscar.Controls.Add(this.txtCódigoList);
            this.grpBuscar.Controls.Add(this.rbNombre);
            this.grpBuscar.Controls.Add(this.rbPlan);
            this.grpBuscar.Controls.Add(this.tbCódigo);
            this.grpBuscar.Controls.Add(this.rbTodo);
            this.grpBuscar.Location = new System.Drawing.Point(12, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(274, 194);
            this.grpBuscar.TabIndex = 1;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // btnBuscarList
            // 
            this.btnBuscarList.Location = new System.Drawing.Point(182, 165);
            this.btnBuscarList.Name = "btnBuscarList";
            this.btnBuscarList.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarList.TabIndex = 3;
            this.btnBuscarList.Text = "Buscar";
            this.btnBuscarList.UseVisualStyleBackColor = true;
            this.btnBuscarList.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbPlanList
            // 
            this.cmbPlanList.FormattingEnabled = true;
            this.cmbPlanList.Location = new System.Drawing.Point(99, 125);
            this.cmbPlanList.Name = "cmbPlanList";
            this.cmbPlanList.Size = new System.Drawing.Size(146, 21);
            this.cmbPlanList.TabIndex = 6;
            // 
            // txtNombreList
            // 
            this.txtNombreList.Location = new System.Drawing.Point(99, 83);
            this.txtNombreList.Name = "txtNombreList";
            this.txtNombreList.Size = new System.Drawing.Size(146, 20);
            this.txtNombreList.TabIndex = 5;
            // 
            // txtCódigoList
            // 
            this.txtCódigoList.Location = new System.Drawing.Point(99, 42);
            this.txtCódigoList.Name = "txtCódigoList";
            this.txtCódigoList.Size = new System.Drawing.Size(91, 20);
            this.txtCódigoList.TabIndex = 4;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(13, 86);
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
            this.rbPlan.Location = new System.Drawing.Point(13, 125);
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
            this.tbCódigo.Location = new System.Drawing.Point(13, 42);
            this.tbCódigo.Name = "tbCódigo";
            this.tbCódigo.Size = new System.Drawing.Size(58, 17);
            this.tbCódigo.TabIndex = 1;
            this.tbCódigo.TabStop = true;
            this.tbCódigo.Text = "Código";
            this.tbCódigo.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Plan,
            this.Activo});
            this.dgvLista.Location = new System.Drawing.Point(292, 21);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(443, 150);
            this.dgvLista.TabIndex = 2;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Plan
            // 
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(743, 207);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.grpBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTodo;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtNombreList;
        private System.Windows.Forms.TextBox txtCódigoList;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbPlan;
        private System.Windows.Forms.RadioButton tbCódigo;
        private System.Windows.Forms.ComboBox cmbPlanList;
        private System.Windows.Forms.Button btnBuscarList;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}