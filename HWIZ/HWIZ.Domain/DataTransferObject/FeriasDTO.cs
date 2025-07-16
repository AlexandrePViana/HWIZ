namespace HWIZ.Domain.DataTransferObject
{
    public class FeriasDTO : BaseDTO
    {
        public int? IdUtilizador { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
