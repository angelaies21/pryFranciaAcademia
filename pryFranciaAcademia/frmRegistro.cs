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
        public string[,] matMaterias = new string[4, 5]; //2 dimensiones 
        public string[] arrayPlanes = new string[5];    //1 dimension 

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

        }

        private void btnRegristar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus(); //coloca el cursor en el indicado
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
                
                // pregunta si todavia hay espacio en la matriz

                if (indiceFila < matMaterias.GetLength(0)) //saca la cant de espacios q tiene la matriz,, si td hay filas disp continua
                {
                    matMaterias[indiceFila, 0] = txtCodigo.Text; //pasa lo q esta en los text box a la matriz
                    matMaterias[indiceFila, 1] = txtNombre.Text;
                    matMaterias[indiceFila, 2] = cmbPlan.Text;

                    if (chkActivo.Checked == true) //  checkBox si esta marcando entra al if
                    {
                        matMaterias[indiceFila, 3] = "Activo"; // guarda la palabra activo en la columna 3
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
            for (int i = 0; i < arrayPlanes.Length; i++) //length es la cantida de espacio q tiewn la matriz
            {
                if(arrayPlanes[i] != null) //q no este vacio
                {
                    cmbPlan.Items.Add(arrayPlanes[i]); // agg ese plan al combobox
                }
            }
               cmbPlan.Enabled = true; 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.arrPlanes = arrPlanes;
            ventana.matMaterias = matMaterias;
            ventana.ShowDialog();
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty; //empty vaciar el text box
            txtNombre.Text = string.Empty;
            cmbPlan.Enabled = false;
            chkActivo.Enabled = false;
            cmbPlan.Enabled = false;

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
