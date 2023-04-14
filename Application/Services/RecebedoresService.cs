﻿using Application.DTOs;
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

        public async Task<RecebedoresDTO> Add(RecebedoresDTO recebedoresDTO)
        {
            DateTime agora = DateTime.Now;

            var recebedorEntity = _mapper.Map<Recebedores>(recebedoresDTO);
            recebedorEntity.DataCriacao = agora;
            recebedorEntity.DataAtualizacao = agora;

            var recebedorEntityCreated =
                await _recebedoresRepository.CreateAsync(recebedorEntity);
            var retRecebedorDTO = 
                _mapper.Map<RecebedoresDTO>(recebedorEntityCreated);

            return retRecebedorDTO;
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
