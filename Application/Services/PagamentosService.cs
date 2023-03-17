using Application.DTOs;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services
{
    public class PagamentosService : IPagamentosServices
    {
        private IPagamentosRepository _pagamentosRepository;
        private readonly IMapper _mapper;

        public PagamentosService(IPagamentosRepository pagamentosRepository, IMapper mapper)
        {
            this._pagamentosRepository = pagamentosRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<PagamentosDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<PagamentosDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Add(PagamentosDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }

        public async Task Update(PagamentosDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

    }
}
