using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;

namespace InfraData.Repositories
{
    public class PagamentoDeDividasRepository : IPagamentoDeDividasRepository
    {
        AppDbContext _context;

        public PagamentoDeDividasRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<PagamentoDeDividas> CreateAsync(PagamentoDeDividas pagamentoDeDividas)
        {
            _context.Add(pagamentoDeDividas);
            await _context.SaveChangesAsync();

            return pagamentoDeDividas;
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
