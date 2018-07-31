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
    public partial class RegistroPagoDocente : DevComponents.DotNetBar.Metro.MetroForm
    {
        public RegistroPagoDocente()
        {
            InitializeComponent();
        }
        public PagoDocente PagoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PagoDocente Pago = new PagoDocente();
                Pago.Idpago = txtidpago.Text;
                Pago.Numerogrupo = txtnumerogrupo.Text;
                Pago.Idcurso = txtidcurso.Text;
                Pago.Dni = Convert.ToInt32(txtdni.Text);
                Pago.Monto = Convert.ToDecimal(txtmonto.Text);
                Pago.Fecha = monthCalendarAdv1.SelectedDate.ToShortDateString();
                Pago.Nrorecibo = txtnumerorecibo.Text;
                Pago.Estado = txtestado.Text;
                Pago.Observacion = txtobservacion.Text;


                int resultado = PagoDocenteDAL.Registrarpago(Pago); //RegistrarPagoDocente.Registrarpago(Pago);

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
    }
}