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
    public partial class frmPrincipal : Form
    {
        public string[] arrPlanes = new string[5];
        public string[,] matMaterias = new string[4, 5];
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mstPrincipal_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlumno ventana = new frmAlumno();
            ventana.ShowDialog();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro ventana = new frmRegistro();
            ventana.arrayPlanes = arrPlanes;
            ventana.matMaterias = matMaterias;
            ventana.ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargaPlan ventana = new frmCargaPlan();
            ventana.arrayPlan = arrPlanes;
            ventana.matMaterias = matMaterias;
            ventana.ShowDialog();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListado ventana = new frmListado();
            ventana.arrayPlanes = arrPlanes;
            ventana.arrListado = matMaterias;
            ventana.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
