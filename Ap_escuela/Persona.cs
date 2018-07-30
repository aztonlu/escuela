using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class Persona
    {
      public Int32 Dni { get; set; }
      public String Nombre { get; set; }
      public String Appat { get; set; }
      public String Apmat { get; set; }
      public String Fecha_Nac { get; set; }
      public Int32 Telefono { get; set; }
      public String Correo { get; set; }
      public String Direccion { get; set; }

      public Persona() { }

      public Persona(Int32 pDni, String pNombre, String pAppat, String pApmat, String pFecha_Nac, Int32 pTelefono, String pCorreo, String pDireccion)

      {
          this.Dni = pDni;
          this.Nombre = pNombre;
          this.Appat = pAppat;
          this.Apmat = pApmat;
          this.Fecha_Nac = pFecha_Nac;
          this.Telefono = pTelefono;
          this.Correo = pCorreo;
          this.Direccion = pDireccion;
      
      }
    }
}

