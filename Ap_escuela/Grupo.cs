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
      public String Semestre { get; set; }
      public String Horacreacion { get; set; }

      public Grupo() { }

      public Grupo(String pNumerogrupo, String pHorariogrupo, String pSemestre, String pHoracreacion)

      {
          this.Numerogrupo = pNumerogrupo;
          this.Horariogrupo = pHorariogrupo;
          this.Semestre = pSemestre;
          this.Horacreacion = pHoracreacion;
          
      }
    }
}


