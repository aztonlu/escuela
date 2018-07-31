using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
    public class AsistenciaalumnoDAL
    {
        public static int Agregarasistencia(Asistenciaalumno pAsistenciaalumno)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tasistenciaalumno (dni, numerogrupo, idcurso, fecha) values ('{0}', '{1}','{2}','{3}')",
                    pAsistenciaalumno.Dni, pAsistenciaalumno.Numerogrupo, pAsistenciaalumno.Idcurso, pAsistenciaalumno.Fecha), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
