using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPagamentosRepository
    {
        Task<Pagamentos> GetByIdAsync(int? id);
        Task<IEnumerable<Pagamentos>> GetAllAsync();

        Task<Pagamentos> CreateAsync(Pagamentos pagamentos);
        Task<Pagamentos> RemoveAsync(Pagamentos pagamentos);
        Task<Pagamentos> UpdateAsync(Pagamentos pagamentos);
        Task<Pagamentos> DeleteAsync(Pagamentos pagamentos);
    }
}
