using Domain.Entities;
using Domain.Interfaces;

namespace InfraData.Repositories
{
    public class PagamentoDeDividasRepository : IPagamentoDeDividasRepository
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
