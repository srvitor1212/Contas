using Domain.Entities;
using Domain.Interfaces;

namespace InfraData.Repositories
{
    public class EntradasRepository : IEntradasRepository
    {
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
