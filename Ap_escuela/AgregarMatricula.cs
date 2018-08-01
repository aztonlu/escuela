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
                Matricula.Numerogrupo = txtnumerogrupo.Text; //cbnumerogrupo.Text;
                Matricula.Idcurso = txtidcurso.Text; //cbidcurso.Text;
                Matricula.Dni = Convert.ToInt32(txtdni.Text);
                Matricula.Fecha = Convert.ToString(DateTime.Today.ToShortDateString());

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

        private void AgregarMatricula_Load(object sender, EventArgs e)
        {
            MatriculaDAL matri = new MatriculaDAL();
            matri.Buscargrupocb(cbnombrecurso);

            matri.Buscarcarga(dataGridViewX1);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             //MessageBox.Show(Convert.ToString(cbidcurso.Items[1]));
            MessageBox.Show(Convert.ToString(DateTime.Today.ToShortDateString()));
        }

        private void cbnombrecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            String numero;
            switch (num)
            {
                case 1:
                    numero = "uno";
                    break;
                case 2:
                    numero = "dos";
                    break;
                case 3:
                    numero = "tres";
                    break;
                case 4:
                    numero = "cuatro";
                    break;
                case 5:
                    numero = "cinco";
                    break;
                default:
                    numero = "error";
                    break;
            }*/
        }

        private void dataGridViewX1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dato;
            string dato2;
            string dato3;
            dato = (String)dataGridViewX1.CurrentRow.Cells[0].Value; //CurrentCell.Value.ToString(); //Rows[0].Cells[0].Value.ToString();
            dato2 = (String)dataGridViewX1.CurrentRow.Cells[1].Value; //.CurrentCell.Value.ToString();
            dato3 = (String)dataGridViewX1.CurrentRow.Cells[2].Value;
            txtidcurso.Text = dato;
            txtnombrecurso.Text = dato2;
            txtnumerogrupo.Text = dato3;
        }
    }
}