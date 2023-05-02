using Application.DTOs;

namespace Application.Interfaces
{
    public interface IDividasService
    {
        Task<IEnumerable<DividasDTO>> GetAllAsync();
        Task<DividasDTO> GetById(int id);
        Task<DividasDTO> Add(DividasDTO recebedoresDTO);
        Task Update(DividasDTO recebedoresDTO);
        Task Delete(int? id);
    }
}
