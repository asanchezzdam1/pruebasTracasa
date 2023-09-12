using Entidades.Entities;

namespace Repositorios
{
    public interface IRepositorioHistorial
    {
        List<Historial> obtenerTodas();

        Historial crearRegistroHistorial(string monedaOrigen, string monedaDestino, double cantidad, double resultado);
    }
}