using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFranciaAcademia
{
    public partial class frmRegristro : Form
    {
        public DateTime varInicioSesion;

        int varInicio;
        string varNombre;
        string VvarPlan;
        bool varActivo;

        public frmRegristro()
        {
            InitializeComponent();
        }

        private void frmRegristro_Load(object sender, EventArgs e)
        {
            cmbPlan.Items.Clear();
            cmbPlan.Items.Add("Plan 1");
            cmbPlan.Items.Add("Plan 2");
            cmbPlan.Items.Add("Plan 3");
            cmbPlan.SelectedIndex = 0;

            
        }

        private void btnRegristar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (cmbPlan.Text == "") 
            {
                MessageBox.Show("Ingrese el Plan.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPlan.Focus();
            }
            else
            {
                string codigo = txtCodigo.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string plan = cmbPlan.Text;
                string 


            }
        }
    }
}
