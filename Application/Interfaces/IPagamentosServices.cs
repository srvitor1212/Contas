using Application.DTOs;

namespace Application.Interfaces
{
    public interface IPagamentosServices
    {
        Task<IEnumerable<PagamentosDTO>> GetAllAsync();
        Task<PagamentosDTO> GetById(string id);
        Task Add(PagamentosDTO recebedoresDTO);
        Task Update(PagamentosDTO recebedoresDTO);
        Task Delete(int? id);
    }
}
