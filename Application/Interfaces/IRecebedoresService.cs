using Application.DTOs;

namespace Application.Services
{
    public interface IRecebedoresService
    {
        Task<IEnumerable<RecebedoresDTO>> GetAllAsync();
        Task<RecebedoresDTO> GetById(string id);
        Task<RecebedoresDTO> Add(RecebedoresDTO recebedoresDTO);
        Task<RecebedoresDTO> Update(RecebedoresDTO recebedoresDTO);
        Task<RecebedoresDTO> Delete(int? id);
    }
}
