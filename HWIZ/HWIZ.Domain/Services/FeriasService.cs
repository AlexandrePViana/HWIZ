using HWIZ.Data.Interfaces;
using HWIZ.Data.Models;
using HWIZ.Domain.ClassMapper;
using HWIZ.Domain.DataTransferObject;
using HWIZ.Domain.Interfaces;

namespace HWIZ.Domain.Services
{
    public class FeriasService : IFeriasService
    {
        private readonly IBaseRepository<Ferias> _repository;

        public FeriasService(IBaseRepository<Ferias> repository)
        {
            _repository = repository;
        }
        public async Task<List<FeriasDTO>> GetFeriasAsync()
        {
            var ferias = await _repository.GetAllAsync();
            var feriasDTO = ferias.Select(SimpleMapper.Map<Ferias, FeriasDTO>).ToList();
            return feriasDTO;
        }
    }
}
