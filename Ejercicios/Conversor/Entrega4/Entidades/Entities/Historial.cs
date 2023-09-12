using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entities
{
    public class Historial
    {
        [Key]
        public Guid id { get; set; }
        [ForeignKey("Usuario")]
        public int idUsuario { get; set; }
        [Required]
        public double cantidad { get; set; }

        [Required]
        public string monedaOrigen { get; set; }

        [Required]
        public string monedaDestino { get; set; }

        public double? resultadoConversion { get; set; }

        [Required]
        public DateTime fechaConversion { get; set; }
  
    }
}