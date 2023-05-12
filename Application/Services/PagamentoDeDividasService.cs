using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class PagamentoDeDividasService : IPagamentoDeDividasService
    {
        private IPagamentoDeDividasRepository _pagamentoDeDividasRepository;
        private IDividasRepository _dividasRepository;
        private readonly IMapper _mapper;
        public PagamentoDeDividasService(
            IPagamentoDeDividasRepository pagamentoDeDividasRepository,
            IDividasRepository dividasRepository,
            IMapper mapper)
        {
            this._pagamentoDeDividasRepository = pagamentoDeDividasRepository;
            this._dividasRepository = dividasRepository;
            this._mapper = mapper;
        }


        public async Task<PagamentoDeDividasDTO> CreateAsync(PagamentoDeDividasDTO pagamentoDeDividasDTO)
        {
            DateTime agora = DateTime.Now;

            PagamentoDeDividas pagamentosEntity = new PagamentoDeDividas();
            pagamentosEntity.DividasId = pagamentoDeDividasDTO.DividasId;
            pagamentosEntity.DataCriacao = agora;
            pagamentosEntity.DataAtualizacao = agora;

            if (pagamentoDeDividasDTO.DataEfetivacao.Year.ToString() == "1")
                pagamentosEntity.DataEfetivacao = DateTime.Now;
            else
                pagamentosEntity.DataEfetivacao = pagamentoDeDividasDTO.DataEfetivacao;
            
            var created = await _pagamentoDeDividasRepository.CreateAsync(pagamentosEntity);
            var retDTO = _mapper.Map<PagamentoDeDividasDTO>(created);
            return retDTO;
        }

        public Task<PagamentoDeDividasDTO> DeleteAsync(PagamentoDeDividasDTO pagamentoDeDividas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FoiPago(int idDivida, DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PagamentoDeDividasDTO>> GetAllAsync(int idDivida)
        {
            var entity = await _dividasRepository.GetByIdAsync(idDivida);

            //todo: todoas que for idDivida
            throw new NotImplementedException();
        }
    }
}
