namespace net8.ntier.API.Dtos.Users
{
    public record class UserCreateRequest
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
