using Application.DTOs;

namespace Application.Services
{
    public interface IEntradasService
    {
        Task<IEnumerable<EntradasDTO>> GetAllAsync();
        Task<EntradasDTO> GetById(string id);
        Task Add(EntradasDTO recebedoresDTO);
        Task Update(EntradasDTO recebedoresDTO);
        Task Delete(int? id);
    }
}
