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
            var dividasDTOs = _mapper.Map<IEnumerable<DividasDTO>>(dividasEntity);
            return dividasDTOs;
        }

        public async Task<DividasDTO> GetById(int id)
        {
            var dividaEntity = await _dividasRepository.GetByIdAsync(id);
            return _mapper.Map<DividasDTO>(dividaEntity);
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
            var dividaEntity = await _dividasRepository.GetByIdAsync(dividasDTO.Id);
            if (dividaEntity != null)
            {
                dividaEntity.Update(
                    dividasDTO.Nome,
                    dividasDTO.Valor,
                    dividasDTO.FoiPago,
                    dividasDTO.DataInicio,
                    dividasDTO.DataFim, 
                    dividasDTO.DiaVencimento,
                    dividasDTO.PagamentosId,
                    dividasDTO.RecebedoresId
                    );
                dividaEntity.DataAtualizacao = DateTime.Now;

                await _dividasRepository.UpdateAsync(dividaEntity);
            }
        }

        public async Task Delete(int? id)
        {
            var entityDivida = await _dividasRepository.GetByIdAsync(id);
            await _dividasRepository.DeleteAsync(entityDivida);
        }

    }
}
