using Context;
using Entidades.Entities;
using EntidadesDTO.Monedas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositorios;
using AutoMapper;
using EntidadesDTO.Paises;

namespace ConversoApi.Controllers
{
    [Route("api/paises")]
    [ApiController]
    public class PaisesControllerAPI : ControllerBase
    {
        private readonly IRepositorioPais repositorioPais;
        private readonly IMapper _mapper;

        public PaisesControllerAPI(IRepositorioPais repositorioPais,
        IMapper mapper)
        {
            this.repositorioPais = repositorioPais;
            _mapper = mapper;
        }

        //Obtener TODOS PAISES
        [HttpGet]
        public async Task<ActionResult<List<PaisVerDto>>> Index()
        {
            var listaPaises = _mapper.Map<List<PaisVerDto>>(repositorioPais.obtenerTodas());

            return Ok(listaPaises);
        }

        //Obtener UN PAIS
        [HttpGet("{paisId}", Name = "GetPais")]
        public async Task<ActionResult<PaisVerDto>> GetPais([FromRoute] Guid paisId)
        {
            var pais = repositorioPais.obtenerPais(paisId);

            if (pais == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PaisVerDto>(pais));
        }

        //Añadir UN PAIS
        [HttpPost]
        public async Task<ActionResult<PaisVerDto>> CreatePais([FromBody] PaisAltaDto pais)
        {
            var paisEntidad = _mapper.Map<Pais>(pais);

            repositorioPais.alta(paisEntidad);

            var paisToReturn = _mapper.Map<PaisVerDto>(paisEntidad);

            return CreatedAtRoute("GetPais",
                new { paisId = paisToReturn.id },
                paisToReturn);
        }

        //Eliminar UN PAIS
        [HttpDelete("{paidId}")]
        public async Task<IActionResult> DeleteMoneda([FromRoute] Guid paidId)
        {
            var pais = repositorioPais.obtenerPais(paidId);

            if (pais == null)
            {
                return NotFound();
            }

            repositorioPais.eliminarPais(pais.id);

            return NoContent();
        }
    }
}
