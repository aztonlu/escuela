using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class Usuario
    {
      public Int32 Dni { get; set; }
      public String Nombre { get; set; }
      public String Clave { get; set; }

      public Usuario() { }

      public Usuario(Int32 pDni, String pNombre, String pClave)

      {
          this.Dni = pDni;
          this.Nombre = pNombre;
          this.Clave = pClave;
          
      }
    }
}
