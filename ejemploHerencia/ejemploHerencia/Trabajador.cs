using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploHerencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre) : base(nombre)
        {
        }
        public override string ToString()
        {
            return "El empleado pertenece al grupo: Trabajador y su nombre es: " + nombre;
        }
    }
}