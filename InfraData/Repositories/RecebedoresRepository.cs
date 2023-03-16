using Domain.Entities;
using Domain.Interfaces;

namespace Infra.Data.Repositories
{
    public class RecebedoresRepository : IRecebedoresRepository
    {
        public Task<Recebedores> CreateAsync(Recebedores recebedores)
        {
            throw new NotImplementedException();
        }

        public Task<Recebedores> DeleteAsync(Recebedores recebedores)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recebedores>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Recebedores> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Recebedores> RemoveAsync(Recebedores recebedores)
        {
            throw new NotImplementedException();
        }

        public Task<Recebedores> UpdateAsync(Recebedores recebedores)
        {
            throw new NotImplementedException();
        }
    }
}
