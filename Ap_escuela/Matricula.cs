using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class Matricula
    {
      public String Numerogrupo { get; set; }
      public String Idcurso { get; set; }
      public Int32 Dni { get; set; }

      public Matricula() { }

      public Matricula(String pNumerogrupo, String pIdcurso, Int32 pDni)
      {
          this.Numerogrupo = pNumerogrupo;
          this.Idcurso = pIdcurso;
          this.Dni = pDni;
      }
    }
}
