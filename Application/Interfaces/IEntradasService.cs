using Application.DTOs;

namespace Application.Services
{
    public interface IEntradasService
    {
        Task<IEnumerable<EntradasDTO>> GetAllAsync();
        Task<EntradasDTO> GetById(string id);
        Task<EntradasDTO> Add(EntradasDTO recebedoresDTO);
        Task<EntradasDTO> Update(EntradasDTO recebedoresDTO);
        Task<EntradasDTO> Delete(int? id);
    }
}
