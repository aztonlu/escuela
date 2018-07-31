using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
    class MatriculaDAL
    {
        public static int AgregarMatricula(Matricula pMatricula)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tmatricula (numerogrupo, idcurso, dni) values ('{0}', '{1}','{2}')",
                    pMatricula.Numerogrupo, pMatricula.Idcurso, pMatricula.Dni), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
