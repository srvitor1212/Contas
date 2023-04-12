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

        public async Task<EntradasDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Add(EntradasDTO entradasDTO)
        {
            var entradasEntity = _mapper.Map<Entradas>(entradasDTO);

            DateTime agora = DateTime.Now;
            entradasEntity.DataCriacao = agora;
            entradasEntity.DataAtualizacao = agora;

            await _entradasRepository.CreateAsync(entradasEntity);
        }

        public async Task Update(EntradasDTO entradasDTO)
        {
            //todo: primeiro usar GetById depois mover os campos
            var entradaEntity = _mapper.Map<Entradas>(entradasDTO);

            DateTime agora = DateTime.Now;
            entradaEntity.DataAtualizacao = agora;

            await _entradasRepository.UpdateAsync(entradaEntity);
        }

        public async Task Delete(int? id)
        {
            throw new NotImplementedException();
        }



    }
}
