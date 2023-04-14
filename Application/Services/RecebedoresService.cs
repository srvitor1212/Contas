using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class RecebedoresService : IRecebedoresService
    {
        private IRecebedoresRepository _recebedoresRepository;
        private readonly IMapper _mapper;

        public RecebedoresService(IRecebedoresRepository recebedoresRepository, IMapper mapper)
        {
            this._recebedoresRepository = recebedoresRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<RecebedoresDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<RecebedoresDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Add(RecebedoresDTO recebedoresDTO)
        {
            var recebedorEntity = _mapper.Map<Recebedores>(recebedoresDTO);
            await _recebedoresRepository.CreateAsync(recebedorEntity);
        }

        public async Task Update(RecebedoresDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

    }
}
