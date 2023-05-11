using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;

namespace Application.Services
{
    public class PagamentoDeDividasService : IPagamentoDeDividasService
    {
        private IPagamentoDeDividasRepository _pagamentoDeDividasRepository;
        private IDividasRepository _dividasRepository;
        public PagamentoDeDividasService(
            IPagamentoDeDividasRepository pagamentoDeDividasRepository,
            IDividasRepository dividasRepository)
        {
            this._pagamentoDeDividasRepository = pagamentoDeDividasRepository;
            this._dividasRepository = dividasRepository;
        }


        public Task<PagamentoDeDividasDTO> CreateAsync(PagamentoDeDividasDTO pagamentoDeDividas)
        {
            throw new NotImplementedException();
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
