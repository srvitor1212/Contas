using Application.DTOs;

namespace Application.Services
{
    public interface IDividasService
    {
        Task<IEnumerable<DividasDTO>> GetAllAsync();
        Task<DividasDTO> GetById(string id);
        Task Add(DividasDTO recebedoresDTO);
        Task Update(DividasDTO recebedoresDTO);
        Task Delete(int? id);
    }
}
