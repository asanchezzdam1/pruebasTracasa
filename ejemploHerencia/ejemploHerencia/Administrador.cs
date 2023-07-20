using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre) : base(nombre)
        {
        }
        public override string ToString()
        {
            return "El empleado pertenece al grupo: Administrador y su nombre es: " + nombre;
        }
    }
}