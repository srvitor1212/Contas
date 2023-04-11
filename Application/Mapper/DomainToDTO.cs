using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO() 
        { 
            CreateMap<Dividas, DividasDTO>().ReverseMap();
            CreateMap<Entradas, EntradasDTO>().ReverseMap();
            CreateMap<Pagamentos, PagamentosDTO>().ReverseMap();
            CreateMap<Recebedores, RecebedoresDTO>().ReverseMap();
        }
    }
}
