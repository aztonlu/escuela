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
        DataTable dt;
        SqlDataAdapter da;
        public static int AgregarMatricula(Matricula pMatricula)
        {
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tmatricula (numerogrupo, idcurso, dni, fecha) values ('{0}', '{1}','{2}','{3}')",
                    pMatricula.Numerogrupo, pMatricula.Idcurso, pMatricula.Dni, pMatricula.Fecha), Conn);

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
                    //SqlCommand comando = new SqlCommand(string.Format("Select idcurso, nombrecurso from tcurso"), conexion);
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

        public void Buscarcarga(DataGridView dgv)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())

                try
                {
                    //da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni), conexion);
                    da = new SqlDataAdapter(string.Format("Select idcurso AS Codigo_Curso, nombrecurso AS Nombre_Curso, numerogrupo AS Grupo, dni AS DNI_Docente from tcurso"), conexion);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
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
