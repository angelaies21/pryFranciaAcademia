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
    public partial class frmInicio : Form
    {
        public DateTime varInicioSesion;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
           
            varInicioSesion = DateTime.Now; //iniciando la variable
            
            this.Hide();
            frmRegistro regristro = new frmRegistro();
            regristro.varInicioSesion=DateTime.Now;
            regristro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
