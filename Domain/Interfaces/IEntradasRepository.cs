using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IEntradasRepository
    {
        Task<Entradas> GetByIdAsync(int? id);
        Task<IEnumerable<Entradas>> GetAllAsync();

        Task<Entradas> CreateAsync(Entradas entradas);
        Task<Entradas> RemoveAsync(Entradas entradas);
        Task<Entradas> UpdateAsync(Entradas entradas);
        Task<Entradas> DeleteAsync(Entradas entradas);
    }
}
