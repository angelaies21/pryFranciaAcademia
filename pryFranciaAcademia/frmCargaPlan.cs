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
        string[] arrayPlan = new string[4];

        int varIndice = 0;

        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayPlan.Length; i++)
            {
                lstPlanes.Items.Add(arrayPlan[i]);

            }
        }
    }
}
