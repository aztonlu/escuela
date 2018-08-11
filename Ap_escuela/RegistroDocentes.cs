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
    public partial class RegistroDocentes : DevComponents.DotNetBar.Metro.MetroForm
    {
        public RegistroDocentes()
        {
            InitializeComponent();
        }
        
        public Docente DocenteActual { get; set; }
        public Persona PersonaActual { get; set; }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtappat.Text == "" || txtdireccion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Docente Docente = new Docente();
                Docente.Dni = Convert.ToInt32(txtdni.Text);
                Docente.Perfil = txtappat.Text;


                Persona Persona = new Persona();
                Persona.Dni = Convert.ToInt32(txtdni.Text);
                Persona.Nombre = txtnombre.Text;
                Persona.Appat = txtappat.Text;
                Persona.Apmat = txtapmat.Text;
                Persona.Fecha_Nac = monthCalendarAdv1.SelectedDate.ToShortDateString();// MinDate.ToString(); //dtfecha.Value.ToShortDateString();
                Persona.Telefono = Convert.ToInt32(txttelefono.Text);
                Persona.Correo = txtcorreo.Text;
                Persona.Direccion = txtdireccion.Text;



                int resultado = DocenteDAL.AgregarDocente(Docente);
                PersonaDAL.AgregarPersona(Persona);

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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtapmat.Text = "";
            txtappat.Text = "";
            txtcorreo.Text = "";
            txtdireccion.Text = "";
            txtdni.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
            txtdni.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}