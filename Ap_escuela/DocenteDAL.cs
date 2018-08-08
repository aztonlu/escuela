using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ap_escuela
{
    public class DocenteDAL
    {
        DataTable dt;
        SqlDataAdapter da;

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

        public void BuscarDocente(DataGridView dgv, int dni)
        {
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())

                try
                {
                    //da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni), conexion);
                    da = new SqlDataAdapter(string.Format("Select tdocente.dni AS DNI, nombre AS Nombre, appat AS Apellido_Paterno, apmat AS Apellido_Materno, telefono AS Telefono, correo AS Correo from tpersona inner join tdocente on tpersona.dni = tdocente.dni where tdocente.dni like '%{0}%' ", dni), conexion);
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
