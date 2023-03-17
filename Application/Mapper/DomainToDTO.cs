using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO() 
        { 
            CreateMap<Dividas, DividasDTO>();
            CreateMap<Entradas, EntradasDTO>();
            CreateMap<Pagamentos, PagamentosDTO>();
            CreateMap<Recebedores, RecebedoresDTO>();
        }
    }
}
