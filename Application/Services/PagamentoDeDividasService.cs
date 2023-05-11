using Application.DTOs;
using Application.Interfaces;

namespace Application.Services
{
    public class PagamentoDeDividasService : IPagamentoDeDividasService
    {
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

        public Task<IEnumerable<PagamentoDeDividasDTO>> GetAllAsync(int? idDivida)
        {
            throw new NotImplementedException();
        }
    }
}
