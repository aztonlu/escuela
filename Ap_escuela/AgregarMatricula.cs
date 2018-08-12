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

                Random ran = new Random();
                int cualquiera = ran.Next(10000);
                //MessageBox.Show(Convert.ToString(DateTime.Today.ToShortDateString()));
                //("alu" + DateTime.Today.ToShortDateString() + DateTime.Today.Second.ToString() + cualquiera);

                decimal cuenta = 0;
                PagoCurso Pago = new PagoCurso();
                Pago.Idpago = "alu" + DateTime.Today.ToShortDateString() + DateTime.Today.Second.ToString() + cualquiera; // txtidpago.Text;
                Pago.Numerogrupo = txtnumerogrupo.Text;
                Pago.Idcurso = txtidcurso.Text;
                Pago.Dni = Convert.ToInt32(txtdni.Text);
                Pago.Monto = Convert.ToDecimal(txtcostocurso.Text);// Convert.ToDecimal(txtmonto.Text);
                Pago.Cuenta = cuenta;// Convert.ToDecimal(txtcuenta.Text);
                Pago.Fecha = DateTime.Today.ToShortDateString(); // monthCalendarAdv1.SelectedDate.ToShortDateString();
                Pago.Nrorecibo = "0"; //txtnumerorecibo.Text;
                //Pago.Estado = txtestado.Text;
                //Pago.Observacion = txtobservacion.Text;


                //int resultado = 
                    PagoCursoDAL.AgregarPagocurso(Pago);
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
            CursoDAL cur = new CursoDAL();
            cur.Buscarsemestrecb(cbsemestre);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             //MessageBox.Show(Convert.ToString(cbidcurso.Items[1]));
            /*Random ran = new Random();
            int cualquiera = ran.Next(10000);
            MessageBox.Show(Convert.ToString(DateTime.Today.ToShortDateString()));
            MessageBox.Show("alu" + DateTime.Today.ToShortDateString() + DateTime.Today.Second.ToString()+cualquiera);*/
            txtdni.Text = "";
            txtidcurso.Text = "";
            txtnombrecurso.Text = "";
            txtnumerogrupo.Text = "";
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
            string dato4;
            decimal dec;
            dato = (String)dataGridViewX1.CurrentRow.Cells[0].Value; //CurrentCell.Value.ToString(); //Rows[0].Cells[0].Value.ToString();
            dato2 = (String)dataGridViewX1.CurrentRow.Cells[1].Value; //.CurrentCell.Value.ToString();
            dato3 = (String)dataGridViewX1.CurrentRow.Cells[2].Value;
            dato4 = Convert.ToString((String)dataGridViewX1.CurrentRow.Cells[5].Value);
            txtidcurso.Text = dato;
            txtnombrecurso.Text = dato2;
            txtnumerogrupo.Text = dato3;
            txthorariocurso.Text = dato4;
            dec = ((decimal)dataGridViewX1.CurrentRow.Cells[4].Value);
            txtcostocurso.Text = Convert.ToString(dec);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtdni.Text);
            AlumnoDAL asis = new AlumnoDAL();
            asis.Buscar(dni,dataGridViewX2); // .Buscar (dataGridViewX2,dni); // .BuscarDocente(dataGridViewX1, dni);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscarsemestre_Click(object sender, EventArgs e)
        {
            MatriculaDAL matri = new MatriculaDAL();
            //matri.Buscargrupocb(cbnombrecurso);
            matri.Buscarcargamatricula(dataGridViewX1, cbsemestre.Text);

            //CursoDAL cur = new CursoDAL();
            //cur.Buscargrupocb(cbnumerogrupo, cbsemestre.Text);

        }
    }
}