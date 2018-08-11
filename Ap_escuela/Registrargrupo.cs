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
    public partial class Registrargrupo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Registrargrupo()
        {
            InitializeComponent();
        }
        public Grupo GrupoActual { get; set; }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnumerogrupo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Grupo Grupo = new Grupo();
                Grupo.Numerogrupo = txtnumerogrupo.Text;
                Grupo.Horariogrupo = cbhorario.SelectedItem.ToString();// cbhorario.SelectedValue.ToString();
                Grupo.Semestre = txtsemestre.Text;
                Grupo.Horacreacion = DateTime.Now.ToShortDateString();
                                

                int resultado = GrupoDAL.AgregarGrupo(Grupo);
                

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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrargrupo_Load(object sender, EventArgs e)
        {
            //txtsemestre.Text = Convert.ToString(DateTime.Now.ToShortDateString());
        }
    }
}