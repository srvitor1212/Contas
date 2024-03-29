﻿using Application.Interfaces;
using Application.Mapper;
using Application.Services;
using Domain.Interfaces;
using InfraData.Context;
using InfraData.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InfraIOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            services.AddScoped<IDividasRepository, DividasRepository>();
            services.AddScoped<IEntradasRepository, EntradasRepository>();
            services.AddScoped<IPagamentosRepository, PagamentosRepository>();
            services.AddScoped<IRecebedoresRepository, RecebedoresRepository>();
            services.AddScoped<IPagamentoDeDividasRepository, PagamentoDeDividasRepository>();

            services.AddScoped<IDividasService, DividasService>();
            services.AddScoped<IEntradasService, EntradasService>();
            services.AddScoped<IPagamentosServices, PagamentosService>();
            services.AddScoped<IRecebedoresService, RecebedoresService>();
            services.AddScoped<IPagamentoDeDividasService, PagamentoDeDividasService>();
            services.AddAutoMapper(typeof(DomainToDTO));

            return services;
        }
    }
}
