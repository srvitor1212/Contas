﻿using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;
using Microsoft.EntityFrameworkCore;

namespace InfraData.Repositories
{
    public class EntradasRepository : IEntradasRepository
    {
        AppDbContext _context;

        public EntradasRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<Entradas> CreateAsync(Entradas entradas)
        {
            _context.Add(entradas);
            await _context.SaveChangesAsync();

            return entradas;
        }

        public async Task<Entradas> DeleteAsync(Entradas entradas)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Entradas>> GetAllAsync()
        {
            return await _context.Entradas.ToListAsync();
        }

        public async Task<Entradas> GetByIdAsync(int? id)
        {
            return await _context.Entradas.FindAsync(id);
        }

        public async Task<Entradas> RemoveAsync(Entradas entradas)
        {
            _context.Remove(entradas);
            await _context.SaveChangesAsync();
            return entradas;
        }

        public async Task<Entradas> UpdateAsync(Entradas entradas)
        {
            _context.Update(entradas);
            await _context.SaveChangesAsync();
            return entradas;
        }
    }
}
