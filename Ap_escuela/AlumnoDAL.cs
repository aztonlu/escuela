using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Ap_escuela
{
    class AlumnoDAL
    {
        
        DataTable dt;
        SqlDataAdapter da;

       public static int Agregar(Alumno pAlumno)
       {
           int retorno = 0;
           using (SqlConnection Conn = BDComun.ObtnerCOnexion())
           { 
           SqlCommand Comando=new SqlCommand(string.Format("Insert Into talumno (dni, observacion, interesseguimiento) values ('{0}', '{1}','{2}')",
               pAlumno.Dni, pAlumno.Observacion, pAlumno.Interesseguimiento),Conn);

           retorno = Comando.ExecuteNonQuery();
           Conn.Close();
           
           }
           return retorno;       
       }

       public void Buscar(int dni, DataGridView dgv)
       {
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           try
           {
               da = new SqlDataAdapter(string.Format("Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", dni),conexion);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }

           catch(Exception ex)
           {
               MessageBox.Show("Error" + ex.ToString());
           }
       }


       /*public static List<Alumno> BuscarAlumnos(String pDni)
       {

           List<Alumno> Lista = new List<Alumno>();
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {
               SqlCommand comando = new SqlCommand(string.Format(
                   "Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on tpersona.dni = talumno.dni where tpersona.dni like '%{0}%'", pDni), conexion);

               SqlDataReader reader = comando.ExecuteReader();

               while (reader.Read())
               {
                   Persona pPersona = new Persona();
                   Alumno pAlumno = new Alumno();
                   pPersona.Dni = reader.GetInt32(0);
                   pPersona.Nombre = reader.GetString(1);
                   pPersona.Appat = reader.GetString(2);
                   pPersona.Apmat = reader.GetString(3);
                   pPersona.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));
                   pPersona.Telefono = reader.GetInt32(5);
                   pPersona.Correo = reader.GetString(6);
                   pPersona.Direccion = reader.GetString(7);

                   pAlumno.Observacion = reader.GetString(8);
                   pAlumno.Interesseguimiento = reader.GetString(9);
                   //pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                   //Lista.Add(pPersona);
                   Lista.Add(pAlumno);

               }
               conexion.Close();
               return Lista;

           }
       }*/

       /*public static List<Alumno> BuscarAlumnos(String pNombre, String pApellido)
       {

           List<Alumno> Lista = new List<Alumno>();
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {
               SqlCommand comando = new SqlCommand(string.Format(
                   "Select Id, Nombre,  Apellido, Direccion, Fecha_nacimiento from Alumnos where Nombre like '%{0}%' or Apellido like '%{1}%'", pNombre, pApellido), conexion);

               SqlDataReader reader = comando.ExecuteReader();

               while (reader.Read())
               {
                   Alumno pAlumno = new Alumno();
                   pAlumno.Id = reader.GetInt64(0);
                   pAlumno.Nombre = reader.GetString(1);
                   pAlumno.Apellido = reader.GetString(2);
                   pAlumno.Direccion = reader.GetString(3);
                   pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                   Lista.Add(pAlumno);

               }
               conexion.Close();
               return Lista;

           }

       }*/



       /*public static Alumno ObtenerAlumno(Int64 pId)
       {

           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {

               Alumno pAlumno = new Alumno();
               SqlCommand comando = new SqlCommand(string.Format(
                   "Select Id, Nombre,  Apellido, Direccion, Fecha_nacimiento from Alumnos where Id={0}",pId), conexion);

               SqlDataReader reader = comando.ExecuteReader();

               while (reader.Read())
               {
                   pAlumno.Id = reader.GetInt64(0);
                   pAlumno.Nombre = reader.GetString(1);
                   pAlumno.Apellido = reader.GetString(2);
                   pAlumno.Direccion = reader.GetString(3);
                   pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                   

               }
               conexion.Close();
               return pAlumno;

           }

       }*/



       /*public static int Modificar(Alumno pAlumno)
       {
           int retorno = 0;
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {
               SqlCommand comando = new SqlCommand(string.Format("Update Alumnos set Nombre='{0}', Apellido='{1}', Direccion='{2}', Fecha_Nacimiento='{3}' where Id={4}",
                   pAlumno.Nombre, pAlumno.Apellido, pAlumno.Direccion, pAlumno.Fecha_Nac, pAlumno.Id), conexion);

               retorno = comando.ExecuteNonQuery();
               conexion.Close();
           }
           return retorno;
       
       }*/


       public static int Eliminar(Int64 pId)
       {
           int retorno = 0;
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {

               SqlCommand comando = new SqlCommand(string.Format("Delete from Alumnos where Id={0}", pId), conexion);
               retorno = comando.ExecuteNonQuery();
               conexion.Close();
           }
           return retorno;
       
       }





    }
}
