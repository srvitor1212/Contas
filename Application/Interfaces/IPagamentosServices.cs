using Application.DTOs;

namespace Application.Services
{
    public interface IPagamentosServices
    {
        Task<IEnumerable<PagamentosDTO>> GetAllAsync();
        Task<PagamentosDTO> GetById(string id);
        Task<PagamentosDTO> Add(PagamentosDTO recebedoresDTO);
        Task<PagamentosDTO> Update(PagamentosDTO recebedoresDTO);
        Task<PagamentosDTO> Delete(int? id);
    }
}
