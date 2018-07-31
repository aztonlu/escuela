using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_escuela
{
    public class PagoDocente
    {
        public String Idpago { get; set; }
        public String Numerogrupo { get; set; }
        public String Idcurso { get; set; }
        public Int32 Dni { get; set; }
      public Decimal Monto { get; set; }
      public String Fecha { get; set; }
      public String Nrorecibo { get; set; }
      public String Estado { get; set; }
      public String Observacion { get; set; }

      public PagoDocente() { }

      public PagoDocente(String pIdpago, String pNumerogrupo, String pIdcurso, Int32 pDni, Decimal pMonto, String pFecha, String pNrorecibo, String pEstado, String pObservacion)
      {
          this.Idpago = pIdpago;
          this.Numerogrupo = pNumerogrupo;
          this.Idcurso = pIdcurso;
          this.Dni = pDni;
          this.Monto = pMonto;
          this.Fecha = pFecha;
          this.Nrorecibo = pNrorecibo;
          this.Estado = pEstado;
          this.Observacion = pObservacion;
          
      }
    }
}
