using HWIZ.Domain.Interfaces;
using HWIZ.Data.Interfaces;
using HWIZ.Data.Models;
using HWIZ.Domain.ClassMapper;
using HWIZ.Domain.DataTransferObject;
using Microsoft.IdentityModel.Tokens;

namespace HWIZ.Domain.Services
{
    public class UtilizadoresService : IUtilizadoresService
    {
        private readonly IBaseRepository<Utilizadores> _repository;

        public UtilizadoresService(IBaseRepository<Utilizadores> repository)
        {
            _repository = repository;
        }

        public async Task<List<UtilizadoresDTO>> GetUtilizadoresAsync()
        {
            var utilizadores = await _repository.GetAllAsync();
            var utilizadoresDTO = utilizadores.Select(SimpleMapper.Map<Utilizadores, UtilizadoresDTO>).ToList();
            return utilizadoresDTO;
        }
        public Task<UtilizadoresDTO> GetUtilizadorAsync(int idUtilizador)
        {
            throw new NotImplementedException();
        }
        public Task<UtilizadoresDTO> CreateUtilizadorAsync(UtilizadoresDTO utilizador)
        {
            throw new NotImplementedException();
        }
        public Task<UtilizadoresDTO> UpdateUtilizadorAsync(int idUtilizador, UtilizadoresDTO utilizador)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteUtilizadorAsync(int idUtilizador)
        {
            throw new NotImplementedException();
        }

    }
}
