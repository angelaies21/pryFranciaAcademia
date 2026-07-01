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
    public partial class frmListado : Form
    {
        public string[,] arrListado = new string[4, 5];
        public string[] arrayPlanes = new string[5];

        int sms = 0;
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear(); //rows son las filas
            sms = 0; //cuando buscas de nuevo no toma el valor aumentado, se reinicia
            for (int i = 0; i < arrListado.GetLength(0); i++) // getLength= te consigue la cant de cosas q tiene el array
            {
                if (arrListado[i, 0] != null)
                {

                    if (rbTodo.Checked)
                    {
                        dgvLista.Rows.Add(arrListado[i, 0], arrListado[i, 1], arrListado[i, 2], arrListado[i, 3]);
                    }

                    if (rbCódigo.Checked && arrListado[i, 0] == txtCódigoList.Text)
                    {
                        dgvLista.Rows.Add(arrListado[i, 0], arrListado[i, 1], arrListado[i, 2], arrListado[i, 3]);
                        sms++;

                    }
                    if (rbNombre.Checked && arrListado[i, 1] == txtNombreList.Text)
                    {
                        dgvLista.Rows.Add(arrListado[i, 0], arrListado[i, 1], arrListado[i, 2], arrListado[i, 3]);
                        sms++;
                    }
                    if (rbPlan.Checked && arrListado[i, 2] == cmbPlanList.Text)
                    {
                        dgvLista.Rows.Add(arrListado[i, 0], arrListado[i, 1], arrListado[i, 2], arrListado[i, 3]);
                        sms++;
                    }
                }
            }
            if (rbTodo.Checked = false && sms == 0)
            {
                MessageBox.Show("Dato no encontrado","Busqueda de materia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.arrPlanes = arrayPlanes;
            ventana.matMaterias = arrListado; //pasa de un formulario a otro el array
            ventana.ShowDialog();
        }

        private void grpBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void txtCódigoList_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCódigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCódigo.Checked)
            {
                txtCódigoList.Enabled = true;
            }
            else
            {
                txtCódigoList.Enabled = false;

            }

        }

        private void txtNombreList_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked)
            {
                txtNombreList.Enabled = true;

            }
            else
            {
                txtNombreList.Enabled = false;
            }
        }

        private void rbPlan_CheckedChanged(object sender, EventArgs e)
        {
          if (rbPlan.Checked)
            {
                cmbPlanList.Enabled = true;

            }
            else
            {
                cmbPlanList.Enabled = false;
            }
        }
    }
}
