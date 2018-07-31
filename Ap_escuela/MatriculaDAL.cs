using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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

        public void Buscargrupocb(ComboBox cb)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
                try
                {
                    Grupo pGrupo = new Grupo();
                    SqlCommand comando = new SqlCommand(string.Format("Select idcurso, nombrecurso from tcurso"), conexion);

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        cb.Items.Add(reader["idcurso"]);
                        cb.Items.Add(reader["nombrecurso"]);

                    }
                    conexion.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            
        }

        public void Buscarnombrecursogrupocb(ComboBox cb)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
                try
                {
                    Grupo pGrupo = new Grupo();
                    SqlCommand comando = new SqlCommand(string.Format("Select idcurso from tcurso"), conexion);

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        cb.Items.Add(reader["idcurso"]);

                    }
                    conexion.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }

        }
    }
}
