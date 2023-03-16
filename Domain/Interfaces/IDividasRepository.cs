using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDividasRepository
    {
        Task<Dividas> GetByIdAsync(int? id);
        Task<IEnumerable<Dividas>> GetAllAsync();

        Task<Dividas> CreateAsync(Dividas dividas);
        Task<Dividas> RemoveAsync(Dividas dividas);
        Task<Dividas> UpdateAsync(Dividas dividas);
        Task<Dividas> DeleteAsync(Dividas dividas);
    }
}
