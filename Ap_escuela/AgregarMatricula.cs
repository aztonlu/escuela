using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Ap_escuela
{
    public partial class AgregarMatricula : DevComponents.DotNetBar.Metro.MetroForm
    {
        public AgregarMatricula()
        {
            InitializeComponent();
        }

        public Matricula MatriculaActual { get; set; }
        

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Matricula Matricula = new Matricula();
                Matricula.Numerogrupo = txtnumerogrupo.Text;
                Matricula.Idcurso = txtidcurso.Text;
                Matricula.Dni = Convert.ToInt32(txtdni.Text);

                int resultado = MatriculaDAL.AgregarMatricula(Matricula);
                //PersonaDAL.AgregarPersona(Persona);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnlimpiar();

                }

                else
                {
                    MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}