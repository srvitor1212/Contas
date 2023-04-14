using Application.DTOs;

namespace Application.Interfaces
{
    public interface IRecebedoresService
    {
        Task<IEnumerable<RecebedoresDTO>> GetAllAsync();
        Task<RecebedoresDTO> GetById(string id);
        Task<RecebedoresDTO> Add(RecebedoresDTO recebedoresDTO);
        Task Update(RecebedoresDTO recebedoresDTO);
        Task Delete(int? id);
    }
}
