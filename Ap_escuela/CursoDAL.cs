using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Ap_escuela
{
    public class CursoDAL
    {


        public static int AgregarCurso(Curso pCurso)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tcurso (idcurso, nombrecurso, numerogrupo, dni, monto) values ('{0}', '{1}','{2}','{3}','{4}')",
                    pCurso.Idcurso, pCurso.Nombrecurso, pCurso.Numerogrupo, pCurso.Dni, pCurso.Monto), Conn);

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
                    SqlCommand comando = new SqlCommand(string.Format("Select numerogrupo from tgrupo"), conexion);

                    SqlDataReader reader = comando.ExecuteReader();

                    //da = new SqlDataAdapter(string.Format("Select numerogrupo from tgrupo"), conexion);
                    //dt = new DataTable();
                    //da.Fill(dt);
                    //cb.DataSource = dt;
                    //dgv.DataSource = dt;

                    //Alumno pAlumno = new Alumno();
                    //SqlCommand comando = new SqlCommand(string.Format(
                      //  "Select Id, Nombre,  Apellido, Direccion, Fecha_nacimiento from Alumnos where Id={0}", pId), conexion);

                    //SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        cb.Items.Add(reader["numerogrupo"]);
                        
                    }
                    conexion.Close();
                    //return pGrupo;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
        }
    }
}
