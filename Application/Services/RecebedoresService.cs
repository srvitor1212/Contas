using Application.DTOs;
using AutoMapper;
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

        public async Task<RecebedoresDTO> Add(RecebedoresDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<RecebedoresDTO> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RecebedoresDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<RecebedoresDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<RecebedoresDTO> Update(RecebedoresDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }
    }
}
