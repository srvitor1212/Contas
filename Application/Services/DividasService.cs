using Application.DTOs;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services
{
    public class DividasService : IDividasService
    {
        private IDividasRepository _dividasRepository;
        private readonly IMapper _mapper;

        public DividasService(IDividasRepository dividasRepository, IMapper mapper)
        {
            this._dividasRepository = dividasRepository;
            this._mapper = mapper;
        }

        public async Task<DividasDTO> Add(DividasDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<DividasDTO> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DividasDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<DividasDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<DividasDTO> Update(DividasDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }
    }
}
