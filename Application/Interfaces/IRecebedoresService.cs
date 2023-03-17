using Application.DTOs;

namespace Application.Services
{
    public interface IRecebedoresService
    {
        Task<IEnumerable<RecebedoresDTO>> GetAllAsync();
        Task<RecebedoresDTO> GetById(string id);
        Task Add(RecebedoresDTO recebedoresDTO);
        Task Update(RecebedoresDTO recebedoresDTO);
        Task Delete(int? id);
    }
}
