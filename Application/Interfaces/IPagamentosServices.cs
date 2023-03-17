using Application.DTOs;

namespace Application.Services
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
