namespace net8.ntier.API.Dtos.Users
{
    public record class UserUpdateRequest
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}
