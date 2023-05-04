using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPagamentoDeDividasService
    {
        Task<IEnumerable<PagamentoDeDividas>> GetAllAsync(int? idDivida);
        Task<PagamentoDeDividas> CreateAsync(PagamentoDeDividas pagamentoDeDividas);
        Task<PagamentoDeDividas> DeleteAsync(PagamentoDeDividas pagamentoDeDividas);

        Task<bool> FoiPago(int idDivida, DateTime date);
    }
}
