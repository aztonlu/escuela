﻿using System;
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

        public void Buscarcarga(DataGridView dgv)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())

                try
                {
                    //da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni), conexion);
                    da = new SqlDataAdapter(string.Format("Select dni AS DNI_Alumno, numerogrupo AS Grupo, idcurso AS Codigo_Curso, fecha AS Fecha from tasistenciaalumno"), conexion);
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
