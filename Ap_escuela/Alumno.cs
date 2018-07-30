using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
  public  class Alumno
    {

      public Int32 Dni { get; set; }
      public String Observacion { get; set; }
      public String Interesseguimiento { get; set; }

      public Alumno() { }

      public Alumno(Int32 pDni, String pObservacion, String pInteresseguimiento)

      {
          this.Dni = pDni;
          this.Observacion = pObservacion;
          this.Interesseguimiento = pInteresseguimiento;
          
      }


    }
}
