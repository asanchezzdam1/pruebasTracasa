using Entidades;

namespace Repositorios
{
    public interface IRepositorioPersonas
    {
        bool PersonaExiste(Guid id);
        Task<Personas> AltaPersona(Personas nuevaPersona);
        Task<IEnumerable<Personas>> ObtenerTodasPersonas();
        Task<Personas> ObtenerPersona(Guid id);
        Task<IEnumerable<Personas>> Obtener10();
    }
}
