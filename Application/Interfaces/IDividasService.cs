using Application.DTOs;

namespace Application.Services
{
    public interface IDividasService
    {
        Task<IEnumerable<DividasDTO>> GetAllAsync();
        Task<DividasDTO> GetById(string id);
        Task<DividasDTO> Add(DividasDTO recebedoresDTO);
        Task<DividasDTO> Update(DividasDTO recebedoresDTO);
        Task<DividasDTO> Delete(int? id);
    }
}
