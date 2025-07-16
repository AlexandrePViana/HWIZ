using HWIZ.Domain.DataTransferObject;

namespace HWIZ.Domain.Interfaces
{
    public interface IUtilizadoresService
    {
        public Task<List<UtilizadoresDTO>> GetUtilizadoresAsync();
        public Task<UtilizadoresDTO> GetUtilizadorAsync(int idUtilizador);
        public Task<UtilizadoresDTO> CreateUtilizadorAsync(UtilizadoresDTO utilizador);
        public Task<UtilizadoresDTO> UpdateUtilizadorAsync(int idUtilizador, UtilizadoresDTO utilizador);
        public Task<bool> DeleteUtilizadorAsync(int idUtilizador);
    }
}
