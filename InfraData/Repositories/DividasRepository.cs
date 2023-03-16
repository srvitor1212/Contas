using Domain.Entities;
using Domain.Interfaces;

namespace Infra.Data.Repositories
{
    public class DividasRepository : IDividasRepository
    {
        public Task<Dividas> CreateAsync(Dividas dividas)
        {
            throw new NotImplementedException();
        }

        public Task<Dividas> DeleteAsync(Dividas dividas)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dividas>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Dividas> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Dividas> RemoveAsync(Dividas dividas)
        {
            throw new NotImplementedException();
        }

        public Task<Dividas> UpdateAsync(Dividas dividas)
        {
            throw new NotImplementedException();
        }
    }
}
