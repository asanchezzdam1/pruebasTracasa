using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploHerencia
{
    public partial class Empleado
    {
        public string nombre{ get; set; }
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        //public Empleado()
        //{

        //}
        protected double diasVacaciones;
        public virtual void CalculoVacaciones()
        {
            diasVacaciones += 10;
        }
        public override string ToString()
        {
            return "El empleado pertenece al grupo: Empleado y su nombre es: " + nombre + ". Y tiene " + diasVacaciones + " dias de vacaciones.";
        }
    }
}