using Application.DTOs;

namespace Application.Interfaces
{
    public interface IPagamentoDeDividasService
    {
        Task<IEnumerable<PagamentoDeDividasDTO>> GetAllAsync(int idDivida);
        Task<PagamentoDeDividasDTO> CreateAsync(PagamentoDeDividasDTO pagamentoDeDividas);
        Task<PagamentoDeDividasDTO> DeleteAsync(PagamentoDeDividasDTO pagamentoDeDividas);

        Task<bool> FoiPago(int idDivida, DateTime date);
    }
}
