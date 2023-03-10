using Contas.Domain.Entities;

namespace Contas.Domain.Interfaces
{
    public interface IRecebedoresRepository
    {
        Task<Recebedores> GetByIdAsync(int? id);
        Task<IEnumerable<Recebedores>> GetAllAsync();

        Task<Recebedores> CreateAsync(Recebedores recebedores);
        Task<Recebedores> RemoveAsync(Recebedores recebedores);
        Task<Recebedores> UpdateAsync(Recebedores recebedores);
        Task<Recebedores> DeleteAsync(Recebedores recebedores);        
    }
}
