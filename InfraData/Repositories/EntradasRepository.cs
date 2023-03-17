using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;

namespace InfraData.Repositories
{
    public class EntradasRepository : IEntradasRepository
    {
        AppDbContext _context;

        public EntradasRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Task<Entradas> CreateAsync(Entradas entradas)
        {
            throw new NotImplementedException();
        }

        public Task<Entradas> DeleteAsync(Entradas entradas)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entradas>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entradas> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Entradas> RemoveAsync(Entradas entradas)
        {
            throw new NotImplementedException();
        }

        public Task<Entradas> UpdateAsync(Entradas entradas)
        {
            throw new NotImplementedException();
        }
    }
}
