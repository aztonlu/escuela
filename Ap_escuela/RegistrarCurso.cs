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
    public partial class RegistrarCurso : DevComponents.DotNetBar.Metro.MetroForm
    {
        public RegistrarCurso()
        {
            InitializeComponent();
        }

        public Curso CursoActual { get; set; }
        //public Persona PersonaActual { get; set; }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Curso Curso = new Curso();
                Curso.Idcurso = txtidcurso.Text;
                Curso.Nombrecurso = txtnombrecurso.Text;
                Curso.Numerogrupo = cbnumerogrupo.Text;
                Curso.Dni = Convert.ToInt32(txtdni.Text);
                Curso.Monto = Convert.ToDecimal(txtcosto.Text);


                int resultado = CursoDAL.AgregarCurso(Curso);
                

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

        private void RegistrarCurso_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            int cualquiera = ran.Next(10000);
            txtidcurso.Text = DateTime.Now.Year.ToString() + '-' + DateTime.Now.Month.ToString() + cualquiera;
            CursoDAL cur = new CursoDAL();
            cur.Buscargrupocb(cbnumerogrupo);
            //alu.Buscar(dni, dataGridViewX1); //AlumnoDAL.Buscar(dataGridViewX1);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtdni.Text);
            DocenteDAL asis = new DocenteDAL();
            asis.BuscarDocente(dataGridViewX1,dni);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}