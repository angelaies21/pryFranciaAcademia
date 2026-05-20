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
    public partial class frmRegistro : Form
    {
        public DateTime varInicioSesion;

        int varCodigo;
        string varNombre;
        string varPlan;
        bool varActivo;

        public frmRegistro()
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
            frmRegistro ventana = new frmRegistro();
            ventana.Show();
            this.Hide();

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
                //varCodigo = Convert.ToInt32(txtCodigo.Text);
                //varNombre = txtNombre.Text.Trim();
                //varPlan = cmbPlan.Text;
                
                int indiceFila =0;
                string[,] matMaterias = new string[2,5];

                matMaterias[indiceFila,0]= txtCodigo.Text;
                matMaterias[indiceFila, 1] = txtNombre.Text;
                matMaterias[indiceFila, 2] = cmbPlan.Text;

                if (chkActivo.Checked == true)
                {
                    matMaterias[indiceFila, 3] = "Activo";
                    varActivo = true;
                }
                else
                {
                    matMaterias[indiceFila, 3] = "Inactivo";
                    varActivo=false;
                }
                indiceFila++;
            }
        }
    }
}
