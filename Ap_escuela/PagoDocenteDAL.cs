using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

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
    }
}
