using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    public partial class Empleado
    {
        public string? telefono { get; set; }
        public Empleado jefe { get; set; }
    }
}
