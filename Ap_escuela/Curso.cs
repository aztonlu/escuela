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
      public Int32 Dni { get; set; }
      public Decimal Monto { get; set; }
      public String Horariocurso { get; set; }
      public String Horacreacion { get; set; }

      public Curso() { }

      public Curso(String pIdcurso, String pNombrecurso, String pNumerogrupo, Int32 pDni, Decimal pMonto, String pHorariocurso, String pHoracreacion)

      {
          this.Idcurso = pIdcurso;
          this.Nombrecurso = pNombrecurso;
          this.Numerogrupo = pNumerogrupo;
          this.Dni = pDni;
          this.Monto = pMonto;
          this.Horariocurso = pHorariocurso;
          this.Horacreacion = pHoracreacion;
          
      }
    }
}

