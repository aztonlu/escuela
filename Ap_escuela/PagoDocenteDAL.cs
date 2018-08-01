using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ap_escuela
{
    class PagoDocenteDAL
    {
        public static int Registrarpago(PagoDocente pPagoDocente)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tpagodocente (idpago, numerogrupo, idcurso, dni, monto, fecha, nrorecibo, estado, observacion) values ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                    pPagoDocente.Idpago, pPagoDocente.Numerogrupo, pPagoDocente.Idcurso, pPagoDocente.Dni, pPagoDocente.Monto, pPagoDocente.Fecha, pPagoDocente.Nrorecibo, pPagoDocente.Estado, pPagoDocente.Observacion), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }

        DataTable dt;
        SqlDataAdapter da;

        public void Buscarcarga(int dni, DataGridView dgv)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())

                try
                {
                    //da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni), conexion);
                    da = new SqlDataAdapter(string.Format("Select tcurso.numerogrupo AS Grupo, tcurso.idcurso AS Codigo_Curso from tcurso inner join tdocente on tcurso.dni = tdocente.dni where tcurso.dni like '%{0}%'", dni), conexion);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
        }
    }
}
