using net8.ntier.Domain.Contracts;

namespace net8.ntier.Domain.Entities
{
    public class User : CreatedAuditedEntity, IBaseEntity, ISoftDelete
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string? SecondLastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //todo: add hashing
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public bool IsLocked { get; set; } = false;
        public DateTime? LastLogin { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
    }
}
