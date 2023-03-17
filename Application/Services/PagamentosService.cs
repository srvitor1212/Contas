using Application.DTOs;

namespace Application.Services
{
    public class PagamentosService : IPagamentosServices
    {
        public Task<PagamentosDTO> Add(PagamentosDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }

        public Task<PagamentosDTO> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PagamentosDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PagamentosDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagamentosDTO> Update(PagamentosDTO recebedoresDTO)
        {
            throw new NotImplementedException();
        }
    }
}
