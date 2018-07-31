using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class Asistenciaalumno
    {
         public Int32 Dni { get; set; }
      public String Numerogrupo { get; set; }
      public String Idcurso { get; set; }
      public String Fecha { get; set; }

      public Asistenciaalumno() { }

      public Asistenciaalumno(Int32 pDni, String pNumerogrupo, String pIdcurso, String pFecha)
      {
          this.Dni = pDni;
          this.Numerogrupo = pNumerogrupo;
          this.Idcurso = pIdcurso;
          this.Fecha = pFecha;
      }
    }
}
