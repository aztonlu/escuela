using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class Grupo
    {
      public String Numerogrupo { get; set; }
      public String Horariogrupo { get; set; }

      public Grupo() { }

      public Grupo(String pNumerogrupo, String pHorariogrupo)

      {
          this.Numerogrupo = pNumerogrupo;
          this.Horariogrupo = pHorariogrupo;
          
      }
    }
}


