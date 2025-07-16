namespace HWIZ.Domain.DataTransferObject
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
}
