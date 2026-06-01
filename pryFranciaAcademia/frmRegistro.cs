using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFranciaAcademia
{
    public partial class frmRegistro : Form
    {
        int indiceFila = 0;
        string[,] matMaterias = new string[4, 5];

        public DateTime varInicioSesion;

        int varCodigo;
        string varNombre;
        string varPlan;
        bool varActivo;

        public string[] arrPlanes = new string[5];

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
                


                if (indiceFila < matMaterias.GetLength(0))
                {
                    matMaterias[indiceFila, 0] = txtCodigo.Text;
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
                        varActivo = false;
                    }
                    indiceFila++;

                    MessageBox.Show("Registro guardado");

                    txtCodigo.Clear();
                    txtNombre.Clear();
                    cmbPlan.Text = "";
                    chkActivo.Checked = false;
                }
                else
                {
                    MessageBox.Show("Limite alcanzado");
                    btnRegistrar.Enabled = false;
                    btnListado.Enabled = true;
                }
            }  
        }

        private void btnPlanEstudio_Click(object sender, EventArgs e)
        {
            frmCargaPlan ventana = new frmCargaPlan();
            ventana.Show();
            this.Hide();

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado ventana = new frmListado();

            ventana.arrListado = matMaterias;
            ventana.ShowDialog();
           // this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            cmbPlan.Items.Clear();
            for (int i = 0; i < arrPlanes.Length; i++)
            {
                if(arrPlanes[i] != null)
                {
                    cmbPlan.Items.Add(arrPlanes[i]);
                }
            }
               cmbPlan.Enabled = true; 
        }
    }
}
