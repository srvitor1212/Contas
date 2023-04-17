﻿using Domain.Entities;
using Domain.Interfaces;
using InfraData.Context;
using Microsoft.EntityFrameworkCore;

namespace InfraData.Repositories
{
    public class PagamentosRepository : IPagamentosRepository
    {
        AppDbContext _context;

        public PagamentosRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<Pagamentos> CreateAsync(Pagamentos pagamentos)
        {
            _context.Add(pagamentos);
            await _context.SaveChangesAsync();

            return pagamentos;
        }

        public async Task<Pagamentos> DeleteAsync(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pagamentos>> GetAllAsync()
        {
            return await _context.Pagamentos.ToListAsync();
        }

        public async Task<Pagamentos> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<Pagamentos> RemoveAsync(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }

        public async Task<Pagamentos> UpdateAsync(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }
    }
}
