using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;
using Microsoft.EntityFrameworkCore;

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

        public async Task<PagamentoDeDividas> DeleteAsync(PagamentoDeDividas pagamentoDeDividas)
        {
            _context.PagamentoDeDividas.Remove(pagamentoDeDividas);
            await _context.SaveChangesAsync();
            return pagamentoDeDividas;
        }

        public async Task<bool> FoiPago(int idDivida, DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PagamentoDeDividas>> GetAllAsync()
        {
            var entity = await _context.PagamentoDeDividas.ToListAsync();
            return entity;
        }

        public async Task<PagamentoDeDividas> GetByIdAsync(int id)
        {
            var entity = await _context.PagamentoDeDividas.FindAsync(id);
            if (entity == null)
                return null;

            return entity;
        }

        public async Task<IEnumerable<PagamentoDeDividas>> GetPagamentosByDivida(int idDivida)
        {
            var pagamentos = 
                _context.PagamentoDeDividas
                .Where(x => x.DividasId == idDivida)
                .ToList();

            return pagamentos;
        }
    }
}
