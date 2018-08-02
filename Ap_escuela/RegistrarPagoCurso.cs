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
    public partial class RegistrarPagoCurso : DevComponents.DotNetBar.Metro.MetroForm
    {
        public RegistrarPagoCurso()
        {
            InitializeComponent();
        }
        public PagoCurso PagoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PagoCurso Pago = new PagoCurso();
                Pago.Idpago = txtidpago.Text;
                Pago.Numerogrupo = txtnumerogrupo.Text;
                Pago.Idcurso = txtidcurso.Text;
                Pago.Dni = Convert.ToInt32(txtdni.Text);
                Pago.Monto = Convert.ToDecimal(txtmonto.Text);
                Pago.Cuenta = Convert.ToDecimal(txtcuenta.Text);
                Pago.Fecha = monthCalendarAdv1.SelectedDate.ToShortDateString();
                Pago.Nrorecibo = txtnumerorecibo.Text;
                Pago.Estado = txtestado.Text;
                Pago.Observacion = txtobservacion.Text;


                int resultado = PagoCursoDAL.AgregarPagocurso(Pago);
                
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

        private void btndni_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtdni.Text);
            PagoCursoDAL pago = new PagoCursoDAL();
            pago.Buscarcarga(dni, dataGridViewX1); //AlumnoDAL.Buscar(dataGridViewX1);
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dato;
            string dato2,dato3,dato4, dato5;
            dato = (String)dataGridViewX1.CurrentRow.Cells[0].Value; //CurrentCell.Value.ToString(); //Rows[0].Cells[0].Value.ToString();
            dato2 = (String)dataGridViewX1.CurrentRow.Cells[1].Value; //.CurrentCell.Value.ToString();
            dato3 = (String)dataGridViewX1.CurrentRow.Cells[2].Value; //.CurrentCell.Value.ToString();
            dato4 = Convert.ToString((Decimal)dataGridViewX1.CurrentRow.Cells[3].Value); //.CurrentCell.Value.ToString();
            dato5 = Convert.ToString((Decimal)dataGridViewX1.CurrentRow.Cells[4].Value); //.CurrentCell.Value.ToString();
            
            txtidcurso.Text = dato2;
            txtnombrecurso.Text = dato3;
            txtnumerogrupo.Text = dato;
            txtmonto.Text = dato4;
            txtsaldo.Text = dato5;
        }
    }
}