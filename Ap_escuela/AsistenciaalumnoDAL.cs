using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ap_escuela
{
    public class AsistenciaalumnoDAL
    {
        DataTable dt;
        SqlDataAdapter da;

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

        public void Buscarcarga(DataGridView dgv, int dni)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())

                try
                {
                    //da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni), conexion);
                    da = new SqlDataAdapter(string.Format("Select dni AS DNI_Alumno, numerogrupo AS Grupo, idcurso AS Codigo_Curso, fecha AS Fecha from tasistenciaalumno where tasistenciaalumno.dni like '%{0}%'", dni), conexion);
                    //da = new SqlDataAdapter(string.Format("Select dni AS DNI_Alumno, numerogrupo AS Grupo, idcurso AS Codigo_Curso, fecha AS Fecha from tasistenciaalumno inner join tgrupo on tasistenciaalumno.numerogrupo = tgrupo.numerogrupo where tasistenciaalumno.dni like '%{0}%'", dni), conexion);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
        }

        public void Buscardni(DataGridView dgv, string semestre, int dni)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())

                try
                {
                    //da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni), conexion);
                    da = new SqlDataAdapter(string.Format("select tmatricula.dni, tgrupo.numerogrupo, tmatricula.idcurso from tmatricula inner join tgrupo on tmatricula.numerogrupo = tgrupo.numerogrupo where tgrupo.semestre like '%{0}%' and tmatricula.dni like '%{1}%'", semestre,dni), conexion);
                    //da = new SqlDataAdapter(string.Format("Select dni AS DNI_Alumno, numerogrupo AS Grupo, idcurso AS Codigo_Curso, fecha AS Fecha from tasistenciaalumno inner join tgrupo on tasistenciaalumno.numerogrupo = tgrupo.numerogrupo where tasistenciaalumno.dni like '%{0}%'", dni), conexion);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
        }


        public void Exportarasistencia(DataGridView dgv, int dni, string semestre)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())

                try
                {
                    //da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni), conexion);
                    da = new SqlDataAdapter(string.Format("Select tasistenciaalumno.dni AS DNI_Alumno, tasistenciaalumno.numerogrupo AS Grupo, tasistenciaalumno.idcurso AS Codigo_Curso, tcurso.nombrecurso AS Nombre_Curso,tcurso.horariocurso AS horario, tasistenciaalumno.fecha AS Fecha from tasistenciaalumno inner join tcurso on tasistenciaalumno.idcurso = tcurso.idcurso inner join tgrupo on tcurso.numerogrupo = tgrupo.numerogrupo where tasistenciaalumno.dni like '%{0}%' and tgrupo.semestre like '%{1}%'order by tasistenciaalumno.fecha", dni, semestre), conexion);
                    //da = new SqlDataAdapter(string.Format("Select dni AS DNI_Alumno, numerogrupo AS Grupo, idcurso AS Codigo_Curso, fecha AS Fecha from tasistenciaalumno inner join tgrupo on tasistenciaalumno.numerogrupo = tgrupo.numerogrupo where tasistenciaalumno.dni like '%{0}%'", dni), conexion);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
        }
    }

    
}
