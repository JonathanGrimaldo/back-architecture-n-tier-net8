namespace net8.ntier.Domain.Contracts
{
    public abstract class CreatedAuditedEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
        public int? UpdatedBy { get; set; }
    }
}
