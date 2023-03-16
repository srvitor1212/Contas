﻿using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            services.AddScoped<IDividasRepository, DividasRepository>();
            services.AddScoped<IEntradasRepository, EntradasRepository>();
            services.AddScoped<IPagamentosRepository, PagamentosRepository>();
            services.AddScoped<IRecebedoresRepository, RecebedoresRepository>();

            return services;
        }
    }
}
