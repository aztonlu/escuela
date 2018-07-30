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
    }
}