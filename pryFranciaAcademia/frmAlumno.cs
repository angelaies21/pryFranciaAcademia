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
    public partial class frmAlumno : Form
    {

        public string[] arrayPlan = new string[5];
        public string[,] matMaterias = new string[4, 5];
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void volverALaPaginaPrinicipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            //ventana.arrayPlan = arrPlanes;
            ventana.matMaterias = matMaterias;
            ventana.ShowDialog();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
