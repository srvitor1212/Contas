using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;

namespace InfraData.Repositories
{
    public class PagamentosRepository : IPagamentosRepository
    {
        AppDbContext _context;

        public PagamentosRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Task<Pagamentos> CreateAsync(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }

        public Task<Pagamentos> DeleteAsync(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pagamentos>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Pagamentos> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Pagamentos> RemoveAsync(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }

        public Task<Pagamentos> UpdateAsync(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }
    }
}
