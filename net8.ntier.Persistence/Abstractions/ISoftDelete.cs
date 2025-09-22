namespace net8.ntier.Persistence.Abstractions
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
