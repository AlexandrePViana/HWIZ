using HWIZ.Domain.DataTransferObject;

namespace HWIZ.Domain.Interfaces
{
    public interface IFeriasService
    {
        public Task<List<FeriasDTO>> GetFeriasAsync();

    }
}
