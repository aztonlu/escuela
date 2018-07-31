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
    public partial class BusquedaAlumno : DevComponents.DotNetBar.Metro.MetroForm
    {
        public BusquedaAlumno()
        {
            InitializeComponent();
        }
        public Alumno AlumnoSeleccionado { get; set; }
        public Persona personaSeleccionado { get; set; }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //dataGridViewX1.DataSource =  AlumnoDAL.BuscarAlumnos(txtdni.Text);
            int dni = 85245;
            AlumnoDAL alu = new AlumnoDAL();
            alu.Buscar(dni, dataGridViewX1); //AlumnoDAL.Buscar(dataGridViewX1);
        }
    }
}