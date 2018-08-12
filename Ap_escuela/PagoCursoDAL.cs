using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ap_escuela
{
    class PagoCursoDAL
    {
        public static int AgregarPagocurso(PagoCurso pPagoCurso)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tpagocurso (idpago, numerogrupo, idcurso, dni, monto, cuenta, fecha, nrorecibo, estado, observacion) values ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    pPagoCurso.Idpago, pPagoCurso.Numerogrupo, pPagoCurso.Idcurso, pPagoCurso.Dni, pPagoCurso.Monto, pPagoCurso.Cuenta, pPagoCurso.Fecha, pPagoCurso.Nrorecibo, pPagoCurso.Estado, pPagoCurso.Observacion), Conn);

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
                    da = new SqlDataAdapter(string.Format("select tmatricula.numerogrupo AS Grupo, tmatricula.idcurso AS Codigo_Curso, tcurso.nombrecurso AS Nombre_Curso, tcurso.monto AS Costo_Curso, tcurso.monto - SUM(tpagocurso.cuenta) AS Saldo, tpagocurso.fecha AS Fecha_Ultimo_Pago from tpagocurso inner join tmatricula on tpagocurso.idcurso = tmatricula.idcurso inner join tcurso on tpagocurso.idcurso = tcurso.idcurso where tmatricula.dni like '%{0}%' group by tmatricula.numerogrupo, tpagocurso.monto, tmatricula.idcurso, tcurso.nombrecurso,tcurso.monto, tpagocurso.fecha", dni), conexion);
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
