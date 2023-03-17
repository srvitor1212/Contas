using Application.DTOs;
using AutoMapper;
using Domain.Entities;
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

        public async Task<IEnumerable<DividasDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<DividasDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Add(DividasDTO dividasDTO)
        {
            var dividasEntity = _mapper.Map<Dividas>(dividasDTO);
            await _dividasRepository.CreateAsync(dividasEntity);
        }

        public async Task Update(DividasDTO dividasDTO)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

    }
}
