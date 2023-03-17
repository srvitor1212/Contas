using Application.DTOs;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services
{
    public class EntradasService : IEntradasService
    {
        private IEntradasRepository _entradasRepository;
        private readonly IMapper _mapper;

        public EntradasService(IEntradasRepository entradasRepository, IMapper mapper)
        {
            this._entradasRepository = entradasRepository;
            this._mapper = mapper;
        }

        public Task<EntradasDTO> Add(EntradasDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }

        public Task<EntradasDTO> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EntradasDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EntradasDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EntradasDTO> Update(EntradasDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }
    }
}
