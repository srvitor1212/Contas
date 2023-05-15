using Application.DTOs;

namespace Application.Interfaces
{
    public interface IPagamentoDeDividasService
    {
        Task<IEnumerable<PagamentoDeDividasDTO>> GetAllAsync();
        Task<PagamentoDeDividasDTO> GetByIdAsync(int id);
        Task<PagamentoDeDividasDTO> CreateAsync(PagamentoDeDividasDTO pagamentoDeDividas);
        Task<PagamentoDeDividasDTO> DeleteAsync(int id);

        //Task<bool> FoiPago(int idDivida, DateTime date);
    }
}
