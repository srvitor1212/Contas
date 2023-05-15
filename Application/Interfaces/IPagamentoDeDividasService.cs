using Application.DTOs;

namespace Application.Interfaces
{
    public interface IPagamentoDeDividasService
    {
        Task<IEnumerable<PagamentoDeDividasDTO>> GetAllAsync();
        Task<PagamentoDeDividasDTO> GetByIdAsync(int id);
        Task<PagamentoDeDividasDTO> CreateAsync(PagamentoDeDividasDTO pagamentoDeDividas);
        Task DeleteAsync(int id);

        //      Métodos personalizados
        Task<IEnumerable<PagamentoDeDividasDTO>> GetPagamentosByDivida(int idDivida);

    }
}
