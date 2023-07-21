using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    public class ErrorBaseDatosExcepcion : Exception
    {
        public string mensaje{ get; set; }
        public DateTime fechaHoraExcepcion{ get; set; }
        public ErrorBaseDatosExcepcion(string mensaje, DateTime fechaHoraExcepcion ) : base(mensaje) 
        {
            this.mensaje = mensaje;
            this.fechaHoraExcepcion = fechaHoraExcepcion;
        }
        public string toString()
        {
            return mensaje + " a la hora " + fechaHoraExcepcion;
        }
    }
}
