using Context;
using Entidades.Entities;
using EntidadesDTO.Monedas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositorios;
using AutoMapper;

namespace ConversoApi.Controllers
{
    [Route("api/monedas")]
    [ApiController]
    public class MonedasControllerAPI : ControllerBase
    {
        private readonly IRepositorioMonedas repositorioMonedas;
        private readonly IMapper _mapper;

        public MonedasControllerAPI(IRepositorioMonedas repositorioMonedas,
        IMapper mapper)
        {
            this.repositorioMonedas = repositorioMonedas;
            _mapper = mapper;
        }

        //Obtener TODAS MONEDAS
        [HttpGet]
        public async Task<ActionResult<List<MonedaVerDto>>> Index()
        {
            var listaMonedas = _mapper.Map<List<MonedaVerDto>>(repositorioMonedas.obtenerTodas());

            return Ok(listaMonedas);
        }

        //Obtener UNA MONEDA
        [HttpGet("{monedaCodigo}", Name = "GetMoneda")]
        public async Task<ActionResult<MonedaVerDto>> GetMoneda([FromRoute] string monedaCodigo)
        {
            var moneda = repositorioMonedas.obtenerMoneda(monedaCodigo);

            if (moneda == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MonedaVerDto>(moneda));
        }

        //Añadir UNA MONEDA
        [HttpPost]
        public async Task<ActionResult<MonedaVerDto>> CreateMoneda([FromBody] MonedaAltaDto moneda)
        {
            var monedaEntidad = _mapper.Map<Moneda>(moneda);

            repositorioMonedas.alta(monedaEntidad);

            var monedaToReturn = _mapper.Map<MonedaVerDto>(monedaEntidad);

            return CreatedAtRoute("GetMoneda",
                new { monedaCodigo = monedaToReturn.codigo },
                monedaToReturn);
        }

        //Eliminar UNA MONEDA
        [HttpDelete("{monedaCodigo}")]
        public async Task<IActionResult> DeleteMoneda([FromRoute] string monedaCodigo)
        {
            var moneda = repositorioMonedas.obtenerMoneda(monedaCodigo);

            if (moneda == null)
            {
                return NotFound();
            }

            repositorioMonedas.eliminarMoneda(moneda.codigo);

            return NoContent();
        }
    }
}
