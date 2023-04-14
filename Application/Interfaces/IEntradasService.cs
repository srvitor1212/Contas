using Application.DTOs;

namespace Application.Interfaces
{
    public interface IEntradasService
    {
        Task<IEnumerable<EntradasDTO>> GetAllAsync();
        Task<EntradasDTO> GetById(int id);
        Task<EntradasDTO> Add(EntradasDTO recebedoresDTO);
        Task Update(EntradasDTO recebedoresDTO);
        Task Delete(int? id);
    }
}
