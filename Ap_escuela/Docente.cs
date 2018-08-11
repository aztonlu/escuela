using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class Docente
    {
      public Int32 Dni { get; set; }
      public String Perfil { get; set; }
      public String Horacreacion { get; set; }

      public Docente() { }

      public Docente(Int32 pDni, String pPerfil, String pHoracreacion)
      {
          this.Dni = pDni;
          this.Perfil = pPerfil;
          this.Horacreacion = pHoracreacion;
      }
    }
}

