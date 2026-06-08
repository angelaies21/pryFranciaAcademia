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
            for (int i = 0; i < arrListado.GetLength(0); i++) // getLength= te consigue la cant de cosas q tiene el array
            {
                if (arrListado[i,0] != null)
                {
                    dgvLista.Rows.Add(arrListado[i, 0], arrListado[i, 1], arrListado[i, 2], arrListado[i, 3]);
                }
        }
       }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana=new frmPrincipal();
            ventana.arrPlanes = arrayPlanes;
            ventana.matMaterias = arrListado;
            ventana.ShowDialog();
        }
    }
}
