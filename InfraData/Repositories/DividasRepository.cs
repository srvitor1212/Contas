﻿using Domain.Entities;
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
            var entity = await _context.Dividas.FindAsync(id);
            if (entity == null)
                return null;

            // só fazendo isso já carrega os dados dentro de "entity"
            var pag = await _context.Pagamentos.FindAsync(entity.PagamentosId);
            var rec = await _context.Recebedores.FindAsync(entity.RecebedoresId);

            return entity;
        }

        public async Task<Dividas> DeleteAsync(Dividas dividas)
        {
            _context.Dividas.Remove(dividas);
            await _context.SaveChangesAsync();
            return dividas;
        }

        public async Task<Dividas> UpdateAsync(Dividas dividas)
        {
            _context.Update(dividas);
            await _context.SaveChangesAsync();
            return dividas;
        }
    }
}
