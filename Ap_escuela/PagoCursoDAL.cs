using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

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
    }
}
