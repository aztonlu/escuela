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
    public partial class RegistrarAsistenciaAlumno : DevComponents.DotNetBar.Metro.MetroForm
    {
        public RegistrarAsistenciaAlumno()
        {
            InitializeComponent();
        }
        public Asistenciaalumno AsistenciaActual { get; set; }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Asistenciaalumno Asistencia = new Asistenciaalumno();
                Asistencia.Dni = Convert.ToInt32(txtdni.Text);
                Asistencia.Numerogrupo = txtnumerogrupo.Text;
                Asistencia.Idcurso = txtidcurso.Text;
                Asistencia.Fecha = monthCalendarAdv1.SelectedDate.ToShortDateString();




                int resultado = AsistenciaalumnoDAL.Agregarasistencia(Asistencia);
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

        private void RegistrarAsistenciaAlumno_Load(object sender, EventArgs e)
        {
            AsistenciaalumnoDAL asis = new AsistenciaalumnoDAL();
            asis.Buscarcarga(dataGridViewX1);
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dato;
            string dato2;
            string dato3;
            //dato = (String)dataGridViewX1.CurrentRow.Cells[0].Value; //CurrentCell.Value.ToString(); //Rows[0].Cells[0].Value.ToString();
            dato2 = (String)dataGridViewX1.CurrentRow.Cells[1].Value; //.CurrentCell.Value.ToString();
            dato3 = (String)dataGridViewX1.CurrentRow.Cells[2].Value;
            txtidcurso.Text = dato3;
            //txtnombrecurso.Text = dato2;
            txtnumerogrupo.Text = dato2;
        }
    }
}