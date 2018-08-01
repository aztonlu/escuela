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
    public partial class seleccion : DevComponents.DotNetBar.Metro.MetroForm
    {
        public seleccion()
        {
            InitializeComponent();
        }

        private void metroregistraralumnos_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            Form2 formularioregistro = new Form2();
            formularioregistro.Show();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            RegistroDocentes registrodoc = new RegistroDocentes();
            registrodoc.Show();
        }

        private void metroTileItem10_Click(object sender, EventArgs e)
        {
            Registrargrupo grupo = new Registrargrupo();
            grupo.Show();
        }

        private void metroTileItem11_Click(object sender, EventArgs e)
        {
            RegistrarCurso curso = new RegistrarCurso();
            curso.Show();
        }

        private void metroTileItem16_Click(object sender, EventArgs e)
        {
            AgregarMatricula matricula = new AgregarMatricula();
            matricula.Show();
        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {
            RegistrarAsistenciaAlumno asistencia = new RegistrarAsistenciaAlumno();
            asistencia.Show();
        }

        private void metroTileItem5_Click(object sender, EventArgs e)
        {
            RegistrarPagoCurso pagocurso = new RegistrarPagoCurso();
            pagocurso.Show();
        }

        private void metroTileItem6_Click(object sender, EventArgs e)
        {
            RegistroPagoDocente pagodocente = new RegistroPagoDocente();
            pagodocente.Show();
        }

        private void metroTileItem12_Click(object sender, EventArgs e)
        {
            BusquedaAlumno busqueda = new BusquedaAlumno();
            busqueda.Show();
        }

        private void metroTilePanel1_ItemClick(object sender, EventArgs e)
        {

        }

        private void metroTileItem13_Click(object sender, EventArgs e)
        {
            Buscar bus = new Buscar();
            bus.Show();
        }
    }
}