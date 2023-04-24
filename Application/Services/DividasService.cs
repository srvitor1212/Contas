using Application.DTOs;
using Application.Interfaces;
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
            var dividasEntity = await _dividasRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DividasDTO>>(dividasEntity);
        }

        public async Task<DividasDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<DividasDTO> Add(DividasDTO dividasDTO)
        {
            var dividasEntity = _mapper.Map<Dividas>(dividasDTO);
            dividasEntity.DataCriacao = DateTime.Now;

            var created = await _dividasRepository.CreateAsync(dividasEntity);
            var retDTO = _mapper.Map<DividasDTO>(created);
            return retDTO;
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
