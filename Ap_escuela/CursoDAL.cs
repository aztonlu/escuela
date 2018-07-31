using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
    class CursoDAL
    {
        public static int AgregarCurso(Curso pCurso)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tcurso (idcurso, nombrecurso, numerogrupo, dni) values ('{0}', '{1}','{2}','{3}')",
                    pCurso.Idcurso, pCurso.Nombrecurso, pCurso.Numerogrupo, pCurso.Dni), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
