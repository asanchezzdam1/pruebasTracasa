using AutoMapper;
using Entidades;
using EntidadesDTO;
namespace API_PERSONAS.Profiles
{
    public class PersonasProfile : Profile
    {
        public PersonasProfile()
        {
            CreateMap<Personas, PersonasVer>();
            CreateMap<CrearPersonas, Personas>();
        }
    }
}
