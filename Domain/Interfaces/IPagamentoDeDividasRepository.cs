using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPagamentoDeDividasRepository
    {
        Task<IEnumerable<PagamentoDeDividas>> GetAllAsync();
        Task<PagamentoDeDividas> GetByIdAsync(int id);
        Task<PagamentoDeDividas> CreateAsync(PagamentoDeDividas pagamentoDeDividas);
        Task<PagamentoDeDividas> DeleteAsync(PagamentoDeDividas pagamentoDeDividas);

        //      Métodos personalizados
        Task<IEnumerable<PagamentoDeDividas>> GetPagamentosByDivida(int idDivida);
    }
}
