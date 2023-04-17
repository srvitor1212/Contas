using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class PagamentosService : IPagamentosServices
    {
        private IPagamentosRepository _pagamentosRepository;
        private readonly IMapper _mapper;

        public PagamentosService(IPagamentosRepository pagamentosRepository, IMapper mapper)
        {
            this._pagamentosRepository = pagamentosRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<PagamentosDTO>> GetAllAsync()
        {
            var pagamentosEntity = await _pagamentosRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PagamentosDTO>>(pagamentosEntity);
        }

        public async Task<PagamentosDTO> GetById(int id)
        {
            var pagamentoEntity = await _pagamentosRepository.GetByIdAsync(id);
            return _mapper.Map<PagamentosDTO>(pagamentoEntity);
        }

        public async Task<PagamentosDTO> Add(PagamentosDTO pagamentosDTO)
        {
            var pagamentosEntity = _mapper.Map<Pagamentos>(pagamentosDTO);
            pagamentosEntity.DataAtualizacao = DateTime.Now;

            var pagamentosEntityCreated = 
                await _pagamentosRepository.CreateAsync(pagamentosEntity);
            var retPagamentosDTO = 
                _mapper.Map<PagamentosDTO>(pagamentosEntityCreated);

            return retPagamentosDTO;
        }

        public async Task Update(PagamentosDTO pagamentosDTO)
        {
            var pagamentoEntity = await _pagamentosRepository.GetByIdAsync(pagamentosDTO.Id);
            if (pagamentoEntity != null)
            {
                pagamentoEntity.Update(
                    pagamentosDTO.Nome
                    );
                pagamentoEntity.DataAtualizacao = DateTime.Now;

                await _pagamentosRepository.UpdateAsync(pagamentoEntity);
            }
        }

        public async Task Delete(int? id)
        {
            var pagamentoEntity = await _pagamentosRepository.GetByIdAsync(id);
            await _pagamentosRepository.RemoveAsync(pagamentoEntity);
        }

    }
}
