using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;
using Microsoft.EntityFrameworkCore;

namespace InfraData.Repositories
{
    public class DividasRepository : IDividasRepository
    {
        AppDbContext _context;

        public DividasRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<Dividas> CreateAsync(Dividas dividas)
        {
            _context.Add(dividas);
            await _context.SaveChangesAsync();

            return dividas;
        }

        public async Task<Dividas> DeleteAsync(Dividas dividas)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dividas>> GetAllAsync()
        {
            var dividas = await _context.Dividas
                .Include(x => x.Pagamentos)
                .Include(x => x.Recebedores)
                .ToListAsync();
            return dividas;
        }

        public async Task<Dividas> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<Dividas> RemoveAsync(Dividas dividas)
        {
            throw new NotImplementedException();
        }

        public async Task<Dividas> UpdateAsync(Dividas dividas)
        {
            throw new NotImplementedException();
        }
    }
}
