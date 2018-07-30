using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
    public class DocenteDAL
    {
        public static int AgregarDocente(Docente pDocente)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tdocente (dni, perfil) values ('{0}', '{1}')",
                    pDocente.Dni, pDocente.Perfil), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
