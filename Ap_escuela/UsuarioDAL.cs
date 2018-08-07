using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
    class UsuarioDAL
    {

        public static int CrearCuentas(Usuario pUsuario)
        {
            /*int resultado = 0;
            SqlConnection Conn = BDComun.ObtnerCOnexion();
            
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuarios (Nombre, Contraseña) values ('{0}', '{1}')", pUsuario, pContraseña), Conn);

            resultado = Comando.ExecuteNonQuery();
            Conn.Close();

            

            return resultado;*/
            int retorno = 1;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into tusuarios (dni, usuario, clave) values ('{0}', '{1}','{2}')",
                    pUsuario.Dni, pUsuario.Nombre, pUsuario.Clave), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }



        public static int Autentificar(String pUsuarios, String pContraseña)
        {
            int resultado = 1;

            SqlConnection conexion = BDComun.ObtnerCOnexion();

            /*SqlCommand comando = new SqlCommand(string.Format(
                "Select * From Usuarios Where Nombre = '{0}' and ('{1}',Contraseña) = 1 ", pUsuarios, pContraseña), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }*/

            conexion.Close();
            return resultado;
        }



    }
}
