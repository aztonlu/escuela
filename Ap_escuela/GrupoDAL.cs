using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
    class GrupoDAL
    {
        public static int AgregarGrupo(Grupo pGrupo)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tgrupo (numerogrupo, horariogrupo, semestre, horariocreacion) values ('{0}', '{1}','{2}','{3}')",
                    pGrupo.Numerogrupo, pGrupo.Horariogrupo, pGrupo.Semestre, pGrupo.Horacreacion), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
    }
}
