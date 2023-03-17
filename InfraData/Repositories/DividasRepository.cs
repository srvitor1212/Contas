using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;

namespace InfraData.Repositories
{
    public class DividasRepository : IDividasRepository
    {
        AppDbContext _context;

        public DividasRepository(AppDbContext context)
        {
            this._context = context;
        }

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
