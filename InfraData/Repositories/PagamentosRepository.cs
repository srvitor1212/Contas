using Domain.Entities;
using Domain.Interfaces;

namespace Infra.Data.Repositories
{
    public class PagamentosRepository : IPagamentosRepository
    {
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
