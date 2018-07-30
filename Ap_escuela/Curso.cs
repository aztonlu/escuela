using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class Curso
    {
      public String Idcurso { get; set; }
      public String Nombrecurso { get; set; }
      public String Numerogrupo { get; set; }
      public String dni { get; set; }

      public Curso() { }

      public Curso(String pIdcurso, String pInteresseguimiento, String pObservacion, String pInteresseguimiento)

      {
          this.Dni = pDni;
          this.Observacion = pObservacion;
          this.Interesseguimiento = pInteresseguimiento;
          
      }
    }
}

