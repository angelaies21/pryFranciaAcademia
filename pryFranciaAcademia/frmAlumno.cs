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
    public partial class frmAlumno : Form
    {

        string varDNI;
        string varNombre;
        string varApellido;
        string varDireccion;
        string varContacto;


        public string[] arrayPlan = new string[5];
        public string[,] matMaterias = new string[4, 6];
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void volverALaPaginaPrinicipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.matMaterias = matMaterias;
            ventana.ShowDialog();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            // guarda los datos de los txt en la matriz
            matMaterias[0, 0] = txtDni.Text;
            matMaterias[0, 1] = txtNombre.Text;
            matMaterias[0, 2] = txtApellido.Text;
            matMaterias[0, 3] = txtDireccion.Text;
            matMaterias[0, 4] = txtContacto.Text;
            matMaterias[0, 5] = dtpFecha.Text;


            if (txtDni.Text == "")
            {
                MessageBox.Show("Ingrese el DNI" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                txtDni.Focus();
            }
            else
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese el Nombre" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
                else
                {
                    if (txtApellido.Text == "")
                    {
                        MessageBox.Show("Ingrese el Apellido" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                        txtApellido.Focus();
                    }
                    else
                    {
                        if (txtDireccion.Text == "")
                        {
                            MessageBox.Show("Ingrese la Direccion" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                            txtDni.Focus();
                        }
                        else
                        {
                            varDNI = txtDni.Text;
                            varNombre = txtNombre.Text;
                            varApellido = txtApellido.Text;
                            varDireccion = txtDireccion.Text;
                            varContacto = txtContacto.Text;

                            MessageBox.Show(
                                     "Contacto agregado correctamente\n\n" +
                                     "Dni: " + varDNI + "\n" +
                                     "Nombre: " + varNombre + "\n" +
                                     "Apellido: " + varApellido + "\n" +
                                     "Dirección: " + varDireccion + "\n" +
                                     "Contacto: " + varContacto
                                 );
                        }

                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtDni.Text = string.Empty; //empty vaciar el text box
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtContacto.Text = string.Empty; 
            dtpFecha.Enabled = false;

            
            MessageBox.Show("Alumno eliminado.", " Eliminado ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //reemplaza los datos anteriores por los nuevos

            matMaterias[0, 0] = txtDni.Text;
            matMaterias[0, 1] = txtNombre.Text;
            matMaterias[0, 2] = txtApellido.Text;
            matMaterias[0, 3] = txtDireccion.Text;
            matMaterias[0, 4] = txtContacto.Text;
            matMaterias[0, 5] = dtpFecha.Text;

            MessageBox.Show("Alumno editado"," Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
