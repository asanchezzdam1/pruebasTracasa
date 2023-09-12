using Entidades;
using Context;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class RepositorioPersonas : IRepositorioPersonas
    {

        private readonly ContextPersonas _context;

        public RepositorioPersonas(ContextPersonas _context)
        {
            this._context = _context;
        }

        // Existe persona
        public bool PersonaExiste(Guid id)
        {
            Personas personas = _context.personas.FirstOrDefault(p => p.id == id);
            return personas != null ? true : false;
        }

        // Alta persona
        public async Task<Personas> AltaPersona(Personas nuevaPersona)
        {
            if (PersonaExiste(nuevaPersona.id))
            {
                Personas existePersona = _context.personas.First(p => p.id == nuevaPersona.id);
                existePersona.nombre = nuevaPersona.nombre;
                existePersona.fechaNacimiento = nuevaPersona.fechaNacimiento;
                existePersona.telefono = nuevaPersona.telefono;
            }
            else
            {
                _context.personas.Add(nuevaPersona);
            }

            _context.SaveChanges();
            return nuevaPersona;
        }

        // Obtener Personas
        public async Task<IEnumerable<Personas>> ObtenerTodasPersonas()
        {
            return _context.personas;
        }

        // Obtener Una Persona
        public async Task<Personas> ObtenerPersona(Guid id)
        {

            return _context.personas.FirstOrDefault(p => p.id == id);
        }

        // Listado de registros ordenado por nombre, devolviendo los 10 últimos mayores de 21 años
        public async Task<IEnumerable<Personas>> Obtener10()
        {
            var personasMayoresDe21 = await _context.personas.ToListAsync();

            var ultimosMayoresDe21 = personasMayoresDe21
                .Where(p => CalcularEdad(p.fechaNacimiento) > 21)
                .OrderBy(p => p.nombre)
                .TakeLast(10)
                .ToList();

            return ultimosMayoresDe21;
        }


        // Calcular Edad Persona
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

    }
}
