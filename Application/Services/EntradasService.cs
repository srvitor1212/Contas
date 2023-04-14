using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
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

        public async Task<IEnumerable<EntradasDTO>> GetAllAsync()
        {
            var entradaEntity = await _entradasRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EntradasDTO>>(entradaEntity);
        }

        public async Task<EntradasDTO> GetById(int id)
        {
            var entradaEntity = await _entradasRepository.GetByIdAsync(id);
            return _mapper.Map<EntradasDTO>(entradaEntity);
        }

        public async Task<EntradasDTO> Add(EntradasDTO entradasDTO)
        {
            DateTime agora = DateTime.Now;

            var entradasEntity = _mapper.Map<Entradas>(entradasDTO);
            entradasEntity.DataCriacao = agora;
            entradasEntity.DataAtualizacao = agora;

            var entradaEntityCreated = 
                await _entradasRepository.CreateAsync(entradasEntity);
            var retEntradasDTO = 
                _mapper.Map<EntradasDTO>(entradaEntityCreated);

            return retEntradasDTO;
        }

        public async Task Update(EntradasDTO entradasDTO)
        {
            var entradaEntity = await _entradasRepository.GetByIdAsync(entradasDTO.Id);
            if (entradaEntity != null)
            {
                entradaEntity.Nome = entradasDTO.Nome;
                entradaEntity.Valor = entradasDTO.Valor;
                entradaEntity.DataVigencia = entradasDTO.DataVigencia;
                entradaEntity.DataAtualizacao = DateTime.Now;

                await _entradasRepository.UpdateAsync(entradaEntity);
            }
        }

        public async Task Delete(int? id)
        {
            throw new NotImplementedException();
        }



    }
}
