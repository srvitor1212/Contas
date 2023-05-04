using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class PagamentoDeDividasService : IPagamentoDeDividasService
    {
        public Task<PagamentoDeDividas> CreateAsync(PagamentoDeDividas pagamentoDeDividas)
        {
            throw new NotImplementedException();
        }

        public Task<PagamentoDeDividas> DeleteAsync(PagamentoDeDividas pagamentoDeDividas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FoiPago(int idDivida, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PagamentoDeDividas>> GetAllAsync(int? idDivida)
        {
            throw new NotImplementedException();
        }
    }
}
