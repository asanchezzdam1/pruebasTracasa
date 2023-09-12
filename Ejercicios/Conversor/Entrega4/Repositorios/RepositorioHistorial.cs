using Context;
using Entidades.Entities;

namespace Repositorios
{
    public class RepositorioHistorial : IRepositorioHistorial 
    {
        private readonly ContextoConversor _context;

        public RepositorioHistorial(ContextoConversor context)
        {
            _context = context;
        }

        public List<Historial> obtenerTodas()
        {
            return _context.historial.ToList();
        }

        public Historial crearRegistroHistorial(string monedaOrigen, string monedaDestino, double cantidad, double resultado)
        {
            Historial listaHistorial = new Historial();

            //listaHistorial.idUsuario = 1;
            listaHistorial.monedaOrigen = monedaOrigen;
            listaHistorial.monedaDestino = monedaDestino;
            listaHistorial.cantidad = cantidad;
            listaHistorial.fechaConversion = DateTime.Now;
            if (resultado != null) listaHistorial.resultadoConversion = resultado;
            else listaHistorial.resultadoConversion = 0;

            _context.Add(listaHistorial);
            _context.SaveChanges();
            return listaHistorial;
        }
    }
}
