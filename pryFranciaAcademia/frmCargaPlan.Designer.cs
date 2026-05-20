namespace pryFranciaAcademia
{
    partial class frmCargaPlan
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
            this.lblPlan = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtNomPlan = new System.Windows.Forms.TextBox();
            this.lstPlanes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(12, 66);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(84, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Nombre del plan";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(40, 112);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(87, 33);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(170, 112);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(92, 33);
            this.btnRegistar.TabIndex = 2;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtNomPlan
            // 
            this.txtNomPlan.Location = new System.Drawing.Point(117, 59);
            this.txtNomPlan.Name = "txtNomPlan";
            this.txtNomPlan.Size = new System.Drawing.Size(145, 20);
            this.txtNomPlan.TabIndex = 3;
            // 
            // lstPlanes
            // 
            this.lstPlanes.FormattingEnabled = true;
            this.lstPlanes.Location = new System.Drawing.Point(40, 175);
            this.lstPlanes.Name = "lstPlanes";
            this.lstPlanes.Size = new System.Drawing.Size(242, 95);
            this.lstPlanes.TabIndex = 5;
            // 
            // frmCargaPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(331, 294);
            this.Controls.Add(this.lstPlanes);
            this.Controls.Add(this.txtNomPlan);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblPlan);
            this.Name = "frmCargaPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargaPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtNomPlan;
        private System.Windows.Forms.ListBox lstPlanes;
    }
}