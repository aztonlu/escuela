using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Ap_escuela.Properties;
using System.Configuration;

namespace Ap_escuela
{
   public class BDComun
    {
       public static string Obtenerstring()
       {
           return Settings.Default.EscuelaConnectionString;
       
       }

       public static SqlConnection ObtnerCOnexion()
       {
           SqlConnection Conn = new SqlConnection(Obtenerstring());
           Conn.Open();

           return Conn;

       }


    }
}
