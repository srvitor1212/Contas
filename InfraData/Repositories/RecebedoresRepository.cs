using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;
using Microsoft.EntityFrameworkCore;

namespace InfraData.Repositories
{
    public class RecebedoresRepository : IRecebedoresRepository
    {
        AppDbContext _context;

        public RecebedoresRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<Recebedores> CreateAsync(Recebedores recebedores)
        {
            _context.Add(recebedores);
            await _context.SaveChangesAsync();

            return recebedores;
        }

        public async Task<Recebedores> DeleteAsync(Recebedores recebedores)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Recebedores>> GetAllAsync()
        {
            return await _context.Recebedores.ToListAsync();
        }

        public async Task<Recebedores> GetByIdAsync(int? id)
        {
            return await _context.Recebedores.FindAsync(id);
        }

        public async Task<Recebedores> RemoveAsync(Recebedores recebedores)
        {
            throw new NotImplementedException();
        }

        public async Task<Recebedores> UpdateAsync(Recebedores recebedores)
        {
            throw new NotImplementedException();
        }
    }
}
