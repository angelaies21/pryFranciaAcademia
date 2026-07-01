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
    public partial class frmCargaPlan : Form
    {
       
        //crea la memoria y declara los espacios --> new string[4]
        public string[] arrayPlan = new string[5];
        public string[,] matMaterias = new string[4, 5];
        int varIndice = 0;
        

        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtNomPlan.Text != "")
            {
                if (varIndice < 5) //se carga datos hasta llegar a 5
                {
                    arrayPlan[varIndice] = txtNomPlan.Text; //textx box a la matriz
                    varIndice++;
                    MessageBox.Show("Plan guardado", "Dato guardado ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomPlan.Clear();
                }
                else
                {
                    MessageBox.Show("Limite alcanzado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
            lstPlanes.Items.Clear(); //lstPlanes muestra los datos
           
            for (int i = 0; i < arrayPlan.Length; i++) //length es la cantida de espacio q tiewn la matriz
            {
                if (arrayPlan[i] != null)
                {
                    lstPlanes.Items.Add(arrayPlan[i]);
                } 
            }
        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {

        }

        private void lstPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.arrPlanes = arrayPlan;
            ventana.matMaterias = matMaterias;
            ventana.ShowDialog();
        }

        private void txtNomPlan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
