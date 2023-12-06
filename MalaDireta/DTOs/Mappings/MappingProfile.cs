using AutoMapper;
using MalaDireta.Models;

namespace MalaDireta.DTOs.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
                CreateMap<Cliente, ClienteDTO>().ReverseMap();
                CreateMap<Endereco, EnderecoDTO>().ReverseMap();
        }
    }
}
