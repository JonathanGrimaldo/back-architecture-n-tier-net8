namespace net8.ntier.Domain.Contracts
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
